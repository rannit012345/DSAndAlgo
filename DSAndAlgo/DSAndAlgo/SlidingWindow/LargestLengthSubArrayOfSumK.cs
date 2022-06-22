using System;
using System.Collections.Generic;

namespace DSAndAlgo.SlidingWindow
{
    class LargestLengthSubArrayOfSumK
    {
        /// <summary>
        /// arr contains +ve values only here.Second Method below handles -ve values as well
        /// I/p 1 : arr=  { 10, 5, 2, 7, 1, 9 } sum=15 O/P1= 4
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public int Find1(int[] arr, int sum)
        {
            int i = 0, j = 0, currSum = 0, maxLenth=0;
            while(j < arr.Length)
            {
                currSum = currSum + arr[j];

                if(currSum < sum)
                {
                    j++;
                }

                if (currSum == sum)
                {
                    maxLenth = Math.Max(j - i + 1, maxLenth);
                    j++;
                }

                if (currSum > sum)
                {
                    while(currSum> sum)
                    {
                        currSum = currSum - arr[i];
                        i++;
                    }
                    if (currSum == sum)
                    {
                        maxLenth = Math.Max(j - i + 1, maxLenth);
                    }

                    j++;
                    }

            }
            return maxLenth;
        }

        /// <summary>
        /// This method handles both -ve value array and +ve value array
        /// I/p 1 : arr=  { -5, 8, -14, 2, 4, 12 } sum=-5  O/P1= 5
        /// I/p 2 : arr=  { 15, -2, 2, -8, 1, 7, 10, 23 } sum= 0  O/P2= 5
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public int Find2(int[] arr, int sum)
        {
            var myDict = new Dictionary<int, int>();
            int i = 0, currSum=0, maxLength=0;
            while(i< arr.Length)
            {
                currSum = currSum + arr[i];
                if(!myDict.ContainsKey(currSum))
                myDict.Add(currSum, i);

                // This condition is needed to handle if first element itself is the sum
                if (sum == currSum)
                    maxLength = i + 1;


                if (myDict.ContainsKey(currSum - sum))
                {
                    var winLength = i- myDict[currSum - sum];
                    maxLength = Math.Max(maxLength, winLength);
                }
                i++;
            }
            return maxLength;
        }
    }
}
