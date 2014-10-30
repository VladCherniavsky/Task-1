using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Concordance
{
    public class Concordance
    {
        /// <summary>
        /// Here are:
        /// Method "AddWordsToDictionary" which  adds splitted words to a dictionary
        /// Method "ShowResult" which  sorts  words by alphabet and displays word, frequency of each  word in text
        /// and number of pages where this word is
        /// </summary>
        public Dictionary<string, WordInfo> concordanceDictionary = new Dictionary<string, WordInfo>();

        public void AddWordsToDictionary(string[] lines)
        {
            int i = 0;

            foreach (var line in lines)
            {
                foreach (string word in SplitWords(line.ToLower()))
                {
                    if (!concordanceDictionary.ContainsKey(word))
                    {
                        concordanceDictionary.Add(word, new WordInfo(word, i/10 + 1));//Supposing in one page are 10 strings
                        if (concordanceDictionary.ContainsKey(""))
                        {
                            concordanceDictionary.Remove("");
                        }
                    }
                    else
                    {
                        concordanceDictionary[word].WordCount++;
                        if (!concordanceDictionary[word].LineNumbers.Contains(i/10+1))
                        {
                           
                            concordanceDictionary[word].LineNumbers.Add(i/10+1);
                        }
                    }
                } i++;
            } 
            
        }

        public void ShowResult()
        {
           
            List<WordInfo> sortedWordInfos = concordanceDictionary.Values.OrderBy(a => a.Word).ToList();

            string temp2 = "";
            foreach (var pair in sortedWordInfos) 
            {
                Console.WriteLine("\n");
               // if (pair.Word != "")
                
                    string temp = pair.Word.Substring(0, 1).ToUpper();
                    if (temp != temp2)
                        Console.WriteLine("[{0}]", pair.Word.Substring(0, 1).ToUpper());
                    temp2 = pair.Word.Substring(0, 1).ToUpper();
                
                Console.Write(pair.Word + " " + pair.WordCount + ":.......");
                foreach (int lineNumber in pair.LineNumbers)
                {
                    Console.Write("{0},", lineNumber);
                }
            }
        }


    public static string[] SplitWords(string s)
        {
            return Regex.Split(s, @"\W+");
        }
    }
}
