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
            string lines = File.ReadAllText(path: @"C:\Users\Влад\Documents\Task-1\ConcordanceApplication\Text.txt");
            Console.WriteLine(lines);

            string[] words = SplitWords(lines);

            int i = 0;
            foreach (var  word in words)
            {
                Console.WriteLine(word);
            }
        }

        static string[] SplitWords(string s)
            {
                return Regex.Split(s, @"\W+");
            }


           /* foreach (string line in
                    File.ReadAllLines(path: @"C:\Users\Влад\Documents\Task-1\ConcordanceApplication\Text.txt"))
            {
                string[] parts = line.SplitWords(line);//Split(new char[] {' ', ',', '.',});
                foreach (string part in parts)
                {
                    Console.WriteLine("{0}", part);
                }

            }
        }

            */
        

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

