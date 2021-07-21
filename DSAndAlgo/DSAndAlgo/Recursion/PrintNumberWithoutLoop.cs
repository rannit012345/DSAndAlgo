using System;

namespace DSAndAlgo.Recursion
{
    class PrintNumberWithoutLoop
    {
        public void PrintSum1toN(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(n);
                return;
            }
            PrintSum1toN(n - 1);
            Console.WriteLine(n);
        }

        public void PrintSumNto1(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(n);
                return;
            }
            Console.WriteLine(n);
            PrintSumNto1(n - 1);
        }
    }
}
