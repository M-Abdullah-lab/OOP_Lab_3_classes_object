using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            MealCard student1 = new MealCard("Ali",200);
            student1.DisplayBalance();
            student1.PurchaseFood(30);
            student1.PurchaseFood(80);
            student1.AddPoints(50);
            student1.PurchaseFood(200);
            student1.DisplayBalance();
        }
    }
}
