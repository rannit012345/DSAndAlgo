using System;
using System.Collections.Generic;

namespace DSAndAlgo.SlidingWindow
{
    /// <summary>
    /// LeetCode - 904. Fruit Into Baskets
    /// Substring is a continuous part of a string
    /// It Calculates the longest substring with K unique characters
    /// This is a variable size Window Example. This problem is totally similar to "Pick Toys Problem" In AV Series.
    /// </summary>
    class LongestSubstringWithkUniqueChar
    {
        /// <summary>
        /// AV
        /// I/p - str = "abcbdbdbbdcdabd" k=2,3 | O/P1 - bdbdbbd, O/P2 - bcbdbdbbdcd
        /// I/P - str = "aabacbeghbe" k=3 | O/P - aabacb
        /// </summary>
        /// <param name="str"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int Find(string str, int k)
        {
            int i = 0, j = 0, longValueResult = 0;
            var myDict = new Dictionary<char, int>();
            string printValue = null;
            
            while (j < str.Length)
            {
                //General Calculations
                if (!myDict.ContainsKey(str[j]))
                {
                    myDict.Add(str[j], 1);
                }
                else
                {
                    myDict[str[j]]++;
                }

                // when Dictionary contains less elements than we require as k then just increment
                if(myDict.Count < k) { j++; }

                // we get our answer when Dictionary contains elements equal to k
                else if(myDict.Count == k) 
                {
                    if (longValueResult < j - i + 1)
                    {
                        longValueResult = j - i + 1;
                         printValue = str.Substring(i, j - i + 1);
                        
                    }
                    j++;
                }

                // we have to remove elements when Dictionary contains more elements than k , remove untill count == k conditon meet
                // Below while loop we are removing some elements from the window, therefore the size of window will definitely
                // reduce from the current size and we've already taken care of the largest valid window size up to this position (in 2nd condition).
                else if (myDict.Count > k)
                {
                    while(myDict.Count > k)
                    {
                        myDict[str[i]]--;
                        if(myDict[str[i]] == 0) { myDict.Remove(str[i]); }
                        i++;
                    }
                    j++;
                }
            }
            Console.WriteLine(printValue);
            return longValueResult;
        }

        /// <summary>
        /// Edu (Almost same as above)
        /// i/p - str="araaci", k=2 | o/p - 4 (araa)
        /// </summary>
        /// <param name="str"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int FindLength(string str, int k)
        {
            int i = 0, j = 0, length = str.Length; int maxLength = 0;
            Dictionary<char, int> charAndCounts = new Dictionary<char, int>();

            while (j < length)
            {
                if (!charAndCounts.ContainsKey(str[j]))
                {
                    charAndCounts[str[j]] = 1;
                }
                else
                {
                    charAndCounts[str[j]]++;
                }

                if (charAndCounts.Count > k)
                {
                    while (charAndCounts.Count > k)
                    {
                        charAndCounts[str[i]]--;
                        if (charAndCounts[str[i]] == 0) 
                            charAndCounts.Remove(str[i]); 
                        i++;
                    }
                }

                maxLength = Math.Max(maxLength, j - i + 1);
                j++;
            }
            
            return maxLength;
        }
    }
}
