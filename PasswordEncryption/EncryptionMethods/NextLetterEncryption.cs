using PasswordEncryption.Interfaces;

namespace PasswordEncryption.EncryptionMethods
{
    class NextLetterEncryption : IEncryption
    {
        public string EncodeString(string str)
        {
            string res = "";
            foreach (char ch in str)
            {
                char s = ch;
                s++;
                res += s;
            }
            return res;
        }
    }
}
