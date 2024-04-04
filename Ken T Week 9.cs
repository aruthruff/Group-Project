/*
 * Write an application that allows the user to input monthly rainfall amounts
 * for one year storing the values in an array. Create a second array that 
 * holds the names of the month. Produce a report showing the month name along 
 * with the rainfall amount and its variance from the mean. Calculate and 
 * display the average rainfall for the year
 */
using System;
using static System.Console;
using static System.Math;

namespace Chapter_7_exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            double displayDeviation;
            char tryAgain = 'n';
            do
            {
                string[] months = new string[12]
                {
                "Jan.",
                "Feb.",
                "March",
                "April",
                "May",
                "June",
                "July",
                "Aug.",
                "Sept.",
                "Oct.",
                "Nov.",
                "Dec."
                }; 

                double[] rainAmmounts = new double[12];
                WriteLine("Please enter 12 numbers for rainfall amounts: ");
                for (int i = 0; i < 12; i++)
                {
                    Write("Please enter month {0} rainfall amount: ", i + 1);
                    double.TryParse(ReadLine(), out double amount);
                    rainAmmounts[i] = amount;

                }
                double amountAverage = 0;
                amountAverage = rainAmmounts.Average();
                WriteLine("Month\t\tRain Amount\tStandard Deviation");
                WriteLine("The Average is: {0}", amountAverage);
                WriteLine("The Standard Deviation is the average minus the current month's amount");
                for (x = 0; x < months.Length - 1; x++)
                {
                    displayDeviation = amountAverage - rainAmmounts[x];
                    WriteLine(months[x] + "\t\t" + rainAmmounts[x] + "\t\t" + "{0:f}", displayDeviation);
                }
                WriteLine("Would you like to try again? ONLY Y or y will try again.");
                char.TryParse(ReadLine().ToUpper(/*I found where to put it*/), out tryAgain);

            } while (tryAgain == 'Y');
        } 
    }
}
