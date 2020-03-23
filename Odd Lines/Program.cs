using System;
using System.IO;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using var text = new StreamReader("TextFile1.txt");
            int count = 1;
            while (true)
            {
                var line = text.ReadLine();
                if (line==null)
                {
                    break;
                }
                if (count % 2 == 0)
                {
                    Console.WriteLine(line);
                }
                count++;
            }
        }
    }
}
