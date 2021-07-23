using System;
using System.Collections.Generic;

namespace DSAndAlgo.Recursion
{
    class GenerateAllBalancedParenthesis
    {
        /// <summary>
        /// Pick or Don’t Pick Way (A.K.A - I/O method and recursive tree)
        /// I/P = 3
        /// </summary>
        /// <param name="numberOfParenthesis"></param>
        public void BalanceParenthesis(int numberOfParenthesis)
        {
            var set = new HashSet<string>();
            int open = numberOfParenthesis;
            int close = numberOfParenthesis;
            string op = "";

            Solve(open, close, op, set);

            foreach (var item in set)
            {
                Console.WriteLine("Balanced Parenthesis = {0}", item);
            }
        }

        private void Solve(int open, int close, string op, HashSet<string> set)
        {
            if (open == 0 && close == 0)
            {
                set.Add(op);
                return;
            }

            //open paranthesis is always chosen until it become zero - analysed by drawing recursive tree
            if (open != 0)
            {
                string op1 = op + "(";
                Solve(open - 1, close, op1, set);
            }

            //close paranthesis is chosen when close > open - analysed by drawing recursive tree
            if (close> open)
            {
                string op2 = op + ")";
                Solve(open, close - 1, op2, set);
            }

            return;
        }
    }
}
