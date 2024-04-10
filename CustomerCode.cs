/* 
* Programmer: Anthony Ruthruff
*             Richard Carson
*             Kenneth Thompson
*             Nathaniel Gebers
*             Nathan Wenson
* Date: 04/10/2024
* Class: CITP 180
* Purpose: Program that creates a customer code to be place on a mailing label for a magazine.
*          Out will display Lastname, Birthyear, Name Length, Subscription Month, last two digits of zip code, in that order.
*          For example: Ruthruff8715Dec42 
*                     
* Assignment: Chapter 8 - Programming Excercise 4
*/

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Week_10Group
{

    //Class 1 Accessor/Mutator Class
    internal class CustomerCode
    {
        private string fullName;
        private string birthDate;
        private string lastName;
        private string subscriptionMonth;
        private int yearOfBirth;
        private int monthAbbreviation;
        

        //Default Constructor
        public CustomerCode() { }

        //Construcor with parameters
        public CustomerCode(string fName, String bDate, int mAbbrev) 
        { 
            fullName = fName;
            birthDate = bDate;
            monthAbbreviation = mAbbrev;
        }
            
        //Method to get last name
        public void ParseName(string x)
        {
            string[] partition = x.Split(' ');
            lastName = partition[1];
        }

        //Method to get birth year
        public void ParseBirthDay(string y)
        {
            string[] partition = y.Split('/');

            yearOfBirth = Convert.ToInt32(partition[2]);
        }

        //Method to get month name
        public void ParseMonth(int z)
        {
            string[] Months = 
                {"Jan", "Feb", "Mar", "Apr", "May",
                 "Jun", "Jul", "Aug", "Sep", "Oct",
                 "Nov", "Dec"};

            Months[0] = Months[0].TrimStart('0');

            subscriptionMonth = Months[z - 1];
        }
        
        //Remaining getters/setters
        public string GetFullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        
        public string GetBirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public int GetMonthAbbreviation
        {
            get { return monthAbbreviation; }
            set { monthAbbreviation = value; }
        }

        public string GetLastName
        {
            get { ParseName(fullName);
                return lastName;
            }
        }
            
        public int GetBirthYear
        {
            get {ParseBirthDay(birthDate); return yearOfBirth; }

        }

        public string GetSubMonth
        {
            get
            {
                ParseMonth(monthAbbreviation); return subscriptionMonth;
            }
        }
    }
}


    





        
            




         


       


