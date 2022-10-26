using System;

namespace generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double[] doubleArray = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0 };
            string[] stringArray = { "1", "2", "3", "4", "5", "6", "7" };
            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

        }

        public static void displayElements<thing>(thing[] array)
        {
            foreach (thing element in array)
            {
                Console.Write(element+"; ");
            }
            Console.WriteLine();
        }
        //public static void displayElements(double[] array)
        //{
        //    foreach (int element in array)
        //    {
        //        Console.Write(element + "; ");
        //    }
        //    Console.WriteLine();

        //}
        //public static void displayElements(string[] array)
        //{
        //    foreach (string element in array)
        //    {
        //        Console.Write(element + "; ");
        //    }
        //    Console.WriteLine();
        //}
    }
}
