using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("./");
            var report = new StreamWriter("report.txt");
            Dictionary<string, Dictionary<string, double>> dictionary = new Dictionary<string, Dictionary<string, double>>();
            Dictionary<string, double> dict = new Dictionary<string, double>();

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                var extention = fileInfo.Extension.ToString();
                var fileName = fileInfo.Name.ToString();
                var fileLenght =fileInfo.Length;

                if (!dictionary.ContainsKey(extention))
                {
                    dict.Add(fileName, fileLenght);
                    dictionary.Add(extention, dict);
                }
                else
                {
                    dictionary[extention].Add(fileName, fileLenght);
                }

            }

            foreach (var file in dictionary.OrderBy(x=>x.Value.Count).ThenBy(n=>n.Key))
            {
                var extent = $"{file.Key}";

                Console.WriteLine($"{extent}");
                report.Write(extent);

                foreach (var kv in file.Value.OrderBy(s=>s.Value))
                {
                    Console.WriteLine($"--{kv.Key} - {kv.Value}");
                    report.Write($"--{kv.Key} - {kv.Value}");
                }
            }
        }
    }
}
