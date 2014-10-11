using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    class RootVegetable : Vegetable 
    {
        public RootVegetable()
        {
        }

        public RootVegetable(String name, Double calories, Double weight)
            : base ( name, calories, weight   )
        {
        }
    }
}
