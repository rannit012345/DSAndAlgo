using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo
{
    /// <summary>
    /// Print all the subsets, powersets and subsequences for a given string. 
    /// Example1 :  input = "abc" output = ""
    /// Example2 :  input = "ab" output = ""
    /// </summary>
    class SubSetProblemsPart2
    {
        public void printSubsets(string input, string output)
        {
            if(input.Length == 0)
            {
                Console.WriteLine("\"" + output + "\"");
                return;
            }

            string output1 = output;
            string output2 = output + input[0];

            input = input.Remove(0, 1);
            printSubsets(input, output1);
            printSubsets(input, output2);

            return;
        }
    }
}
