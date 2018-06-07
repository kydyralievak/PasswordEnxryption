using System;
using System.Collections.Generic;
using PasswordEncryption.EncryptionMethods;

namespace PasswordEncryption
{
    class Program
    {
        static void Main()
        {
            var users = new List<User>(5)
            {
                new User("Jackson Michael", "abcd", new NextLetterEncryption()),
                new User("John Legend", "dsfgds", new NextLetterEncryption()),
                new User("Justim Timberlake", "adsdf", new NextLetterEncryption()),
                new User("Taylor Swift", "rtght", new NextLetterEncryption()),
                new User("Bruno Mars", "dfdsfg", new ShaEncryption())
            };

            foreach (var user in users)
            {
                Console.WriteLine($"Fullname: {user.FullName}\n" +
                                  $"Encrypted password: {user.EncodeString()}\n");
            }
        }
    }
}