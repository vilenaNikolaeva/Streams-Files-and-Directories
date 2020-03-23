using System;
using System.Collections.Generic;
using System.IO;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            using var firstInput = new StreamReader("input1.txt");
            using var secondInput = new StreamReader("Input2.txt");
            using var result = new StreamWriter("result.txt");
            List<string> list = new List<string>();

            while (true)
            {
                var firstLineNumber=firstInput.ReadLine();
                var secondLineNumber = secondInput.ReadLine();
                list.Add(firstLineNumber);
                list.Add(secondLineNumber);
                if (firstInput.EndOfStream)
                {
                    break;
                }
            }
            foreach (var num in list)
            {
                result.WriteLine(num);
                Console.WriteLine(num);
            }
        }
    }
}
