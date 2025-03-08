using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Q3
{
    class MealCard
    {
        private string studentName;
        private int balance;
        public MealCard(string name, int initialBalance = 100)
        {
            studentName = name;
            balance = initialBalance;
        }
        public void AddPoints(int points)
        {
            balance += points;
            Console.WriteLine($"{points} points added. New balance: {balance}.");
            
        }

        public void PurchaseFood(int points)
        {
            if (points > 0 && balance >= points)
            {
                balance -= points;
                Console.WriteLine($"Purchase successful! {points} points deducted. Remaining balance: {balance}.");
            }
            else if (points <= 0)
            {
                Console.WriteLine("Invalid purchase amount. Points should be positive.");
            }
            else
            {
                Console.WriteLine("Insufficient balance. Purchase denied.");
            }
        }
        public void DisplayBalance()
        {
            Console.WriteLine($"{studentName}'s meal card balance: {balance} points.");
        }

    }
}
