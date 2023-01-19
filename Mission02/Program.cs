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
            //creats array
            int[] rollTotals = new int[11];
            //imports random
            Random rnd = new Random();

            // introduces user to program and asks for the amount of dice to throw
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate?");
            int rolls = Convert.ToInt32(Console.ReadLine());

            // simulates rolling the dice
            for (int i = 0; i < rolls; i++)
            {
                //randomly rolls 2 dice
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                //adds dice together
                int roll = dice1 + dice2;
                //increments the roll in the array (shifted down 2) (e.g a roll of 2 would be increment the total in position 0)
                rollTotals[roll - 2]++;
            }

            // Results. Explains how to read the histogram
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \" * \" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = 1000.");

            // loops through the array creating histogram row for each roll value
            for (int i = 0; i < 11; i++)
            {
                //finds the percentage of rolls that had each total
                int percentage = (int)((rollTotals[i] / (float)rolls) * 100);
                string histogram = "";
                // converts percentage into *s
                for (int j = 0; j < percentage; j++)
                {
                    histogram = histogram + '*';
                }
                //writes histogram line. accounts for shift when storing to array
                Console.WriteLine((i + 2) + ": " + histogram);
            }

            //end message
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
