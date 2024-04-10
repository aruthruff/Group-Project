/* 
* Programmer: Anthony Ruthruff
*             Richard Carson
*             Kenneth Thompson
*             Nathaniel Gebers
*             Nathan Wenson
* Date: 04/10/2024
* Class: CITP 180
* Purpose:   Program that creates a customer code to be place on a mailing label for a magazine.
*            Out will display Lastname, Birthyear, Name Length, Subscription Month, last two digits of zip code, in that order.
*            For example: Ruthruff8715Dec42
*                     
* Assignment: Chapter 8 - Programming Excercise 4
*/

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using System.Diagnostics.Eventing.Reader;

namespace Week_10Group
{

    // Class 2/Implementation Class
    internal class Program
    {
        public static void MainMenu(out string fullName, out string birthDate, out int subMonth, out int zipCode)
        {
            WriteLine("Welcome to the Magazine Subscription Label Generator!");

            // Input full name
            Write("\nEnter your full name (first name first): ");
            fullName = ReadLine();

            // Input birthdate
            Write("Enter your birthdate (mm/dd/yyyy): ");
            birthDate = ReadLine();

            // Input month of subscription purchase
            Write("Enter the month number you purchased your subscription: ");
            subMonth = int.Parse(ReadLine());

            // Input zip code
            Write("Enter your zip code: ");
            zipCode = int.Parse(ReadLine());
            Clear();
        }

        // Generate mailing label
        static void Main(string[] args)
        {

            string fullName;
            string birthDate;
            string userInput;
            string runAgain;
            int zipCode;
            int subMonth;

            do
            {

                MainMenu(out fullName, out birthDate, out subMonth, out zipCode);
                CustomerCode customerCode = new CustomerCode(fullName, birthDate, subMonth);

                int nameLength = fullName.Replace(" ", "").Length;
                WriteLine("Your mail label is: {0}{1}{2}{3}{4}", customerCode.GetLastName, customerCode.GetBirthYear % 100, nameLength, customerCode.GetSubMonth, zipCode % 100);

                WriteLine("Run again? Y/N");
                userInput = ReadLine();
                runAgain = userInput;
            }
            while ((runAgain == "Y") || (runAgain == "y"));
            
            ReadKey();
        }
    }
}
                
            
            
           
            


            








            

            
            





        



