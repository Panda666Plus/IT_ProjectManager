using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
namespace ProjectManagerService
{
    class threadClass
    {
        private static threadClass _intance = null;
        public static threadClass Intance
        {
            get
            {
                if (_intance == null)
                    _intance = new threadClass();
                return _intance;
            }
        }
        public Timer timer1 { get; set; }
        public Timer timer2 { get; set; }
        public void Dowork()
        {
            LogHelper.writerlog("线程正在准备启动定时器 ");
            #region 定时器一  排期项目调整为进行状态
            ///  间隔时间24小时,87840000ms
            ///  排期项目调整为进行状态
            ///  
            timer1 = time1proc();
            #endregion


            #region 定时器二    任务到期日期前两天每天邮件提醒功能
            ///  间隔时间24小时,87840000ms
            ///   任务到期日期前两天每天邮件提醒功能
            ///  
            timer2 = time2proc();

            #endregion
        }

        #region time1proc
        /// <summary>
        /// 间隔时间24小时,87840000ms
        ///  排期项目调整为进行状态
        /// </summary>
        private Timer time1proc()
        {
            LogHelper.writerlog("线程启动定时器一 ", 11);
            DataSet ds = DbServices.DbHelperSQL.Query(String.Format("select runtime from IT_ScheduleSetup where kind='A'"));
            double betweentime = 0;
            if (ds != null)
            {
                string runtime = ds.Tables[0].Rows[0][0].ToString();
                string nowtime = DateTime.Now.ToString("HH:mm");

                if (DateTime.Parse(runtime) < DateTime.Parse(nowtime))
                    betweentime = (DateTime.Parse(runtime).AddDays(1) - DateTime.Parse(nowtime)).TotalMilliseconds;
                else
                    betweentime = (DateTime.Parse(runtime) - DateTime.Parse(nowtime)).TotalMilliseconds;


            }

            Timer time1 = new Timer(delegate
            {
                try
                {
                    DbServices.DbHelperSQL.ExecuteSql(string.Format(" update IT_Scheme " +
                                                                     " set SmStatus=16  " +
                                                                     " where SmStatus=15 and  " +
                                                                     " convert (nvarchar(10),SmStartDate,120)<=convert (nvarchar(10),GETDATE(),120)"));
                    LogHelper.writerlog(DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "已成功转排期为进行!", 3001);

                }
                catch (Exception er)
                {
                    LogHelper.writerlog(DateTime.Now.ToString("yyyy-MM-dd HH:mm") + " 转排期为进行失败!出错原因:\n" + er.Message, 6661);

                }

            }, null, (long)betweentime, 87840000);
            return time1;
        }
        #endregion

