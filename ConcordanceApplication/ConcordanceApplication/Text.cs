using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConcordanceApplication
{
    public class Text
    {
        public static string[] SplitWords(string s)
        {
            return Regex.Split(s, @"\W+");
        }
    }
}
