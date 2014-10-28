using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcordanceApplication
{
    public class Word
    {
        public string Words { get; set; }
        public int Occurrences { get; set; }

        public Word(String word, int occurrences )
        {
            Words = word;
            Occurrences = occurrences;
        }
    }
}
