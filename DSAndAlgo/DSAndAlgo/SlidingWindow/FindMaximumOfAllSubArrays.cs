using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo.SlidingWindow
{
    class FindMaximumOfAllSubArrays
    {
        /// <summary>
        /// I/P- 1 : (new int[]{ 4, 3, -1, -3, 5, 3, 6, -1 }, 3)  O/P : 4 3 5 5 6 6
        /// I/P- 2 : (new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 5)  O/P : 5 5 6 7
        /// I/P- 3 : (new int[] { 1, 1, -1, 1, 1, 1, 1 }, 4)      O/P : 1 1 1 1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="windowLength"></param>
        public void FindMaximum(int[] arr, int windowLength)
        {
            int i = 0,j = 0;
            var length = arr.Length;
            var maxArrList = new List<int>();

            while(j < length)
            {
                
                while(maxArrList.Count > 0 && arr[j] > maxArrList[0])
                {                  
                    maxArrList.RemoveAt(0);
                   
                }
                maxArrList.Add(arr[j]);
               
                if(j-i+1 < windowLength)
                {
                    j++;
                }

                else if (j - i + 1 == windowLength)
                {
                    Console.WriteLine(maxArrList[0]);
                    if(arr[i] == maxArrList[0]) { maxArrList.RemoveAt(0); }
                    i++;
                    j++;
                }
                

            }

            
        }
    }
}
