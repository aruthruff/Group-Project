/* 
* Programmer: Richard Carson
*             Anthony Ruthruff
*             Kenneth Thompson
*             Nathaniel Gebers
*             Nathan Wenson
* Date: 04/03/2024
* Class: CITP 180
* Purpose:  User inputs monthly rainfall amounts for each month, after which a 
*           report displays the name of month along with that months variance from mean. 
*           The average rainfall for the year is then produced at end of program.
*                     
* Assignment: Chapter 7 - Programming Excercise 1
*/

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace Week9_Group
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array to store rainfall amounts for each month
            double[] rainfall = new double[12];

            // Array to store month names
            string[] months = { "January:  ", "February: ", "March:    ", "April:    ", "May:      ", "June:     ", "July:     ", "August:   ", "September:", "October:  ", "November: ", "December: " };

            
            // Input monthly rainfall amounts
            for (int i = 0; i < 12; i++)
            {
                Write($"Enter rainfall amount for {months[i]} ");
                
                string userInput = ReadLine();
                if (double.TryParse(userInput, out rainfall[i])){ }
                
                else
                {
                    WriteLine("\nInvalid Data -" + " Enter numerical value");
                    Write($"Enter rainfall amount for {months[i]} ");
                    rainfall[i] = Convert.ToDouble(ReadLine());
                    WriteLine($"\nNUMBER STORED FOR {months[i]} {rainfall[i]}");
                }
            }
                
            // Calculate average rainfall
            double totalRainfall = 0;
            foreach (double amount in rainfall)
            {
                totalRainfall += amount;
            }
            double averageRainfall = totalRainfall / 12;

            // Display report
            WriteLine("\nMonth\t\tRainfall\tVariance from Mean");
            WriteLine("--------------------------------------------------");
            for (int i = 0; i < 12; i++)
            {
                double variance = rainfall[i] - averageRainfall;
                WriteLine($"{months[i]}\t\t{rainfall[i]}\t\t{variance}");
            }

            WriteLine("\nAverage Rainfall for the Year: " + averageRainfall);
            ReadKey();
        }
    }
}
                    


                    
               

                
            
            
               
                
                
                                   
                


                    
                    
                    
                
        




