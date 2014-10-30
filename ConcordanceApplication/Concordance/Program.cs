using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Concordance
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            String[] text = reader.Read(@"C:\Users\Влад\Documents\Task-1\ConcordanceApplication\Text.txt");

            Concordance  concordance = new Concordance();
            concordance.AddWordsToDictionary(text);
            concordance.ShowResult();


           

        
        }
    }
}
