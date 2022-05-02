using FileChecksum.Extensions;
using System;
using System.IO;
using System.Security.Cryptography;

namespace FileChecksum
{
    class Program
    {
        static void Main(string[] args)=>
            ConsoleReader
                .ReadUntil(userInput => userInput.ToLower().Equals("q"))
                .Do(_ => Console.WriteLine(new FileInfo(AppGlobals.FilePath).ComputeHash(SHA256.Create())));
    }
}
