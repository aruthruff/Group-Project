/* 
 * Programmer: Anthony Ruthruff
 *             Richard Carson
 *             Kenneth Thompson
 *             Nathaniel Gebers
 *             Nathan Wenson
 * Date: 03/26/2024
 * Class: CITP 180
 * Purpose:  
 * Assignment: Chapter 7 - Programming Excercise 3
 */

using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Week8_Group
{
    internal class Program
    {
        
       
        
        static void Main(string[] args)
        {
            string caption = "System.Array Methods Illustrated";
            double [] firstArray = new double[2] {10.5, 27};
            double [] secondArray = new double[3] {99.7, 10.9, 7};
            double [] thirdArray = new double[firstArray.Length + secondArray.Length] ;
            /*double a = firstArray[0];
            double b = firstArray[1];
            double c = secondArray[0];
            double d = secondArray[1];
            double e = secondArray[2];
            double total = a * b * c * d * e;*/

            for (int i = 0; i < firstArray.Length; i++)
            {
               
                WriteLine (firstArray[i] * secondArray[i] + " ");
            }

            //WriteLine(Convert.ToString(total));
            string outputMsg = "";
            outputMsg += "ThirdArray: ";
           
            foreach (double x in firstArray)
            {
                outputMsg += x + ", ";
            }
            foreach (double y in secondArray)
            {
                outputMsg += y + ", ";
            }
            /*foreach (double z in thirdArray)
            {
                outputMsg = z + ", ";
            }*/
            MessageBox.Show(outputMsg);
            ReadKey();
            
            firstArray.CopyTo(thirdArray, 0);
            secondArray.CopyTo(thirdArray, 0);
        }
    }
}
           

            



            


           

            



            

