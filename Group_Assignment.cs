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

        static void ProjectIntro() {
            
            WriteLine("Thanks for contributing to the computer club!");
            WriteLine("Price per case is $5");
            WriteLine("There is a 10% Student Government Association FEE (will be automatically deducted)\n");

        }
        static void SalesProject()
        {
            double sgaFee = .1;                      //10% Student Government Association Fee
            double fiveFee = 2.4;

            WriteLine("Enter quantity of cases sold: (12 bars in a case) ");
            double caseQuantity = Convert.ToDouble(ReadLine()); //Customer Input for quantity of granola bars sold
            caseQuantity = caseQuantity * 12;
            WriteLine();

            WriteLine("Enter cost per bar: (Currently selling for $1 per bar)");
            double barPrice = Convert.ToDouble(ReadLine());    //Customer Input for cost of granola bars
            WriteLine();

            WriteLine("Your total earnings before expenses: \n{0:c}\n ", +barPrice * caseQuantity);     //Output for proceeds BEFORE SGA fee
            double caseResult = barPrice * caseQuantity;                                                //Calculate factor for barPrice and caseQuantity
            
            WriteLine("Amount you paid to vendor: \n{0:c}\n ", + caseResult / fiveFee);
            double caseExpense = caseResult / fiveFee;
            WriteLine("Total proceeds after case expenses: \n{0:c}\n ", + caseResult - caseExpense);

            

            WriteLine("10% SGA fee is: \n{0:c}\n ", +sgaFee * caseResult);                                 // 10% SGA fee dollar amount 
            double proceedTotal = sgaFee * caseResult;                                                   //Calculate factor for sgaFee and caseResult
            double realTotal = caseResult - proceedTotal;                                                //Calculate difference for caseResult and proceedTotal
                           
            WriteLine("Your grand total profits are: \n{0:c} ", realTotal - caseExpense);

            ReadKey();
        }
            
        static void Main(string[] args)
        {
            
            ProjectIntro();                    //Call ProjectIntro() Method
            
            SalesProject();                    //Call SalesProject() Method

            ReadKey();

        }
    }
}
