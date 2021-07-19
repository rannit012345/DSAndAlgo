using System;

namespace DSAndAlgo.GeneralProblems
{
    class FibonacciSeries
    {
        /// <summary>
        /// PrintNthFiboNumberWithRecursion is very bad approach for printing Fibo Number as we are doing repetitive work again and again.
        /// Example: if n= 4 , it will call PrintNthFiboNumberWithRecursion(3) and PrintNthFiboNumberWithRecursion(2), for PrintNthFiboNumberWithRecursion(2)
        /// it will caluclate PrintNthFiboNumberWithRecursion(1) and PrintNthFiboNumberWithRecursion(0), 
        /// for  PrintNthFiboNumberWithRecursion(3) it will again calculate PrintNthFiboNumberWithRecursion(2) and PrintNthFiboNumberWithRecursion(1)
        /// but we alredy calculated PrintNthFiboNumberWithRecursion(2) so we need to solve it via memoization or DP so that we can remember
        /// what we already calculated
        /// 
        /// Time Complexity of this method is O(2^n)(2 raise to power n which is exponential and not good)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int PrintNthFiboNumberWithRecursion(int n)
        {
            if (n <= 1)
            { 
                return n;
            }
            var m = PrintNthFiboNumberWithRecursion(n - 1) + PrintNthFiboNumberWithRecursion(n - 2);

            // print this returnType in main method
            return m;
        }


        /// <summary>
        /// Time Complexity of this method PrintNthFiboNumberWithDPOrMemoization is O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int PrintNthFiboNumberWithDPOrMemoization(int n)
        {
            var f = new int[n + 2];
            f[0] = 0;
            f[1] = 1;

            for (int i = 2; i <= n; i++)
                f[i] = f[i - 1] + f[i - 2];

            // print this returnType in main method
            return f[n];
        }

        public int[] PrintFiboSeries(int n)
        {
            var f = new int[n + 1];
            f[0] = 0;
            f[1] = 1;

            for (int i = 2; i <= n; i++)
                f[i] = f[i - 1] + f[i - 2];

          // print this array in main method
            return f;

        }

        /// <summary>
        /// Check if the diven input is fibonacci number or not. I/P - 41, 55
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            if (n == a || n == b) return true;

            int c = a + b;

            while (c <= n)
            {
                if (c == n) return true;

                a = b;
                b = c;
                c = a + b;
            }
            return false;
        }

        /// <summary>
        /// Check if the diven input is fibonacci number or not. I/P - 41, 55
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool IsFibonacciUsingFormula(int n)
        {
            // n is Fibonacci if one of 5*n*n + 4 or 5*n*n - 4 or both are a perfect square
            return IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4);
        }

        static bool IsPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return s * s == x;
        }

        /// <summary>
        /// Print nth number in the fibonacci series by brute force. I/P - 9
        /// </summary>
        /// <returns></returns>
        public int PrintNthNumberBruteForce(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            if (n == 0) return a;
            if (n == 1) return b;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}
