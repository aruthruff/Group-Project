/* I had this already by the time the post hit
 * Programmer: Kenneth Thompson
 * Date: 03/27/24
 * Purpose: a short description about the program
 * Class: CITP 180
 * Assignment: Chapter 7 - Programming Excercise 3
 */

/* Create three arrays of type double. 
 * Do a compile-time initialization and place different values in two of the
 *      arrays. 
 * Write a program to store the product of the two arrays in the third array. 
 * Produce a display using the (writing statements) that shows the contents of 
 *      all three arrays using a single line for an element from all three
 *      arrays. 
 * Design your solution so that the two original arrays have a different number
 * of elements. 
 * Use 1 as the multiplier when you produce the third array.
*/

using System;
using static System.Console;

namespace Ken_T_CHapter_7_Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] firstArray = null;
            double[] secondArray = null;
            double[] thirdArray = null;
            string tryAgain = null;
            int y; // iteration counter
            int x;  //base condition
            do
            {
                //first array
                WriteLine("How many in the first array?(Please enter a number)");
                int.TryParse(ReadLine(), out y);
                x = 0;
                do
                {
                    //iteration number should control everything here if done right
                    Write("\nPlease enter number {0}", x);
                    if (double.TryParse(ReadLine(), out firstArray[x]))
                        x++;// if it parses 
                }
                while (x < y-1);


                //second array

                WriteLine("How many in the second array?(Please enter a number)");
                int.TryParse(ReadLine(), out y);
                do
                {
                    //iteration number should control everything here if done right
                    Write("\nPlease enter number {0}", x);
                    double.TryParse(ReadLine(), out secondArray[x]);
                    if (secondArray[x] != firstArray[x])
                        x++; //will only work if not equal to ten 
                }
                while (x < y-1);


                x = 0;
                do
                {
                    thirdArray[x] = firstArray[x] * secondArray[x];
                }
                while (x < 10);

                x = 0;
                do
                {
                    thirdArray[x] = firstArray[x] * secondArray[x];
                    x++;
                }
                while (x < 10);

                //and another loop for displaying values with the same counter and have it format with the 
                // "\t\t" between each "column" or something with labels?
                




                WriteLine("Would you like to try again?");
                tryAgain = ReadLine().ToUpper();
            } while (tryAgain == "Y");
        }
    }
}
