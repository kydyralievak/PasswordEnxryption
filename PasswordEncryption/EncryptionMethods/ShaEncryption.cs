using System.Security.Cryptography;
using System.Text;
using PasswordEncryption.Interfaces;

namespace PasswordEncryption.EncryptionMethods
{
    class ShaEncryption : IEncryption
    {
        public string EncodeString(string str)
        {
            using (var sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(str));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
