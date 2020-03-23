using System;
using System.IO;

namespace Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream reader = new FileStream("../../../copyMe.png", FileMode.Open);
            using FileStream writer = new FileStream("../../../copied.png", FileMode.Create);
            var lenght = 9355;
            byte[] buffer = new byte[lenght];

            while (reader.CanRead)
            {
               var byteReader= reader.Read(buffer, 0, buffer.Length);
                if (byteReader==0)
                {
                    break;
                }
                writer.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
