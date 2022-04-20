using DSAndAlgo.DynamicProgramming;
using System;

namespace DSAndAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 8, 4, 6, 11 };
            int sum = 13;
            int n = arr.Length;

            SubSetSum.printAllSubsets(arr, n, sum);

            Console.WriteLine("Hello World!");

        }
    }
}
