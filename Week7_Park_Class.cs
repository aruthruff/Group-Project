using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Group
{
    class Park
    {
        private string parkName;
        private string parkLocation;
        private string parkType;
        private int parkFacilities;
        private double parkFee;
        private int employeeAmount;
        private int annualvisitorAmount;
        private double annualBudget;
        

        public Park(string name, string location, string type)
        {
            parkName = name;
            parkLocation = location;
            parkType = type;
        }

        public Park(string name, string location, int facility) 
        {
            parkName = name;
            parkLocation = location;
            parkFacilities = facility;
        }

        public Park(double budget, int visitors)
        {
            annualBudget = budget;
            annualvisitorAmount = visitors;
        }
        
        public Park(int visitors, double fee)
        {
            annualvisitorAmount = visitors;
            parkFee = fee;
        }
            
        public Park(string name, string location, string type, int facility, double fee, int employees, int visitors, double budget)
        {
            parkName = name;
            parkLocation = location;
            parkType = type;
            parkFacilities = facility;
            parkFee = fee;
            employeeAmount = employees;
            annualvisitorAmount = visitors;
            annualBudget = budget;
        }

        public override string ToString()
        {
            return "\nName of Park: " + parkName + "\nPark Location: " + parkLocation + "\nType of Park: " + parkType + "\nNumber of Facilities Available: " + parkFacilities
                + "\nEntrance Fee: " + parkFee + "\nNumber of Employees: " + employeeAmount + "\nAnnual Number of Visitors: " + annualvisitorAmount + "\nAnnual Cost Per Visitor: " 
                + annualBudget / annualvisitorAmount + "\nAnnual Revenue: " + parkFee * annualvisitorAmount;
        }

    }
}


        
            
            
            
            
            
        
        

