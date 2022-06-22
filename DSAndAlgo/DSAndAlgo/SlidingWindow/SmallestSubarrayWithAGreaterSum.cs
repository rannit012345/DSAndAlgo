using System;

namespace DSAndAlgo.SlidingWindow
{
    /// <summary>
    /// LeetCode - 209. Minimum Size Subarray Sum
    /// </summary>
    public class SmallestSubarrayWithAGreaterSum
    {
        /// <summary>
        /// Edu
        /// i/p - nums = [2,3,1,2,4,3] target = 7 | o/p - 2
        /// <param name="target"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindMinSubArray(int target, int[] nums)
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
