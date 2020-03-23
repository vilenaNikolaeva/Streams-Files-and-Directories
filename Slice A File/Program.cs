using System;
using System.IO;
using System.Linq;

namespace Slice_A_File
{
    class Program
    {
        static void Main(string[] args)
        {
             var stream = new FileStream("text.txt",FileMode.OpenOrCreate);
            Console.WriteLine(stream.Length);
            var parts=4;
            
            var lenght =(int)Math.Ceiling(stream.Length /(decimal) parts);
           var buffer = new byte[lenght];

            for (int i = 1; i <=parts; i++)
            {
                var bytesRead = stream.Read(buffer, 0, buffer.Length);
                if (bytesRead<buffer.Length)
                {
                    buffer = buffer.Take(buffer.Length).ToArray();
                }

               using  var currentStream = new FileStream($"Part{i}.txt", FileMode.OpenOrCreate);
                currentStream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}



