using System;

namespace PrintGenericArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generic programming !!");
            Console.WriteLine("Printing array of different data type");
            int[] intArray = { 10, 5, 100, 85, 96, 2, 1 };
            double[] doubleArray = { 1.1, 1.3, 5.6, 5.36, 6.2, 80.5, 1 };
            char[] charArray = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
            new PrintArray<int>(intArray).ToPrintArray();
            new PrintArray<double>(doubleArray).ToPrintArray();
            new PrintArray<char>(charArray).ToPrintArray();
            Console.Read();
        }
    }
}
