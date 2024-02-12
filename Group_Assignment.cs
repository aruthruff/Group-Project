/* 
 * Programmer: Anthony Ruthruff
 *             Richard Carson
 *             Nathan Wenson
 * Date: 02/10/2024
 * Purpose: This program receives input of quantity of granola bars and cost, computes a monetary value of proceeds, and gives 10% to the student government association
 * Class: CITP 180
 * Assignment: Chapter 3 - Programming Excercise 8
 */


using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Thanks for contributing to the computer club!");
            WriteLine("Price per case is $5");
            WriteLine("There is a 10% Student Government Association FEE (will be automatically deducted)\n");

            double sgaFee = .01;

            WriteLine("Enter quantity of cases sold: ");
            double caseQuantity = Convert.ToDouble(ReadLine());
            WriteLine();

            WriteLine("Enter cost per case: ");
            double casePrice = Convert.ToDouble(ReadLine());
            WriteLine();

            WriteLine("Your total proceeds BEFORE 10% SGA fee is: {0:c}\n " , + casePrice *  caseQuantity);
            double caseResult = casePrice * caseQuantity;

            WriteLine("10% GAC fee is {0:c}:\n ", + sgaFee * caseResult);
            double proceedTotal = sgaFee * caseResult;
            double realTotal = caseResult - proceedTotal;
            WriteLine("Your total proceeds AFTER 10% SGA fee is: {0:c} ", + realTotal);

            ReadKey();
        }
    }
}
