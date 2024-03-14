using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Task2
    {
        public static void Run()
        {
            string text = "Здесь заданный текст. Слова, слова, слова. Да вознесутся мои слова к богу и пусть этот код заработает";

            Dictionary<string, int> wordFrequencies = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);

            string[] words = text.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (wordFrequencies.ContainsKey(word))
                {
                    wordFrequencies[word]++;
                }
                else
                {
                    wordFrequencies[word] = 1;
                }
            }

            foreach (var pair in wordFrequencies)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
