using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Salad
{
     abstract class Vegetable: IComparable<Vegetable>
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

         public int CompareTo(Vegetable obj)
         {
             if (this.KcalPer100g > obj.KcalPer100g)
                 return 1;
             if (this.KcalPer100g < obj.KcalPer100g)
                 return -1;
             else
                 return 0;
         }

         


         internal double GetCaloriesForOneVegetable(List<Vegetable> vegetable)
         {
             double totalCalories = 0;
             totalCalories = this.KcalPer100g*this.Weight;
             return totalCalories;
         }

        
     }
}
