using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_18Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rollTotals = new int[11];
            Random rnd = new Random();

            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate?");
            int rolls = Convert.ToInt32(Console.ReadLine());

            // simulates rolling the dice
            for (int i = 0; i < rolls; i++)
            {
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                int roll = dice1 + dice2;
                rollTotals[roll - 2]++;
            }


            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \" * \" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = 1000.");

            // print out the results from the array
            for (int i = 0; i < 11; i++)
            {
                int percentage = (int)((rollTotals[i] / (float)rolls) * 100);
                string histogram = "";
                for (int j = 0; j < percentage; j++)
                {
                    histogram = histogram + '*';
                }
                Console.WriteLine((i + 2) + ": " + histogram);
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
