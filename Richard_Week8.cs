using System;

namespace Week8_Group
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] firstArray = new double[2] { 10.5, 27 };
            double[] secondArray = new double[3] { 99.7, 10.9, 7 };
            double[] thirdArray = new double[firstArray.Length];

            // Multiply corresponding elements of firstArray and secondArray and store in thirdArray
            for (int i = 0; i < firstArray.Length; i++)
            {
                thirdArray[i] = firstArray[i] * secondArray[i];
            }

            // Output arrays to the console
            Console.WriteLine("FirstArray: " + string.Join(", ", firstArray));
            Console.WriteLine("SecondArray: " + string.Join(", ", secondArray));
            Console.WriteLine("ThirdArray (Product): " + string.Join(", ", thirdArray));

            Console.ReadKey();
        }
    }
}
