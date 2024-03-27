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
        //Method with parameters to display results
        static void DisplayResults(double[] firstArray, double[] secondArray, double[] thirdArray)
        {
            string caption = "Array Contents";   //Caption for MessageBox
            string outputMsg = "";               //Custom message for each array
            string outputMsg2 = "";
            string outputMsg3 = "";
            outputMsg += "First Array: ";        //Custom message for each array
            outputMsg2 += "Second Array: ";
            outputMsg3 += "Third Array: ";
            foreach (double x in firstArray)     //Gets array values and combine with output message
            {
                outputMsg += x  + " | ";
            }
            foreach (double y in secondArray)
            {
                outputMsg2 += y + " | ";
            }
            foreach (double z in thirdArray)
            {
                outputMsg3 += z + " ";
            }
            
            MessageBox.Show(outputMsg + outputMsg2 + outputMsg3, caption); //Display results using MessageBox class
            ReadKey();
        }
        
        //Main method 
        static void Main(string[] args)
        {
            double [] firstArray = new double[2] {10.5, 27};             //Compile-time initialization of first two arrays
            double [] secondArray = new double[3] {99.7, 10.9, 7};       //Two original arrays have different number of elements

            double sum = firstArray.Sum();          //Get sum of first array
            double sum2 = secondArray.Sum();        //Get sum of second array
            double sum3 = sum * sum2;               //Get product of first two arrays
            
            double [] thirdArray = new double[1] {sum3};  //Store product of first two arrays in the third array
           
            DisplayResults(firstArray, secondArray, thirdArray); //Call method to display results
        }
    }
}
           

            



            


           

            



            

