
using System;
using System.Security.Cryptography;
using System.Text;

namespace Muim.Domain.Utils
{
    public class Codification
    {
        public static string EncodePasswordToBase64(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }
        public static string DencodePasswordToBase64(string password)
        {
            byte[] data = Convert.FromBase64String(password);
            string decodedString = Encoding.UTF8.GetString(data);
            return decodedString;
        }
        
    }
}
