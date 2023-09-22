using System.Security.Cryptography;
using System.Text;

namespace Library.Data
{
    public static class Hashing
    {
        public static string ToSHA256(string s)
        {
            using var sha256 = SHA256.Create();
            byte[] date = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));

            var sb = new StringBuilder();
            for(int i = 0; i< date.Length; i++)
            {
                sb.Append(date[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
