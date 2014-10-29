using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, WordInfo> concordanceDictionary = new Dictionary<string, WordInfo>();

            int i = 1;
            foreach (var line in File.ReadLines(@"C:\Users\Влад\Documents\Task-1\ConcordanceApplication\Text.txt"))
            {
                foreach (string word in SplitWords(line.ToLower()))
                {
                    if (!concordanceDictionary.ContainsKey(word))
                    {
                        concordanceDictionary.Add(word, new WordInfo(word, i));
                    }
                    else
                    {
                        concordanceDictionary[word].WordCount++;
                        if (!concordanceDictionary[word].LineNumbers.Contains(i))
                        {
                            concordanceDictionary[word].LineNumbers.Add(i);
                        }
                    }
                }

                i++;
            }
            List<WordInfo> sortedWordInfos = concordanceDictionary.Values.OrderByDescending(a => a.Word).ToList();

            foreach (var pair in sortedWordInfos)
            {
                Console.Write(pair.Word + " " + pair.WordCount + " ");
                Console.WriteLine("\n");
                foreach (int lineNumber in pair.LineNumbers)
                {
                    Console.Write("{0},",lineNumber/10+1);
                    
                }
            }
        }

        private static string [] SplitWords(string s)
        {
            return Regex.Split(s, @"\W+");
        }
    }
}
