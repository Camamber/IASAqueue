using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IASAqueue_Server
{
    class AESEncryptor
    {
        byte[] Key;
        byte[] IV;

        public AESEncryptor(string key)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(key));
            List<byte> hash2 = new List<byte>(hash);
            hash2.AddRange(hash);
        }

        public byte[] Encrypt(string plainText)
        {
            byte[] encrypted = new byte[1];
            try
            {
                if (plainText == null || plainText.Length <= 0)
                    throw new ArgumentNullException("plainText");
                if (Key == null || Key.Length <= 0)
                    throw new ArgumentNullException("Key");
                if (IV == null || IV.Length <= 0)
                    throw new ArgumentNullException("IV");

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = this.Key;
                    aesAlg.IV = this.IV;

                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(plainText);
                            }
                            encrypted = msEncrypt.ToArray();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: {0}", e.Message);
            }

            return encrypted;
        }

        public string Decrypt(byte[] cipherText)
        {
            string plaintext = null;

            try
            {
                if (cipherText == null || cipherText.Length <= 0)
                    throw new ArgumentNullException("cipherText");
                if (Key == null || Key.Length <= 0)
                    throw new ArgumentNullException("Key");
                if (IV == null || IV.Length <= 0)
                    throw new ArgumentNullException("IV");

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = this.Key;
                    aesAlg.IV = this.IV;

                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {                          
                                plaintext = srDecrypt.ReadToEnd();
                            }
                        }
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: {0}", e.Message);
            }

            return plaintext;
        }
    }
}
