using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConcordanceApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> concordanceDictionary = new Dictionary<string, int>();

            string lines = File.ReadAllText(path: @"C:\Users\Влад\Documents\Task-1\ConcordanceApplication\Text.txt").ToLower();
          
            string[] words = SplitWords(lines);
            
            foreach (var  word in words)
            {
                int i = 1;
                if (!concordanceDictionary.ContainsKey(word))
                {
                    concordanceDictionary.Add(word, i);
                    
                }
                else
                {
                    concordanceDictionary[word]++;
                }
                
            }


            foreach (KeyValuePair<string, int> pair in concordanceDictionary)
            {
                Console.WriteLine("{0}:{1}", pair.Key, pair.Value);
            }

        }

        static string[] SplitWords(string s)
            {
                return Regex.Split(s, @"\W+");
            }

       

/*
                int i = 0;

            foreach (string line in File.ReadAllLines(path: @"C:\Users\Влад\Documents\Task-1\ConcordanceApplication\Text.txt"))
            {
                string[] parts = line.Split(' ');
                foreach (string part in parts)
                {
                    Console.WriteLine("{0}:{1}", i, part);
                }
                i++;
            }*/



        }

        
    }

