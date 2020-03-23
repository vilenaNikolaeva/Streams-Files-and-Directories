using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllLines("../../../text.txt");
            var words = File.ReadAllLines("../../../words.txt");
            Dictionary<string, int> dict = new Dictionary<string, int>();
            var count =0;

            while (words.Length != count)
            {
                var currentWord = words[count];
                dict.Add(currentWord, 0);
                count++;
            }

            for (int i = 0; i < text.Length; i++)
            {
                var curretnLine = text[i].Split(' ',',','.','!','?','-');

                for (int k = 0; k < curretnLine.Length; k++)
                {
                    var matchingWord = curretnLine[k].ToLower();
                    if (dict.ContainsKey(matchingWord))
                    {
                        dict[matchingWord]++;
                    }
                }
            }
            foreach (var item in dict.OrderByDescending(x=>x.Key))
            {
                var result = $"{item.Key}-{item.Value}";
                Console.WriteLine(result);
                File.WriteAllText("../../../actualResult.txt", result);
            }
            foreach (var item in dict.OrderByDescending(x => x.Value))
            {
                var result = $"{item.Key}-{item.Value}";
                Console.WriteLine(result);
                File.WriteAllText("../../../expectingResult.txt", result);
            }
        }
    }
}
