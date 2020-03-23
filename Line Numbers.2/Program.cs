using System;
using System.Collections.Generic;
using System.IO;

namespace Line_Numbers._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");
            var count = 1;
            for (int i = 0; i < lines.Length; i++)
            {
                var currentLine = lines[count];
                var letters= CountOfLetter(currentLine);
                var punctuations =CountOfPunctuation(currentLine);
                count++;
                lines[i] = $"Line{i}: {currentLine}({letters})({punctuations})";
            }
             File.WriteAllLines("../../../output.txt", lines);
        }

        static int CountOfPunctuation(string line)
        {
            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsPunctuation(line[i]))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountOfLetter(string line)
        {
            var count=0;
            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsLetterOrDigit(line[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
