using System;

namespace DSAndAlgo.SlidingWindow
{
    /// <summary>
    /// LeetCode - 1493. Longest Subarray of 1's After Deleting One Element
    /// </summary>
    public class LongestSubarrayOfOnesAfterDeletingOneElement
    {
        /// <summary>
        /// Same as MaxConsecutiveOnes problem, only difference is with the logic of getting maxWindow
        /// i/p - nums = [ 0, 1, 1, 1, 0, 1, 1, 0, 1 ] | o/p - 5
        /// i/p - nums = [ 1, 1, 1, 1, 1, 1 ] | o/p - 5
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int LongestSubarray(int[] nums)
        {
            int i = 0, j = 0;
            int maxWindow = 0, countOnes = 0;

            while (j < nums.Length)
            {
                if (nums[j] == 1)
                    countOnes++;

                while (j - i + 1 - countOnes > 1)
                {
                    if (nums[i] == 1)
                       countOnes--;
                    i++;
                }

                maxWindow = Math.Max(maxWindow, j - i);
                j++;
            }

            return maxWindow;
        }
    }
}
