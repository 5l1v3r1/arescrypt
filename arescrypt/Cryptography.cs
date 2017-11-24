using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace arescrypt
{
    class Cryptography
    {
        public static byte[] encKey = default(byte[]);
        public static byte[] encIV = default(byte[]);

        // Thanks to: https://stackoverflow.com/a/1344242/8280922
        private static Random random = new Random();
        // Generate alphanumeric string, given desired length
        public static string genRandomString(int length)
        {
            // 2 sets of same number increases chances of getting a number as a result
            // Uppercase, and lowercase alphabet for increased uniqueness
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        
        // Open, read, and encrypt files
        public static bool EncryptFile_Aes(string fileName, byte[] Key, byte[] IV)
        {
            try
            {                
                // Grab all plaintext from file
                string plainTextContents = File.ReadAllText(fileName);
                // Encrypt plaintext data (previously retrieved from file)
                byte[] encryptedContents = EncryptStringToBytes_Aes(plainTextContents, Key, IV);
                // Write all encrypted data to file in Base64 format
                File.WriteAllText(fileName, Convert.ToBase64String(encryptedContents));

                return true;
            } catch (Exception) { return false; }
        }

        public static bool DecryptFile_Aes(string fileName, byte[] Key, byte[] IV)
        {
            try
            {
                Console.WriteLine("Keysize: " + Key.Length + ", IV length: " + IV.Length);
                Console.WriteLine("encKey: " + Convert.ToBase64String(Key) + "\nencIV: " + Convert.ToBase64String(IV));
                // Grab all plaintext from file
                byte[] encryptedContents = Convert.FromBase64String(File.ReadAllText(fileName));
                Console.WriteLine("Enc Contents Length: " + encryptedContents.Length);
                // Encrypt plaintext data (previously retrieved from file)
                string plainTextContents = DecryptStringFromBytes_Aes(encryptedContents, Key, IV);
                // Write all encrypted data to file in Base64 format
                File.WriteAllText(fileName, plainTextContents);

                return true;
            } catch (Exception exc) { Console.WriteLine(exc.Message);  return false; }
        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            // Create an AesManaged object
            // with the specified key and IV.
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            
            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an AesManaged object
            // with the specified key and IV.
            using (AesManaged aesAlg = new AesManaged())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}
