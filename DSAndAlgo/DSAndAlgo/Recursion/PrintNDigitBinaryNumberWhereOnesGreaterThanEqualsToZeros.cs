using System;

namespace DSAndAlgo.Recursion
{
    class PrintNDigitBinaryNumberWhereOnesGreaterThanEqualsToZeros
    {
        /// <summary>
        /// Pick or Don’t Pick Way (A.K.A - I/O method and recursive tree)
        /// I/P = 3, O/P = "111", "110", "101"
        /// </summary>
        /// <param name="numberOfDigit"></param>
        public void PrintNDigitBinaryNumber(int numberOfDigit)
        {
            int ones = 0;
            int zeroes = 0;
            string op = "";

            Solve(op, ones, zeroes, numberOfDigit);

        }

        private void Solve(string op, int ones, int zeroes, int n)
        {
            if (n == 0)
            {
                Console.WriteLine("Binary Number = {0}", op);
                return;
            }

            string op1 = op + "1";
            Solve(op1, ones + 1, zeroes, n-1);

            if (ones > zeroes)
            {
                string op2 = op + "0";
                Solve(op2, ones, zeroes + 1, n-1);
            }
        }

    }
}
