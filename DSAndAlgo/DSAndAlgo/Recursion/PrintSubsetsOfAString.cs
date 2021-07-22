using System;
using System.Collections.Generic;

namespace DSAndAlgo.Recursion
{
    class PrintSubsetsOfAString
    {
        /// <summary>
        /// Pick or Don’t Pick Way (A.K.A - I/O method and recursive tree)
        /// I/P = "ab", O/P = "", "b", "a", "ab"
        /// </summary>
        /// <param name="s"></param>
        public void PrintAllSubsets(string s)
        {
            string ip = s, op = "";
            Solve(ip, op);
        }

        private void Solve(string ip, string op)
        {
            if (ip.Length == 0)
            {
                Console.WriteLine("Subset = {0}", op);
                return;
            }

            string op1 = op;
            string op2 = op + ip[0];
            ip = ip.Substring(1);

            Solve(ip, op1);
            Solve(ip, op2);

            return;
        }


        /// <summary>
        /// Pick or Don’t Pick Way (A.K.A - I/O method and recursive tree)
        /// I/P = "aab", O/P = "", "b", "a", "ab", "aa", "aab"
        /// </summary>
        /// <param name="s"></param>
        public void PrintUniqueSubsets(string s)
        {
            string ip = s, op = "";
            var set = new HashSet<string>();
            SolveUnique(ip, op, set);

            foreach (string val in set)
            {
                Console.WriteLine("Subset = {0}", val);
            }
        }

        private void SolveUnique(string ip, string op, HashSet<string> set)
        {
            if (ip.Length == 0)
            {
                if (!set.Contains(op))
                {
                    set.Add(op);
                }
                return;
            }

            string op1 = op;
            string op2 = op + ip[0];
            ip = ip.Substring(1);

            SolveUnique(ip, op1, set);
            SolveUnique(ip, op2, set);

            return;
        }
    }
}
