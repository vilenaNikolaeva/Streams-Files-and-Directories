using System;
using System.IO;
namespace Folder_Size
{
    class Program
    {
        public static object GetDIrectory { get; private set; }

        static void Main(string[] args)
        {
            var files =Directory.GetFiles(".");
            var totalLenght = 0m;
            foreach (var file in files)
            {
                var info = new FileInfo(file);
                totalLenght += info.Length;
            }
            var result = $"{totalLenght / 1024 / 1024:F4} MB";
            Console.WriteLine(result);

        }
    }
}
