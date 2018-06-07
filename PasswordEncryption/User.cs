using PasswordEncryption.Interfaces;

namespace PasswordEncryption
{
    class User
    {
        public readonly string FullName;
        private readonly string _password;
        private readonly IEncryption _encryption;

        public User(string fullName, string password, IEncryption encryption)
        {
            FullName = fullName;
            _password = password;
            _encryption = encryption;
        }


        public string EncodeString()
        {
            return _encryption.EncodeString(_password);
        }
    }
}
