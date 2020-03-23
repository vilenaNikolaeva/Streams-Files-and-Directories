using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("text.txt");
            using var writer = new StreamWriter("Output.txt",append:true);
            var count = 1;

            while (true)
            {
                var line = reader.ReadLine();
                if (line==null)
                {
                    break;
                }
                var currentLine = $"{count}. {line}";
                writer.WriteLine(currentLine);
                count++;
            }
        }
    }
}
