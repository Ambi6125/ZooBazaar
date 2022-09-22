using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLayer.PasswordHandling
{
    public delegate string HashAlgorithm (string pw, string salt);
    internal static class Encrypt
    {
        internal static string AsHash512(string password, string salt)
        {
            IEnumerable<char> concat = password.Concat(salt);
            byte[] bytes = Encoding.UTF8.GetBytes(concat.ToArray());
            using (SHA512 hasher = SHA512.Create())
            {
                byte[] hash = hasher.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }

    public static class Generate
    {
        public static string NewString(int length)
        {
            StringBuilder sb = new StringBuilder(String.Empty);
            Random rng = new Random();
            for (int i = 0; i < length; i++)
            {
                sb.Append(Convert.ToChar(rng.Next(0, 25) + 65));
            }
            return sb.ToString();
        }
    }
}
