using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BCSCH2_Semestralni_Prace.Services
{
    internal static class PasswordServices
    {

        public static (string hash, string salt) HashPassword(string password)
        {
            // Generate a random salt
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] saltBytes = new byte[16];
                rng.GetBytes(saltBytes);
                string salt = Convert.ToBase64String(saltBytes);

                // Hash the password with the salt
                using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000))
                {
                    byte[] hashBytes = pbkdf2.GetBytes(32); // 32 bytes for the hash
                    string hash = Convert.ToBase64String(hashBytes);

                    return (hash, salt);
                }
            }
        }

        public static bool CheckPassword(string password, string hash, string salt)
        {
            return true;
        }
    }
}
