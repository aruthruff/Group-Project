/* 
 * Programmer: Anthony Ruthruff
 *             Richard Carson
 *             
 * Date: 02/20/2024
 * Purpose: This program works as a BMI calculator. It cane be utilized as Metric or Imperial.
 * Class: CITP 180
 * Assignment: Chapter 5 - Programming Excercise 3
 */

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assignment_4
{
    public class BMICalculator
    {
        private double weight;
        private double height;

        public BMICalculator(double weight, double height)
        {
            this.weight = weight;
            this.height = height;
        }

        public double MetricCalculateBMI()
        {
            // Assuming weight is Kilograms and height is in Meters
            double powerTwo = 2;

            double heightPowerTwo = Math.Pow(height, powerTwo);

            double bmi2 = weight / heightPowerTwo;

            return bmi2;
        }
        
        public double ImperialCalculateBMI()
        {
            // Assuming weight is in Pounds and height is in Inches
            double powerTwo = 2;
            
            double heightPowerTwo = Math.Pow(height, powerTwo);

            double bmi = 703 * weight / heightPowerTwo;
            
            return bmi;
        }
           
        public string GetWeightMetric(double bmi2)
        {
            if (bmi2 < 18.5)
                return "Underweight";
            else if (bmi2 >= 18.5 && bmi2 <= 24.9)
                return "Normal";
            else if (bmi2 >= 25 && bmi2 <= 29.9)
                return "Overweight";
            else
                return "Obese";
        }
        
        public string GetWeightImperial(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                return "Normal";
            else if (bmi >= 25 && bmi <= 29.9)
                return "Overweight";
            else
                return "Obese";
        }

    }
    public class Program
    {
        public static void UseImperial()
        {
            
            WriteLine("Enter weight in Pounds:");
            double weight = Convert.ToDouble(ReadLine());

            WriteLine("\nEnter height in Inches:");
            double height = Convert.ToDouble(ReadLine());

            BMICalculator calculator = new BMICalculator(weight, height);

            double bmi = calculator.ImperialCalculateBMI();
            string weightStatus = calculator.GetWeightImperial(bmi);

            WriteLine($"\nBMI: {bmi}\n");
            WriteLine($"Weight Status: {weightStatus}");

            ReadKey();
        }
        
        public static void UseMetric()
        {
           
            WriteLine("Enter weight in Kilograms:");
            double weight = Convert.ToDouble(ReadLine());

            WriteLine("\nEnter height in Meters:");
            double height = Convert.ToDouble(ReadLine());

            BMICalculator calculator = new BMICalculator(weight, height);

            double bmi2 = calculator.MetricCalculateBMI();
            string weightStatus = calculator.GetWeightMetric(bmi2);

            WriteLine($"\nBMI: {bmi2}\n");
            WriteLine($"Weight Status: {weightStatus}");

            ReadKey();
        }

        public static void Main()
        {
            WriteLine("This program calulates your BMI (body mass index)");
            WriteLine("You can use Metric or Imperial\n");

            WriteLine("Press (M) for Metric or (I) for Imperial: ");
            String userChoice = Convert.ToString(ReadLine());
            
            if (userChoice == "M")
                UseMetric();
            else if (userChoice == "I")
                UseImperial();

        }

    }
}






       

           
            













            
            
            
            
