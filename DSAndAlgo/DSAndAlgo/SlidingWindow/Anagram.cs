using System;
using System.Collections.Generic;

namespace DSAndAlgo.SlidingWindow
{
    /// <summary>
    /// 438. Find All Anagrams in a String
    /// </summary>
    class Anagram
    {
        #region AV

        /// <summary>
        /// AV
        /// </summary>
        /// <param name="str"></param>
        /// Counts the no of anangrams in a given string for a given pattern 
        /// I/P - ("forfoxrfmrfo", "for") O/P - 4
        /// I/P - ("aaabbaabaa", "aab") O/P - 5
        /// <param name="pattern"></param>
        public void Count(string str, string pattern)
        {
            var patternDict = new Dictionary<char, int>();

            // creating Dictionary with pattern values and count
            LoadDict(pattern, patternDict);

            // counter for number of items in the dictionary, when it is equal to 0 that's when we found our anagram
            var loopCounter = patternDict.Count;

            int i = 0, j = 0, anagramCount = 0;
            var length = str.Length;

            while (j < length)
            {
                // calculation when you found an element for anagram
                if (patternDict.ContainsKey(str[j]) )
                {
                    patternDict[str[j]]--;
                    if (patternDict[str[j]] == 0) { loopCounter--; }
                }

                // when window size is less than required
                if (j - i + 1 < pattern.Length)
                {                                            
                    j++;                   
                }

                // slide window code
                else if(j - i + 1 == pattern.Length)
                {                   
                   
                    if (loopCounter == 0) { anagramCount++;  }

                    // calculation before sliding the window. For loopcounter, we decrease it when element count is 0 and increase the loopcounter when element count is 1
                    if (patternDict.ContainsKey(str[i]))
                    {
                        patternDict[str[i]]++;
                        if (patternDict[str[i]] == 1) loopCounter++;
                    }

                    i++;
                    j++;                    
                   
                }
                
            }
            Console.WriteLine("Count is" + anagramCount);
        }

        private void LoadDict(string pattern, Dictionary<char, int> patternDict)
        {
            
            for (int k = 0; k < pattern.Length; k++)
            {  
                if(patternDict.ContainsKey(pattern[k]))
                {
                    patternDict[pattern[k]]++;
                }
                else
                {
                    patternDict.Add(pattern[k], 1);
                }
                
            }
        }

        #endregion



        #region Edu

        Dictionary<char, int> myDict = new Dictionary<char, int>();

        /// <summary>
        /// Edu
        /// i/p - s="abbcabc", p="abc" | o/p - [2, 3, 4]
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public IList<int> FindAnagrams(string s, string p)
        {
            CreateMap(p);
            IList<int> list = new List<int>();

            int i = 0, j = 0, count = myDict.Count;

            while (j < s.Length)
            {
                if (myDict.ContainsKey(s[j]))
                {
                    myDict[s[j]]--;

                    if (myDict[s[j]] == 0)
                        count--;
                }

                while (j - i + 1 > p.Length)
                {
                    if (myDict.ContainsKey(s[i]))
                    {
                        myDict[s[i]]++;
                        if (myDict[s[i]] == 1)
                            count++;
                    }
                    i++;
                }
                j++;

                if (count == 0)
                    list.Add(i);
            }
            return list;
        }

        private void CreateMap(string p)
        {
            for (int k = 0; k < p.Length; k++)
            {
                if (!myDict.ContainsKey(p[k]))
                {
                    myDict[p[k]] = 1;
                }
                else
                {
                    myDict[p[k]]++;
                }
            }
        }

        #endregion
    }
}
