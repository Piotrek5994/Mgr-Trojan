using System.Security.Cryptography;

namespace IdoBook_Symulator.Helpers;

public static class SecurityHelper
{
    public static string Encrypt(string plainText, byte[] key)
    {
        using var aes = Aes.Create();
        aes.Key = key;
        aes.GenerateIV();

        using var encryptor = aes.CreateEncryptor();
        using var ms = new MemoryStream();
        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
        using (var sw = new StreamWriter(cs))
        {
            sw.Write(plainText);
        }

        var encrypted = ms.ToArray();
        var result = Convert.ToBase64String(aes.IV.Concat(encrypted).ToArray());
        return result;
    }

    public static string Decrypt(string encryptedText, byte[] key)
    {
        var fullCipher = Convert.FromBase64String(encryptedText);
        var iv = fullCipher.Take(16).ToArray();
        var cipher = fullCipher.Skip(16).ToArray();

        using var aes = Aes.Create();
        aes.Key = key;
        aes.IV = iv;

        using var decryptor = aes.CreateDecryptor();
        using var ms = new MemoryStream(cipher);
        using var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
        using var sr = new StreamReader(cs);

        return sr.ReadToEnd();
    }
}
