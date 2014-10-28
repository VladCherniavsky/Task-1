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
            string[] lines = File.ReadAllLines(@"C:\Users\Влад\Documents\Task-1\ConcordanceApplication\Text.txt");
            StringBuilder sb = new StringBuilder();
            string[] eachLineAsItemOfArray = new string[lines.Length/10];

            foreach (string line in lines)
            {
                int i = 0;
                string linesForOnePage = null;
                while (i  != 9)
                {
                    linesForOnePage += line;
                }
            }

        }
    }
}



//        Dictionary<string, int> concordanceDictionary = new Dictionary<string, int>();
            //        string[] lines = File.ReadAllLines(@"C:\Users\Влад\Documents\Task-1\ConcordanceApplication\Text.txt");

            //        string myText =
            //            File.ReadAllText(path: @"C:\Users\Влад\Documents\Task-1\ConcordanceApplication\Text.txt").ToLower();

            //        string[] words = SplitWords(myText);

            //        foreach (var  word in words)
            //        {
            //            int i = 1;
            //            if (!concordanceDictionary.ContainsKey(word))
            //            {
            //                concordanceDictionary.Add(word, i);

            //            }
            //            else
            //            {
            //                concordanceDictionary[word]++;
            //            }

            //        }
            //        var list = concordanceDictionary.Keys.ToList();
            //        list.Sort();



            //        foreach (var key in list)
            //        {
            //            List<int> nummerOfLine = new List<int>();
            //            foreach (var line in lines)
            //            {
            //                if (line.Contains(key))
            //                {

            //                    nummerOfLine.Add(line.IndexOf(line));
            //                }


            //                Console.WriteLine("{0}.........: {1}....{2}", key, concordanceDictionary[key], nummerOfLine);
            //            }


            //        }
            //    }



            //    static string[] SplitWords(string s)
            //        {
            //            return Regex.Split(s, @"\W+");
            //        }




            //}


       //}


