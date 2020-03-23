using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            using var words = new StreamReader("words.txt");
            using var text = new StreamReader("text.txt");
            using var result = new StreamWriter("result.txt");
            Dictionary<string, int> output = new Dictionary<string, int>();
           
            var splitedWords = words.ReadLine().Split(" ");
            for (int i = 0; i < splitedWords.Length; i++)
            {
                var word = splitedWords[i];
                output.Add(word, 0);
            }

            for (int i = 0; i < splitedWords.Length; i++)
            {
                var line = text.ReadLine().Split(' ', ',', '.', '?', '!','-');
                
                for (int k = 0; k < line.Length; k++)
                {
                    var word = line[k].ToLower();
                    if (output.ContainsKey(word))
                    { 
                        output[word]++;
                    }
                }
            }
            
            foreach (var word in output.OrderByDescending(x=>x.Value))
            {
                var wordValue = $"{word.Key} - {word.Value}";
                result.WriteLine(wordValue);
                Console.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}
