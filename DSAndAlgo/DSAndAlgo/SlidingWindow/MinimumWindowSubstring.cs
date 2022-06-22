using System;
using System.Collections.Generic;

namespace DSAndAlgo.SlidingWindow
{
    /// <summary>
    /// LeetCode - 76. Minimum Window Substring
    /// </summary>
    class MinimumWindowSubstring
    {
        Dictionary<char, int> myDict = new Dictionary<char, int>();

        /// <summary>
        /// AV
        /// I/P 1:"timetopractice" "toc"            O/P 1: 6 opract
        /// I/P 2:"ADOBECODEBANC" "ABC"             O/P 2: 4 BANC
        /// I/P 3: "this is a test string", "tist"  O/P 3: 6 t stri
        /// I/P 4: "geeksforgeeks", "ork"           O/P 4: 5 orgeek
        /// </summary>
        /// <param name="strGiven"></param>
        /// <param name="strToFind"></param>
        public string Find(string strGiven, string strToFind)
        {
            CreateMap(strToFind);

            int i = 0, j = 0, minWindowLength = strGiven.Length + 1;
            string result = "";
            var count = myDict.Count;
            while(j< strGiven.Length)
            {
                if (myDict.ContainsKey(strGiven[j]))
                {
                    myDict[strGiven[j]]--;
                    if (myDict[strGiven[j]] == 0)
                        count--;
                }

                    
            //keep reducing the length unless the count is 0
            while (count == 0)
            {
                if(minWindowLength > j - i + 1)
                {
                   minWindowLength = j - i + 1;
                   result = strGiven.Substring(i, j - i + 1);
                }

                if (myDict.ContainsKey(strGiven[i]))
                {
                    myDict[strGiven[i]]++;

                    if (myDict[strGiven[i]] == 1)
                        count++;
                }

                i++;
            }

            j++;
            }
            Console.WriteLine(result);
            return result;
        }

        private void CreateMap(string strToFind) 
        { 
            for(int i=0; i< strToFind.Length; i++)
            {
                if (myDict.ContainsKey(strToFind[i]))
                {
                    myDict[strToFind[i]]++;
                }
                else
                {
                    myDict.Add(strToFind[i],1);
                }
            }
        }
    }
}
