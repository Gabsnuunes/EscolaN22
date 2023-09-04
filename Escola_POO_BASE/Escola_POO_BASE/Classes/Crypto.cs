using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Escola_POO_BASE.Classes
{
    public class Crypto
    {
        public static string Sha256(string texto)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256 = new SHA256Managed();
            byte[] hashedDatabytes = sha256.ComputeHash(encoder.GetBytes(texto));
            return ByteArrayToString(hashedDatabytes).ToLower();
        }

        public static string ByteArrayToString(byte[] inputArray)
        {
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < inputArray.Length; i++)
            {
                sb.Append(inputArray[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
