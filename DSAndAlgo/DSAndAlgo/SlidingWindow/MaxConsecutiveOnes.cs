using System;

namespace DSAndAlgo.SlidingWindow
{
    /// <summary>
    /// LeetCode - 1004. Max Consecutive Ones III
    /// </summary>
    public class MaxConsecutiveOnes
    {
        /// <summary>
        /// Edu
        /// Similar to LongestRepeatingCharacterReplacement
        /// i/p nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2 | o/p = 6 (1,1,1,1,1,1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int LongestOnes(int[] nums, int k)
        {
            int i = 0, j = 0, longest = 0, maxOnesCount = 0;

            while (j < nums.Length)
            {
                if (nums[j] == 1)
                    maxOnesCount++;

                while (j - i + 1 - maxOnesCount > k) //windows - 1's = 0's and when 0's count > k then minimize the window
                {
                    if (nums[i] == 1)
                        maxOnesCount--;
                    i++;
                }

                longest = Math.Max(longest, j - i + 1);
                j++;
            }
            return longest;
        }
    }
}