        #region time2proc
        /// <summary>
        ///   间隔时间24小时,87840000ms
        ///   任务到期日期前两天每天邮件提醒功能
        ///  
        /// </summary>
        private Timer time2proc()
        {

            LogHelper.writerlog("线程启动定时器二 ", 22);
            DataSet ds = DbServices.DbHelperSQL.Query(String.Format("select runtime,CC from IT_ScheduleSetup where kind='B'"));
            double betweentime = 0;
            if (ds != null)
            {
                string runtime = ds.Tables[0].Rows[0][0].ToString();
                string nowtime = DateTime.Now.ToString("HH:mm");

                if (DateTime.Parse(runtime) < DateTime.Parse(nowtime))
                    betweentime = (DateTime.Parse(runtime).AddDays(1) - DateTime.Parse(nowtime)).TotalMilliseconds;
                else
                    betweentime = (DateTime.Parse(runtime) - DateTime.Parse(nowtime)).TotalMilliseconds;


            }

            Timer time1 = new Timer(delegate
              {
                  try
                  {
                      using (DataTable dt = DbServices.DbHelperSQL.Query("getNotifymail").Tables[0])
                      {
                          Asai.Mail.SendMail newmail = null;
                          string strbody = "";
                          string strtooltip = "";
                          if (dt != null)
                          {
                              List<string> tolist = new List<string>();
                              List<string> cclist = new List<string>();
                              string ccstr = ds.Tables[0].Rows[0][1].ToString();
                              Array.ForEach<DataRow>(dt.Select(), m =>
                              {
                                  tolist.Clear();
                                  cclist.Clear();
                                  if (int.Parse(m["bd"].ToString()) < 0)
                                      strtooltip = "还差" + Math.Abs(int.Parse(m["bd"].ToString())).ToString() + "天即将到期,尚末完成";
                                  if (int.Parse(m["bd"].ToString()) == 0)
                                      strtooltip = "今日到期,尚末完成";
                                  if (int.Parse(m["bd"].ToString()) > 0)
                                      strtooltip = "已过期" + m["bd"].ToString() + "天,尚末完成";
                                  strbody = string.Format(@"<p>
                                                        <strong><span >亲</span></strong>:</p>
                                                    <p>
                                                        &nbsp;&nbsp;&nbsp; 早上好！<br/>
                                                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 今天是:{0}</p>
                                                    <p>
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 您有下列项目{1}，请注意项目进度！</p>
                                                    <table
                                                        style='table-layout: fixed; border-collapse: collapse; border:1px solid black;width:100%;'>
                                                     <caption ><span style =' font-size:20px; font-weight:bolder ; color :#dd1c20; '>提示任务详情</span></caption>   
                                                     <tr>
                                                            <td>
                                                                项目名称:</td>
                                                            <td>
                                                               &nbsp;&nbsp;&nbsp;{2}</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                模块名称:</td>
                                                            <td>
                                                                &nbsp;&nbsp;&nbsp;{3}</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                任务名称:</td>
                                                            <td>
                                                               &nbsp;&nbsp;&nbsp;{4}</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                任务开始日期:&nbsp;&nbsp;{5}</td>
                                                            <td>
                                                                任务结束日期:&nbsp;&nbsp;{6}</td>
                                                        </tr>
                                                    </table>",
                          DateTime.Now.ToString("yyyy年MM月dd日"), strtooltip, m["SchemeName"].ToString(), m["PrjName"].ToString(),
                        m["AssName"].ToString(),
                        DateTime.Parse(m["PreStatDate"].ToString()).ToString("yyyy年MM月dd日"),
                         DateTime.Parse(m["PreEndDate"].ToString()).ToString("yyyy年MM月dd日"));

                                  if (m["doreemail"] != null) tolist.Add(m["doreemail"].ToString());
                                  if (m["SmPrincipalemail"] != null) cclist.Add(m["SmPrincipalemail"].ToString());
                                  if (m["SmFollowemail"] != null) cclist.Add(m["SmFollowemail"].ToString());
                                  if (m["dutyreemail"] != null) cclist.Add(m["dutyreemail"].ToString());
                                  if (m["modelereemail"] != null) cclist.Add(m["modelereemail"].ToString());
                                  string ccstring = "";
                                  foreach (var t in cclist.Distinct().Except(tolist))
                                  {
                                      ccstring += t.ToString() + ";";

                                  }


                                  if (ccstr.Trim().Length >0)
                                  {
                                      ccstring = ccstr + ";" + ccstring;
                                  }
                                  ccstring = ccstring.Substring(0, ccstring.Length - 1);
                                //  LogHelper.writerlog(tolist[0], 3002);
                                //  LogHelper.writerlog(ccstring , 3002);


                                  newmail = new Asai.Mail.SendMail(tolist[0].ToString (),
                                                       ccstring.ToString (),
                                                       "itd-erpinfo@luenfungwatch.com.hk",
                                                       "温馨提示:" + m["AssName"].ToString() + strtooltip + "，请注意项目进度！",
                                                       "<style>td {border:solid 1px #cdcdcd};</style>" + strbody + "<br/><br/><br/><p>***此信息由系统自动发送，请不要回复***</p>",
                                                        "mail.luenfungwatch.net",
                                                        "itd-erpinfo@luenfungwatch.com.hk",
                                                        "Itd-erpinfo#MgDG",
                                                         "");
                                  newmail.Send();


                              });

                          }


                          LogHelper.writerlog(DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "日已成功发送邮件提醒" + dt.Rows.Count.ToString() + "封!", 3002);
                      }
                  }
                  catch (Exception er)
                  {
                      LogHelper.writerlog(DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "日邮件提醒发送失败!出错原因:\n" + er.StackTrace.ToString() + "\n 出错对象:" +
                                          er.Source.ToString() + " \n 原因描述:" + er.Message, 6662);

                  }

              }, null, (long)betweentime, 87840000);
            return time1;
        }
        #endregion
    }
}
