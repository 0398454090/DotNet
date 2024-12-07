using System.Security.Policy;
using System.Text;
using System;
using System.Security.Cryptography;

namespace BookLibrary.Extension
{
    public static class HashMD5
    {
        public static string ToMD5(this string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            StringBuilder sbHash = new StringBuilder();
            foreach (byte b in bHash)
            {
                // Sử dụng String.Format để chuyển đổi byte thành chuỗi hexa
                sbHash.Append(String.Format("{0:x2}", b));
            }

            return sbHash.ToString();
        }

    }
}