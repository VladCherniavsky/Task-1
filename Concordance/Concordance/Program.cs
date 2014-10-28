using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Concordance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, WordInfo> concordanceDictionary = new Dictionary<string, WordInfo>();
            string myText = File.ReadAllText((@"C:\Users\Влад\Documents\Task-1\ConcordanceApplication\Text.txt").ToLower());
            string[] words = SplitWords(myText);
            foreach (var word in words)
            {
                int i = 1;
                if (!concordanceDictionary.ContainsKey(word))
                {
                    concordanceDictionary.Add(word, new WordInfo(word, i));
                }
                else
                {
                    concordanceDictionary[word].WordCount++;
                    concordanceDictionary[word].LineNumbers.Add(i);
                }
                i++;
            }
            
           List<WordInfo> sortedWordInfos = concordanceDictionary.Values.OrderByDescending(a => a.Word).ToList();

            foreach (var pair in sortedWordInfos)
            {
                Console.WriteLine("{0}.......... {1} .....{2}",pair.Word, pair.WordCount, pair.LineNumbers);
            }
        }

        static string [] SplitWords(string s)
            {
                return Regex.Split(s, @"\W+");
            }
    }
    
}
