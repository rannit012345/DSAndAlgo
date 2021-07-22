using System;

namespace DSAndAlgo.Recursion
{
    class PermutationWithSpaces
    {
        /// <summary>
        /// Pick or Don’t Pick Way (A.K.A - I/O method and recursive tree)
        /// I/P = "abc", O/P = "a_b_c", "a_bc", "ab_c", "abc"
        /// </summary>
        /// <param name="s"></param>
        public void PrintAllPermutationWithSpaces(string s)
        {

            string ip = s;
            string op = "";

            op = op + ip[0];
            ip = ip.Substring(1);


            Solve(ip, op);
        }

        private void Solve(string ip, string op)
        {
            if (ip.Length == 0)
            {
                Console.WriteLine("Permutation = {0}", op);
                return;
            }

            string op1 = op + "_" + ip[0];
            string op2 = op + ip[0];
            ip = ip.Substring(1);

            Solve(ip, op1);
            Solve(ip, op2);

            return;
        }


        /// <summary>
        /// Pick or Don’t Pick Way (A.K.A - I/O method and recursive tree)
        /// I/P = "ab", O/P = "ab", "aB", "Ab", "AB"
        /// </summary>
        public void PrintAllPermutationWithCaseChange(string s)
        {
            string ip = s.ToLower();
            string op = "";

            SolveCaseChange(ip, op);

        }

        private void SolveCaseChange(string ip, string op)
        {
            if (ip.Length == 0)
            {
                Console.WriteLine("Case change = {0}", op);
                return;
            }

            string op1 = op + ip[0];
            string op2 = op + ip[0].ToString().ToUpper();
            ip = ip.Substring(1);

            SolveCaseChange(ip, op1);
            SolveCaseChange(ip, op2);

            return;
        }
    }
}
