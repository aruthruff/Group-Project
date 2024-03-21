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
            Park park = new Park();     // Testing Park class

            WriteLine(park.GetParkType());
            WriteLine(park.GetParkInfo());
            WriteLine($"Cost Per Visitor: ${park.ComputeCostPerVisitor():F2}");
            WriteLine($"Revenue from Fees: ${park.ComputeRevenueFromFees():F2}");

            ReadKey();
        }
    }
}

