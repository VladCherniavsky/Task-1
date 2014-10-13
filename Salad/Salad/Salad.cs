using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Salad
{
     class Salad
    {


         public void CreatingSalad()
         {
             List<Vegetable> vegetable = new List<Vegetable>
             {
                 new Carrot(46),
                 new Cucumber(456),
                 new Potatoes(156)
             };



             Console.WriteLine("The salad contains following ingredients:");
             foreach (Vegetable b in vegetable)
                 Console.WriteLine(b.Name);
             Console.WriteLine("\nHere are sorted ingredients by calories");

             vegetable.Sort();
             foreach (Vegetable a in vegetable)
             Console.WriteLine("{1}  contains {0}  Kcal", a.GetCaloriesForOneVegetable(vegetable), a.Name);
             Console.WriteLine("\n");

             Console.WriteLine("Total calories for this salad is {0} Kcal", TotalCalories(vegetable));
            
             foreach (Vegetable t in BetweenCalories(vegetable, 1895, 10000000))
                 Console.WriteLine("I find {0}", t.Name);
         }

         public  List<Vegetable> BetweenCalories(List<Vegetable> vegetable, int min, int max)
         {
             return vegetable.Where(x => x.KcalPer100g > min && x.KcalPer100g < max).ToList();
         }


         public static double TotalCalories(List<Vegetable> veget)
         {
             double sum = 0;
             foreach (Vegetable a in veget)
             {
                 sum += a.GetTotalCaloriesForSalad();
                 
             }
             return sum;
         }
   


        




         

    }
    }

