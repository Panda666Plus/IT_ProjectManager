using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace Asai.Mail
{
    class SendMail
    {

        #region 数据成员
        //收件人地址
        private string m_To = "";
        //抄送人地址
        private string m_CC = "";
        //发件人地址
        private string m_From = "";
        //邮件标题
        private string m_Subject = "";
        //邮件正文
        private string m_Body = "";
        //发送服务器名或地址
        private string m_Host = "";
        //发件人用户名
        private string m_UserName = "";
        //发件人密码
        private string m_Password = "";
        //邮件附件
        private string m_File = "";
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数重载
        /// </summary>
        /// <param name="to">收件人地址</param>
        /// <param name="CC">抄件人地址</param>
        /// <param name="from">发件人地址</param>
        /// <param name="subject">邮件标题</param>
        /// <param name="body">邮件正文</param>
        /// <param name="host">发送邮件服务器名或地址</param>
        /// <param name="userName">发件人用户名</param>
        /// <param name="password">发件人密码</param>
        public SendMail(string to,string CC, string from, string subject, string body, string host, string userName, string password, string fileName)
        {
            m_To = to;
            m_CC = CC;
            m_From = from;
            m_Subject = subject;
            m_Body = body;
            m_Host = host;
            m_UserName = userName;
            m_Password = password;
            m_File = fileName;
        }
        #endregion

        #region 数据属性
        //收件人地址
        public string TO
        {
            get
            {
                return m_To;
            }
            set
            {
                m_To = value;
            }
        }

        //抄件人地址
        public string CC
        {
            get
            {
                return m_CC;
            }
            set
            {
                m_CC = value;
            }
        }

        //发件人地址
        public string From
        {
            get
            {
                return m_From;
            }
            set
            {
                m_From = value;
            }
        }

        //邮件标题
        public string Subject
        {
            get
            {
                return m_Subject;
            }
            set
            {
                m_Subject = value;
            }
        }

        //邮件正文
        public string Body
        {
            get
            {
                return m_Body;
            }
            set
            {
                m_Body = value;
            }
        }

        //服务器地址（名）
        public string Host
        {
            get
            {
                return m_Host;
            }
            set
            {
                m_Host = value;
            }
        }

        //发件人的用户名
        public string UserName
        {
            get
            {
                return m_UserName;
            }
            set
            {
                m_UserName = value;
            }
        }

        //发件人的密码
        public string Password
        {
            get
            {
                return m_Password;
            }
            set
            {
                m_Password = value;
            }
        }

        //邮件附件
        public string File
        {
            get
            {
                return m_File;
            }
            set
            {
                m_File = value;
            }
        }
        #endregion
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <returns>发送是否成功</returns>
        public bool Send()
        {
            try
            {
                //获取所有的收件人地址
                char[] ch = { ';' };
                string[] address = m_To.Split(ch);
                string[] CCaddress = m_CC.Split(ch);
                MailAddressCollection allAddress = new MailAddressCollection();
                //发件人地址
                MailAddress fromAddress = new MailAddress(m_From);

                MailMessage msg = new MailMessage();
                msg.From = fromAddress;
                for (int i = 0; i < address.Length; i++)
                {
                    //收件人地址
                   msg.To.Add(address[i]);
                }
                //抄送人地址
                for (int i = 0; i <CCaddress.Length; i++)
                {
                    //收件人地址
                    msg.CC.Add(CCaddress[i]);
                }     
                //MailAddress toAddress = new MailAddress(TO);
                    //抄送人地址
                    //MailAddress CCAddress = new MailAddress(CCaddress[i]);
                //MailAddress CCAddress = new MailAddress(CC);
                 
                    //定义邮件消息
                    //MailMessage msg = new MailMessage(fromAddress, allAddress);
                   
                    ///定义抄送人
                    //msg.CC.Add(CCAddress);

                    //邮件标题
                    msg.Subject = m_Subject;
                    //邮件正文
                    msg.Body = m_Body;
                    msg.IsBodyHtml = true;
                    //获取所有邮件附件
                    char[] cr = { ';' };
                    string[] file = m_File.Split(cr);
                    for (int n = 0; n < file.Length; n++)
                    {
                        if (file[n] != "")
                        {
                            //附件对象
                            Attachment data = new Attachment(file[n], MediaTypeNames.Application.Octet);
                            //附件资料
                            ContentDisposition disposition = data.ContentDisposition;
                            disposition.CreationDate = System.IO.File.GetCreationTime(file[n]);
                            disposition.ModificationDate = System.IO.File.GetLastWriteTime(file[n]);
                            disposition.ReadDate = System.IO.File.GetLastAccessTime(file[n]);
                            //加入邮件附件
                            msg.Attachments.Add(data);
                        }
                    }

                    //使用简单邮件传输协议来传送邮件
                    SmtpClient sendMail = new SmtpClient();
                    //发送邮件的服务器名或地址
                    sendMail.Host = m_Host;
                    //验证发件人的身份
                    sendMail.Credentials = new NetworkCredential(m_UserName, m_Password);
                    //处理待发送邮件的方法
                    sendMail.DeliveryMethod = SmtpDeliveryMethod.Network;

                    //发送邮件
                    sendMail.Send(msg);
                //}
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }

}
