using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLab
{
    internal class Trip
    {
        public string destination;
        public int DistanceTraveled;
        public double TotalCostGasoline;
        public double NumberGallonsConsumed;
        public Trip()
        {
            Console.WriteLine("The information about trip is given below.");
        }
        public void DisplayDetail()
        {
            Console.WriteLine($"Destination: {destination}");
            Console.WriteLine($"Distance Traveled: {DistanceTraveled}");
            Console.WriteLine($"Total cost of Gasoline: {TotalCostGasoline}");
            Console.WriteLine($"Number of Gallon consumed: {NumberGallonsConsumed}");
        }
        public void MilesPerGallon()
        {
            double milesPerGallon = DistanceTraveled / NumberGallonsConsumed;
            Console.WriteLine("Total Miles per Gallon is : {0:0.0#}",milesPerGallon);
        }
        public void costPerMile()
        {
            double CostPerMile = TotalCostGasoline / DistanceTraveled;
            Console.WriteLine("The cost per Mile is: {0:0.0#} ", CostPerMile);
        }
    }
}
/*Create a Trip class which contains destination, distance traveled, total cost of gasoline,
and number of gallons consumed data members*/
//Write appropriate constructor(s)
//Add additional methods that calculates miles per gallon and the cost per mile.