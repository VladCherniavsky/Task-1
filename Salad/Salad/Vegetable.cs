using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
     abstract class Vegetable
     {
         public String Name { get; set; }
         public Double KcalPer100g { get; set; }
         public Double Weight { get; set; }

         public Vegetable(){}

         public Vegetable(String name, Double calories, Double weight)
        {
           Name = name;
           KcalPer100g = calories;
           Weight = weight;
        }


        public double GetTotalCalories()
        {
            return KcalPer100g*Weight/100;
        }
     }
}
