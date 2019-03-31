using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace clsRSAEncryption
{
    public  class RSAEncryption
    {
        /// <summary>
        /// 公鑰
        /// </summary>
        private const string XmlPublic = @"<RSAKeyValue>" +
            "<Modulus>na+2jSDYxF6qQsoG/OlAVGYkWuxn1BcI6klg5SigRPS9quiOLcimNROYPDUEynZcM/JG+rs/eMi/ZgIOpJLNhnudKtWVNeZUtlgiS+V5OPUtRiGxdLpkDSa9Vd6uhJ47aRSHs/4qkZ2UI1T8iykIDwDjfucCpKlxyh9NKcfzis0=</Modulus>" +
            "<Exponent>AQAB</Exponent>" +
            "</RSAKeyValue>";
        /// <summary>
        /// 私鑰
        /// </summary>
        private const string XmlPrivate = @"<RSAKeyValue>" +
            "<Modulus>na+2jSDYxF6qQsoG/OlAVGYkWuxn1BcI6klg5SigRPS9quiOLcimNROYPDUEynZcM/JG+rs/eMi/ZgIOpJLNhnudKtWVNeZUtlgiS+V5OPUtRiGxdLpkDSa9Vd6uhJ47aRSHs/4qkZ2UI1T8iykIDwDjfucCpKlxyh9NKcfzis0=</Modulus>" +
            "<Exponent>AQAB</Exponent>" +
            "<P>0lPlW7TZpMJ6/+Jg32NG64COFzBeKcufJZ1ppGKbWHWeyGSD2shJj9Nw4TzekmDKb2hRdyq+4l6pt3oWPFK79Q==</P>" +
            "<Q>v+19EsB2OJwH5btBrtgzX9wpNzZyd2rXfdS0IO3h/7YreEn7Fxpz57M+kPh/lCAZGifeRKMCqWWXPvIdZplkeQ==</Q>" +
            "<DP>TeskwieqpZ4i4R8lkjx+LorOmQqjJ8q2p8G8PFkHger5KvYJ3whqMC092UOqlQHknQdBfutIEibNqxpAmJJx7Q==</DP>" +
            "<DQ>dKWLKZVthJRYPGilz/U4rB8rsZHW2ftGgwR+gbDydS6rls0n3O/H199ZvFQ7fbRQbVQjw4VrPbcvyCLweYXqyQ==</DQ>" +
            "<InverseQ>nwCgAZfr+uRbIhMgfKjQXH7Wh0PYIYEuDQC/rkrJsq1CUdDd7vTIQW990uKD26G+xpnl4NMyv+idfWLBRRDsog==</InverseQ>" +
            "<D>ESNu8OnYBYfQc4/nsIddgY7UdrlpE4kpY+VzzZRbzwLWtoOuKFW9ktk9W5XbnnG81byIcGn3nRYcj2a71rFJ+x8t5ZsnwWXJ9I+G0az0vgtQ6qUWYL2H0esVOtSu/pVjzzxxSC28hNdZ8PV99mtm65d9i4ZDqkeoe9bglIAzzSE=</D>" +
            "</RSAKeyValue>";

        /// <summary>
        /// 字串加密
        /// </summary>
        /// <param name="Value">加密內容</param>
        /// <returns></returns>

        public string Encryption(string Value)
        {
            using (RSACryptoServiceProvider myrsa = new RSACryptoServiceProvider())
                try
                {
                    myrsa.FromXmlString(XmlPublic);
                    byte[] mybyte = Encoding.Unicode.GetBytes(Value);
                    byte[] myency = myrsa.Encrypt(mybyte, true);
                    return Convert.ToBase64String(myency);
                }
                catch (Exception err)
                {
                    return err.Message;
                }
        }

        /// <summary>
        /// 加密字串解密
        /// </summary>
        /// <param name="Value">解密字串</param>
        /// <returns></returns>
        public string Decryption(string Value)
        {
            using (RSACryptoServiceProvider myrsa = new RSACryptoServiceProvider())
                try
                {
                    myrsa.FromXmlString(XmlPrivate);
                    byte[] mdec = Convert.FromBase64String(Value);
                    byte[] mybyte = myrsa.Decrypt(mdec, true);
                    return Encoding.Unicode.GetString(mybyte);
                }
                catch (Exception err)
                {
                    return err.Message;
                }
        }
    }
}
