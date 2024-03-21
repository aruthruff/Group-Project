using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Group
{
    class Park
    {
        private string parkName;                   //Data Members
        private string parkLocation;
        private string parkType;
        private string parkFacilities;
        private double parkFee;
        private int employeeAmount;
        private int annualvisitorAmount;
        private double annualBudget;

        public string GetParkType()              //Instance Method 1 (Textbook Reference)
        {
            WriteLine("Enter Park Name: ");
            parkName = ReadLine();

            WriteLine("\nEnter Park Location: ");
            parkLocation = ReadLine();

            WriteLine("\nEnter Type of Park: ");
            parkType = ReadLine();

            return $"Park Name: {parkName}\nLocation: {parkLocation}\nPark Type: {parkType}";
        }

        public string GetParkInfo()             //Instance Method 2 (Textbook Reference)
        {
            WriteLine("\nEnter Park Name: ");
            parkName = ReadLine();

            WriteLine("\nEnter Park Location: ");
            parkLocation = ReadLine();

            WriteLine("\nEnter Park Facilities: ");
            parkFacilities = ReadLine();

            return $"Park Name: {parkName}\nLocation: {parkLocation}\nFacility Type: {parkFacilities}";
        }

        public double ComputeCostPerVisitor()           //Instance Method 3 (Textbook Reference)
        {
            WriteLine("\nEnter this years budget: ");
            annualBudget = Convert.ToDouble(ReadLine());

            WriteLine("\nEnter total mount of Annual Visitors: ");
            annualvisitorAmount = Convert.ToInt32(ReadLine());

            return annualBudget / annualvisitorAmount;
        }

        public double ComputeRevenueFromFees()            //Instance Method 4 (Textbook Reference)
        {
            WriteLine("\nEnter Park Fee per visitor: ");
            parkFee = Convert.ToDouble(ReadLine());

            WriteLine("\nEnter total mount of Annual Visitors: ");
            annualvisitorAmount = Convert.ToInt32(ReadLine());

            return annualvisitorAmount * parkFee;
        }

        public override string ToString()                //ToString method that returns all data members
        {
            return "\nName of Park: " + parkName + "\nPark Location: " + parkLocation + "\nType of Park: " + parkType + "\nNumber of Facilities Available: " + parkFacilities
                + "\nEntrance Fee: " + parkFee + "\nNumber of Employees: " + employeeAmount + "\nAnnual Number of Visitors: " + annualvisitorAmount + "\nAnnual Cost Per Visitor: " 
                + annualBudget / annualvisitorAmount + "\nAnnual Revenue: " + parkFee * annualvisitorAmount;
        }
    }
}


        
            
            
            
            
            
        
        

