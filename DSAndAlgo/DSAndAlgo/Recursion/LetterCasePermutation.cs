using System;

namespace DSAndAlgo.Recursion
{
    class LetterCasePermutation
    {
        /// <summary>
        /// Pick or Don’t Pick Way (A.K.A - I/O method and recursive tree)
        /// I/P = "a1B2", O/P = "a1b2", "a1B2", "A1b2", "A1B2"
        /// </summary>
        /// <param name="s"></param>
        public void PrintLetterCasePermutation(string s)
        {
            string ip = s;
            string op = "";

            Solve(ip, op);
        }

        private void Solve(string ip, string op)
        {
            if (ip.Length == 0)
            {
                Console.WriteLine("Leter case = {0}", op );
                return;
            }

            if (Char.IsLetter(ip[0]))
            {
                string op1 = op + ip[0].ToString().ToLower();
                string op2 = op + ip[0].ToString().ToUpper();
                ip = ip.Substring(1);

                Solve(ip, op1);
                Solve(ip, op2);
            }
            else
            {
                string op1 = op + ip[0];
                ip = ip.Substring(1);

                Solve(ip, op1);
            }
            return;
        }
    }
}
