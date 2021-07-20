using System;
using System.Collections.Generic;

namespace DSAndAlgo.SlidingWindow
{
    class LongestSubstringWithoutRepeatingChar
    {
        /// <summary>
        /// I/P - str = "pwwkew" | O/P - 3
        /// I/P - str = "abcdabeabbeg" | O/P - 5
        /// </summary>]
        /// <param name="str"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int Find(string str)
        {
            int i = 0, j = 0, longest = 0;
            var dict = new Dictionary<char, int>();

            while (j < str.Length)
            {
                if (!dict.ContainsKey(str[j]))
                {
                    dict.Add(str[j], 1);
                }
                else
                {
                    dict[str[j]]++;
                }

                if (dict.Count == j - i + 1)
                {
                    longest = Math.Max(longest, j - i + 1);
                    j++;
                }
                else if (dict.Count < j - i + 1)
                {
                    while (dict.Count < j - i + 1)
                    {
                        dict[str[i]]--;
                        if (dict[str[i]] == 0)
                        {
                            dict.Remove(str[i]);
                        }
                        i++;
                    }
                    j++;
                }
            }
            return longest;
        }
    }
}
