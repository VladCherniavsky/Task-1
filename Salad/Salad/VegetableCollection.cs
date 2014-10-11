using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Salad
{
     class VegetableCollection
    {
      

        public void CreatingSalad()
        {
            List<Vegetable> vegetable = new List<Vegetable>
            {
                new Carrot("Carrot", 154452, 46),
                new Cucumber("Cucumber", 1896, 456)
            };


            Console.WriteLine("The salad contains following ingredients:");
            foreach (Vegetable b in vegetable)
                Console.WriteLine(b.Name);
           
            vegetable.Sort();
           
            foreach (Vegetable a in vegetable)

                Console.WriteLine("This {1}  contains {0}  Kcal", a.GetCaloriesForOneVegetable(vegetable), a.Name);
           
        }

         



    }
    }

