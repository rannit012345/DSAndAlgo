using System;
using System.Collections.Generic;

namespace DSAndAlgo.SlidingWindow
{
    class Anagram
    {
        /// <summary>
        /// 
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

                    if (patternDict.ContainsKey(str[i]))
                    {
                        if(patternDict[str[i]] == 0) loopCounter++;
                        patternDict[str[i]]++;
                        
                    }

                    i++;
                    j++;                    
                   
                }
                
            }
            Console.WriteLine("Count is" + anagramCount);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="patternDict"></param>
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
    }
}
