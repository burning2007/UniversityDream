using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace GF.Infrastructure.Crosscutting.Context
{
    public class DataCryptography
    {
        private static byte[] key = { 139, 4, 70, 82, 110, 216, 65, 156, 3, 59, 114, 100, 127, 142, 160, 79, 209, 129, 144,
                                        125, 163, 99, 101, 92, 16, 146, 254, 22, 107, 182, 169, 18 };

        private static byte[] iv = { 65, 235, 42, 44, 73, 97, 14, 55, 2, 171, 81, 189, 70, 113, 185, 149};


        public static string EncryptString(string decryptData)
        {
            if (string.IsNullOrEmpty(decryptData))
                throw new ArgumentNullException("decryptData");

            AesCryptoServiceProvider aesCSP = new AesCryptoServiceProvider();
            byte[] inputBuffer  = Encoding.Default.GetBytes(decryptData);
            ICryptoTransform xfrm = aesCSP.CreateEncryptor(key, iv);
            byte[] outBlock = xfrm.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);

            return Encoding.Default.GetString(outBlock);
        }

        public static string DecryptString(string encryptData)
        {
            if (string.IsNullOrEmpty(encryptData))
                throw new ArgumentNullException("encryptData");

            AesCryptoServiceProvider aesCSP = new AesCryptoServiceProvider();
            ICryptoTransform xfrm = aesCSP.CreateDecryptor(key, iv);
            byte[] inputBuffer = Encoding.Default.GetBytes(encryptData);
            byte[] outBlock = xfrm.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);

            return UnicodeEncoding.Default.GetString(outBlock);
        }

    }
}
