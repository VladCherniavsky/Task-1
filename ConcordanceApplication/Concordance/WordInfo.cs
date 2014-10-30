using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concordance
{
    public class WordInfo
    {
        public WordInfo(string word, int firstLineNumber)
        {
            this.Word = word;
            this.WordCount = 1;
            this.LineNumbers = new List<int>() { firstLineNumber };
        }

        public string Word { get; set; }
        public int WordCount { get; set; }//Contains information about  how much times  each word occurs in text
        public List<int> LineNumbers { get; set; }//contains number of lines  where occurred word  is
    }
}
