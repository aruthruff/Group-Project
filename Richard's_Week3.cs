using System;
using static System.Console;

namespace Group_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Thanks for contributing to the computer club!");
            WriteLine("Each case is purchased for $5");
            WriteLine("There is a 10% Student Government Association FEE (will be automatically deducted)\n");

            double sgaFeePercentage = 0.1;
            double casePrice = 5; // Fixed price per case

            double caseQuantity = GetCaseQuantity();
            double totalProceedsBeforeFee = CalculateTotalProceeds(casePrice, caseQuantity);

            DisplayTotalProceedsBeforeFee(totalProceedsBeforeFee);

            double sgaFee = CalculateSGAFee(totalProceedsBeforeFee, sgaFeePercentage);
            DisplaySGAFee(sgaFee);

            double totalProceedsAfterFee = CalculateTotalProceedsAfterFee(totalProceedsBeforeFee, sgaFee);
            DisplayTotalProceedsAfterFee(totalProceedsAfterFee);

            ReadKey();
        }

        static double GetCaseQuantity()
        {
            WriteLine("Enter quantity of cases sold: ");
            return Convert.ToDouble(ReadLine());
        }

        static double CalculateTotalProceeds(double casePrice, double caseQuantity)
        {
            return casePrice * caseQuantity;
        }

        static void DisplayTotalProceedsBeforeFee(double totalProceedsBeforeFee)
        {
            WriteLine($"Your total proceeds BEFORE 10% SGA fee is: {totalProceedsBeforeFee:c}\n");
        }

        static double CalculateSGAFee(double totalProceedsBeforeFee, double sgaFeePercentage)
        {
            return sgaFeePercentage * totalProceedsBeforeFee;
        }

        static void DisplaySGAFee(double sgaFee)
        {
            WriteLine($"10% SGA fee is {sgaFee:c}:\n");
        }

        static double CalculateTotalProceedsAfterFee(double totalProceedsBeforeFee, double sgaFee)
        {
            return totalProceedsBeforeFee - sgaFee;
        }

        static void DisplayTotalProceedsAfterFee(double totalProceedsAfterFee)
        {
            WriteLine($"Your total proceeds AFTER 10% SGA fee is: {totalProceedsAfterFee:c}");
        }
    }
}
