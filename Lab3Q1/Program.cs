using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trip trip1 = new Trip();
            Console.Write("Enter Your Destination: ");
            trip1.destination = Console.ReadLine();
            Console.Write("Enter Your traveled Distance: ");
            trip1.DistanceTraveled = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Total Cost of Gasoline: ");
            trip1.TotalCostGasoline = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Number Gallons Consumed: ");
            trip1.NumberGallonsConsumed = int.Parse(Console.ReadLine());
            Console.WriteLine();
            trip1.DisplayDetail();
            Console.WriteLine();
            trip1.MilesPerGallon();
            trip1.costPerMile();

        }
    }
}
