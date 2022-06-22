using System;

namespace DSAndAlgo.SlidingWindow
{
    class MaximumSumSubArraySizeK
    {
        /// <summary>
        /// AV
        /// i/p - arr = [100, 200, 300, 400],  k = 2 | o/p - 700 
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


        /// <summary>
        /// Edu (Almost same as above)
        /// i/p - nums = [2, 1, 5, 1, 3, 2],  target = 3 | o/p - 9
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int FindMaxSubArray(int[] nums, int target)
        {
            int i = 0; int j = 0; int sum = 0;
            int length = nums.Length;
            int maxSubArrayLength = int.MaxValue;

            while (j < length)
            {
                sum = sum + nums[j];

                while (sum >= target)
                {
                    maxSubArrayLength = Math.Min(maxSubArrayLength, j - i + 1);
                    sum = sum - nums[i];
                    i++;
                }

                j++;
            }
            return maxSubArrayLength == int.MaxValue ? 0 : maxSubArrayLength;
        }
    }
}
