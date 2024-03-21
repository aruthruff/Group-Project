/* 
 * Programmer: Anthony Ruthruff
 *             Richard Carson
 *             
 * Date: 03/19/2024
 * Class: CITP 180
 * Purpose: 
 * Assignment: Chapter 4 - Programming Excercise 7
 */

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace Week7_Group
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Park park = new Park("Saugatuck State Park", "Holland, MI", "State Park");
            WriteLine(park);

            Park facilities = new Park("Saugatuck State Park", "Holland, MI", 5 );
            WriteLine(facilities);

            Park visitorCost = new Park(100000.5, 10000);
            WriteLine(visitorCost);

            Park revenue = new Park(10000, 20.5);
            WriteLine(revenue.ToString());
            
            ReadKey();
        }
    }
}
