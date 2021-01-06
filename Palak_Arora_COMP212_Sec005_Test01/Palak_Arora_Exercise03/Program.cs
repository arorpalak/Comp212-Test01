using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palak_Arora_Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 90, 55, 23, 42, 56, 66, 79, 88, 95, 11 };
            double[] doubleArray = { 11.22, 22.22, 33.33, 44.44, 55.55, 66.66, 77.77, 88.88, 99.99, 11.11 };

            Console.WriteLine("************ Integer Array *************");
            Console.WriteLine("Enter Low index for int array");
            int intLowIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter High index for int array");
            int intHighIndex = int.Parse(Console.ReadLine());
            PrintArray(intArray, intLowIndex, intHighIndex);
            Console.WriteLine("\n*********** Double Array *************");
            Console.WriteLine("Enter Low index for double array");
            int doubleLowIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter High index for double array");
            int doubleHighIndex = int.Parse(Console.ReadLine());
            PrintArray(doubleArray, doubleLowIndex, doubleHighIndex);
            Console.ReadLine();
        }
        private static void PrintArray<T>(T[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < 0 || lowIndex > array.Length || lowIndex > highIndex)
            {
                Console.WriteLine("Invalid value of low index!");
            }
            if (highIndex < 0 || highIndex > array.Length )
            {
                Console.WriteLine("Invalid value of high index!");
            }
            else
            {
                for (int i = lowIndex; i <= highIndex; i++)
                {
                    Console.WriteLine($"array[{i}] = {array[i]}");
                }
            }
        }
    }
}
