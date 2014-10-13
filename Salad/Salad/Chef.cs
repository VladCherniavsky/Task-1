using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class Chef
    {
        public string Name { get; set; }
        public string NameOfSalad { get; set; }

        public Chef(String name, String nameOfSalad)
        {
            Name = name;
            NameOfSalad = nameOfSalad;
            Console.WriteLine("Hi, my name is {0} and I cooked {1} for you", name, nameOfSalad);
            Salad s = new Salad();
            s.CreatingSalad();

        }

        
    }
}
