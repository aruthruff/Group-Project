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
            WriteLine("Vendor charges $5 per case (will be automatically deducted)");
            WriteLine("There is a 10% Student Government Association FEE (will be automatically deducted)\n");

        }
        static void SalesProject()
        {
            double sgaFee = .1;                      //10% Student Government Association Fee
            double vendorFee = 2.4;                  //$5 per case vendor fee

            WriteLine("Enter quantity of cases sold: (12 bars in a case) ");
            double caseQuantity = Convert.ToDouble(ReadLine()); //Customer Input for quantity of granola bars sold
            caseQuantity = caseQuantity * 12;
            WriteLine();

            WriteLine("Enter cost per bar: (Currently selling for $1 per bar)");
            double barPrice = Convert.ToDouble(ReadLine());    //Customer Input for cost of granola bars
            WriteLine();

            WriteLine("Your total earnings before expenses: \n{0:c}\n ", + barPrice * caseQuantity);     //Output for proceeds BEFORE SGA fee
            double grossAmount = barPrice * caseQuantity;                                                //Calculate factor for barPrice and caseQuantity
            
            WriteLine("Amount you paid to vendor: \n{0:c}\n ", + grossAmount / vendorFee);
            double caseExpense = grossAmount / vendorFee;
            WriteLine("Total proceeds after vendor expenses: \n{0:c}\n ", + grossAmount - caseExpense);

            

            WriteLine("10% SGA fee is: \n{0:c}\n ", +sgaFee * grossAmount);                                 // 10% SGA fee dollar amount 
            double netAmount = sgaFee * grossAmount;                                                   //Calculate factor for sgaFee and grossAmount
            double grandTotal = grossAmount - netAmount;                                                //Calculate difference for grossAmount and netAmount
                           
            WriteLine("Your grand total profits are: \n{0:c} ", grandTotal - caseExpense);

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
