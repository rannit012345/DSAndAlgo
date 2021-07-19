using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo.GeneralProblems
{
    class Factorial
    {
        /// <summary>
        /// CalFacWithRecursion has Time and space complexity as O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int CalFacWithRecursion(int n)
        {
            if (n == 1) return 1;
            var fac = CalFacWithRecursion(n - 1) * n;
            return fac;
        }

        /// <summary>
        /// CalFacWithIteration has Time and space complexity as 1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int CalFacWithIteration(int n)
        {
            var result = 1;
            for(int i = 2; i<=n; i++)
            {
                result = result * i;                
            }

            return result;
        }

    }
}
