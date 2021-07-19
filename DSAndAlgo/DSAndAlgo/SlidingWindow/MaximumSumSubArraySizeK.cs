using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo.SlidingWindow
{
    class MaximumSumSubArraySizeK
    {
        /// <summary>
        /// I/P1= {100, 200, 300, 400} k=2 O/P1= 700 
        /// I/P2= {1, 4, 2, 10, 23, 3, 1, 0, 20} k= 4 O/P2= 39 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int Find(int[] arr, int k)
        {
             int sum = 0, i = 0, j = 0, maxValue=0;

            while(j< arr.Length)
            {
                sum = sum + arr[j];

                if(j-i+1 < k)
                {
                    j++;
                }

                //Maintain window after reacking on k size window
                else if (j - i + 1 == k)
                {
                    maxValue = Math.Max(maxValue, sum);
                    sum = sum - arr[i];

                    i++;
                    j++;
                }

            }

            return maxValue;
        }
    }
}
