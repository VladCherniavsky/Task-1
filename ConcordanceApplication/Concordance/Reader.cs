using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concordance
{
    public class Reader
    {
        /// <summary>
        /// Method which reads text  line by line from a file
        /// </summary>
        /// <returns>Array of lines</returns>
       
        public string[] Read ( String path)
        {
            string[] lines = {};
            try
            {
                lines = File.ReadAllLines(path: path);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return lines;
        }

        

       
    }
}
