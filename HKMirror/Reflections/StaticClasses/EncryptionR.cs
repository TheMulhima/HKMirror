namespace HKMirror.Reflection.StaticClasses;

/// <summary>
///     A class that contains all (public and private) fields and methods of Encryption allowing you to easily get/set fields and call methods without dealing with reflection.
/// </summary>
public static class EncryptionR
{
    public static byte[] KeyArray => ReflectionHelper.GetField<byte[]>(typeof(Encryption), "KeyArray");

    public static byte[] Encrypt(byte[] decryptedBytes)
    {
        return Encryption.Encrypt(decryptedBytes);
    }

    public static byte[] Decrypt(byte[] encryptedBytes)
    {
        return Encryption.Decrypt(encryptedBytes);
    }

    public static string Encrypt(string unencryptedString)
    {
        return Encryption.Encrypt(unencryptedString);
    }

    public static string Decrypt(string encryptedString)
    {
        return Encryption.Decrypt(encryptedString);
    }
}