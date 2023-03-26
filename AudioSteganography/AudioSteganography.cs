using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AudioSteganography
{
    public static class AudioSteganography
    {
        public static async Task<byte[]> Encrypt(string message, RSAParameters publickey)
        {
            using Aes aes = Aes.Create();
            using RSACryptoServiceProvider rsa = new();
            byte[] encryptedData;
            using MemoryStream output = new();
            using CryptoStream cryptoStream = new(output, aes.CreateEncryptor(), CryptoStreamMode.Write);
            await cryptoStream.WriteAsync(Encoding.Unicode.GetBytes(message));
            await cryptoStream.FlushFinalBlockAsync();
            encryptedData = output.ToArray();

            rsa.ImportParameters(publickey);
            byte[] encryptedKey = rsa.Encrypt(aes.Key, RSAEncryptionPadding.Pkcs1);
            byte[] encryptedIV = rsa.Encrypt(aes.IV, RSAEncryptionPadding.Pkcs1);

            byte[] result = new byte[encryptedKey.Length + encryptedIV.Length + encryptedData.Length];
            Buffer.BlockCopy(encryptedKey, 0, result, 0, encryptedKey.Length);
            Buffer.BlockCopy(encryptedIV, 0, result, encryptedKey.Length, encryptedIV.Length);
            Buffer.BlockCopy(encryptedData, 0, result, encryptedKey.Length + encryptedIV.Length, encryptedData.Length);

            return result;
        }

        public static async Task<string> Decrypt(byte[] encryptedMessage, RSAParameters privateKey)
        {
            using RSACryptoServiceProvider rsa = new();
            rsa.ImportParameters(privateKey);

            int keySize = rsa.KeySize / 8;
            byte[] encryptedKey = new byte[keySize];
            byte[] encryptedIV = new byte[keySize];
            byte[] encryptedData = new byte[encryptedMessage.Length - 2 * keySize];

            Buffer.BlockCopy(encryptedMessage, 0, encryptedKey, 0, keySize);
            Buffer.BlockCopy(encryptedMessage, keySize, encryptedIV, 0, keySize);
            Buffer.BlockCopy(encryptedMessage, 2 * keySize, encryptedData, 0, encryptedData.Length);

            byte[] decryptedKey = rsa.Decrypt(encryptedKey, RSAEncryptionPadding.Pkcs1);
            byte[] decryptedIV = rsa.Decrypt(encryptedIV, RSAEncryptionPadding.Pkcs1);

            using Aes aes = Aes.Create();
            aes.Key = decryptedKey;
            aes.IV = decryptedIV;

            byte[] decryptedData;
            using MemoryStream output = new();
            using CryptoStream cryptoStream = new(output, aes.CreateDecryptor(), CryptoStreamMode.Write);
            await cryptoStream.WriteAsync(encryptedData);
            await cryptoStream.FlushFinalBlockAsync();
            decryptedData = output.ToArray();

            return Encoding.Unicode.GetString(decryptedData);
        }

        public static RSAParameters ReadPublicKeyFromXmlFile(string filePath)
        {
            using RSA rsa = RSA.Create();
            rsa.FromXmlString(File.ReadAllText(filePath));
            return rsa.ExportParameters(false);
        }

        public static RSAParameters ReadPrivateKeyFromXmlFile(string filePath)
        {
            using RSA rsa = RSA.Create();
            rsa.FromXmlString(File.ReadAllText(filePath));
            return rsa.ExportParameters(true);
        }
    }
}
