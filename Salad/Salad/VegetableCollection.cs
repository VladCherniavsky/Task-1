using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    internal class VegetableCollection
    {
        /*public ArrayList arVegetable = new ArrayList();

        public void AddVegetable(Vegetable v)
        {
            arVegetable.Add(v);
        }
        
      IEnumerator IEnumerable.GetEnumerator()
        {
            return arVegetable.GetEnumerator();
        }

        

        private static void UseVegetableCollection()
        {
            VegetableCollection myVegetableCollection = new VegetableCollection();
            myVegetableCollection.AddVegetable(new Carrot("Carrot", 175, 250));
            myVegetableCollection.AddVegetable(new Beet("Beet", 452, 451));
        }*/

        public void CreatingSalad()
        {
            List<Vegetable> vegetable = new List<Vegetable>
            {
                new Carrot("Carrot", 154, 456),
                new Cucumber("Cucumber", 1896, 456)
            };

           Console.WriteLine(vegetable.Count);
        }
    }
}
