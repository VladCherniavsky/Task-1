using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class SortVegetableByCalories : IComparer<Vegetable>
    {
        public int Compare(Vegetable firstVegetable, Vegetable secondVegetable)
        {
            if (firstVegetable.KcalPer100g > secondVegetable.KcalPer100g)
                return 1;
            if (firstVegetable.KcalPer100g < secondVegetable.KcalPer100g)
                return -1;
            else
                return 0;
        }
    }
}
