using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazaarLogicLayer.PasswordHandling
{
    public delegate string HashAlgorithm (string pw, string salt);
    public static class PasswordHelper
    {
        public static HashAlgorithm DefaultHash => Encrypt.AsHash512;
    }
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
            char[] availableChars = "ABCDDEFGHIJKLMNOPQRSTUVWXYZabcdexfghijklmnopqrstuvwxyz!@#$%^&*()-=_+[]{}/;:<>~`".ToCharArray();
            int sizeLimit = availableChars.Length;
            StringBuilder sb = new StringBuilder();
            Random rng = new Random();

            //Pick a random character for the array and append it to the result.
            //Do this until the length is met
            for (int i = 0; i < length; i++) 
            {
                int random = rng.Next(0, sizeLimit);
                sb.Append(availableChars[random]);
            }
            return sb.ToString();
        }
    }
}
