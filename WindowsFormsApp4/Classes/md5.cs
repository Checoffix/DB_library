using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsApp4.Classes
{
    public class md5
    {
        public string HashPassword(string password)
        {
            MD5 mD5 = MD5.Create();

            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = mD5.ComputeHash(b);

            StringBuilder sb = new StringBuilder();
            foreach (var h in hash)
                sb.Append(h.ToString("X2"));

            return Convert.ToString(sb);
        }       
    }
}
