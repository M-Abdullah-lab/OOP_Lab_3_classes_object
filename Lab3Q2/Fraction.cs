using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Q2
{
    class Fraction
    {
        public int Dividend;
        public int Divisor;
        public Fraction(int dividend, int divisor)
        {
            Dividend = dividend;
            Divisor = divisor;
        }
        public void display()
        {
            Console.WriteLine($" {Dividend} / {Divisor}");
        }
    }
}
/*Write a class Fraction that has dividend and divisor as data members. The class should
have a parameterized constructor to get and set the data members. The class should
have a display method to print the fraction on the console in the format 10/100*/