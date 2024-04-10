using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_Group
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CustomerCode customerCode = new CustomerCode();

            WriteLine(customerCode.GetName());
            WriteLine(customerCode.GetBirthDate());
            WriteLine(customerCode.GetZipCode());
            WriteLine(customerCode.GetSubMonth());
            WriteLine(customerCode.GetMailLabel());

            ReadKey();
        }
    }
}
        
            
           

           

       
        
        
        
        
