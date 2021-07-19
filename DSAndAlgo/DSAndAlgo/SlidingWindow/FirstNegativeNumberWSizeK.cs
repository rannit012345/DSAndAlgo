using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo.SlidingWindow
{
    class FirstNegativeNumberWSizeK
    {
        /// <summary>
        /// I/P1 : { -8, 2, 3, -6, 10 } k=2  O/P1: -8 0 -6 -6
        /// I/P2 : {12, -1, -7, 8, -15, 30, 16, 28} k=3  O/P2: -1 -1 -7 -15 -15 0
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="k"></param>
        public void Find(int[] arr, int k)
        {
            int i = 0, j = 0;
            var negList = new List<int>();

            while (j < arr.Length)
            {
                if(arr[j] < 0)
                negList.Add(arr[j]);

                if (j - i + 1 < k)
                {
                    j++;
                }

                //Maintain window after reacking on k size window
                else if (j - i + 1 == k)
                {
                    if (negList.Count == 0) Console.WriteLine(0);
                    else
                    {
                        Console.WriteLine(negList[0]);

                    }
                    if (negList.Contains(arr[i]))
                    {
                        negList.RemoveAt(0);
                       
                    }

                    i++;
                    j++;
                }

            }

        }
    }
}
