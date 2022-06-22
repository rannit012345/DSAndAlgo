using System;
using System.Collections.Generic;

namespace DSAndAlgo.SlidingWindow
{
    /// <summary>
    /// Leet Code - 424. Longest Substring Without Repeating Characters
    /// </summary>
    public class LongestRepeatingCharacterReplacement
    {
        /// <summary>
        /// Edu
        /// i/p - s="aabccbb", k=2 | o/p - 5 (Replace the two 'c' with 'b' to have the longest repeating substring "bbbbb".)
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int CharacterReplacement(string s, int k)
        {
            int i = 0, j = 0, maxCount = 0, longest = 0;
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            while (j < s.Length)
            {

                if (!charCount.ContainsKey(s[j]))
                {
                    charCount[s[j]] = 1;
                }
                else
                {
                    charCount[s[j]]++;
                }

                maxCount = Math.Max(maxCount, charCount[s[j]]);

                while (j - i + 1 - maxCount > k)
                {
                    charCount[s[i]]--;
                    i++;
                }

                longest = Math.Max(longest, j - i + 1);
                j++;
            }
            return longest;
        }
    }
}
