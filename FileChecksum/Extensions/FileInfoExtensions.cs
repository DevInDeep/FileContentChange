using System;
using System.IO;
using System.Security.Cryptography;

namespace FileChecksum.Extensions
{
    public static class FileInfoExtensions
    {
        public static string ComputeHash(this FileInfo fileInfo, HashAlgorithm hashAlgorithm)
        {
            using (var fs = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                var hash = hashAlgorithm.ComputeHash(fs);
                hashAlgorithm.Dispose();
                return BitConverter.ToString(hash).Replace("-", string.Empty).ToLowerInvariant();
            }
        }
    }
}
