using System;
using System.IO;
using System.Linq;

namespace Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var stream = new StreamReader("text.txt");
            var output = new StreamWriter("output.txt");
            var count = 0;
            while (!stream.EndOfStream)
            {
                var line = stream.ReadLine();
                if (line==null)
                {
                    break;
                }
                if (count%2==0)
                {
                    line=line.Replace('-', '@');
                    line = line.Replace('.', '@');
                    line = line.Replace(',', '@');
                    line = line.Replace('!', '@');
                    line = line.Replace('?', '@');

                    line = string.Join(" ",line
                            .Split(" ")
                         .Reverse()); ;
                    output.Write(line);
                    Console.WriteLine(line);
                }
                count++;
            }
           
        }
    }
}
