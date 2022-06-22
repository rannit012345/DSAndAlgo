using System.Collections.Generic;

namespace DSAndAlgo.SlidingWindow
{
    /// <summary>
    ///  LeetCode - 567. Permutation in String
    /// </summary>
    public class PermutationInString
    {
        Dictionary<char, int> myDict = new Dictionary<char, int>();

        /// <summary>
        /// Edu
        /// i/p - s1 = "ab", s2 = "eidbaooo" | o/p - true (s2 contains one permutation of s1 ("ba"))
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool CheckInclusion(string s1, string s2)
        {
            CreateMap(s1);

            int i = 0, j = 0, count = myDict.Count;

            while (j < s2.Length)
            {
                if (myDict.ContainsKey(s2[j]))
                {
                    myDict[s2[j]]--;

                    if (myDict[s2[j]] == 0)
                        count--;
                }

                while (j - i + 1 > s1.Length)
                {
                    if (myDict.ContainsKey(s2[i]))
                    {
                        myDict[s2[i]]++;
                        if (myDict[s2[i]] == 1)
                            count++;
                    }
                    i++;
                }
                j++;

                if (count == 0)
                    return true;
            }
            return false;
        }

        private void CreateMap(string s)
        {
            for (int k = 0; k < s.Length; k++)
            {
                if (!myDict.ContainsKey(s[k]))
                {
                    myDict[s[k]] = 1;
                }
                else
                {
                    myDict[s[k]]++;
                }
            }
        }
    }
}
