using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo.SlidingWindow
{
    class MinimumWindowSubstring
    {
        Dictionary<char, int> myDict = new Dictionary<char, int>();

        /// <summary>
        /// I/P 1:"timetopractice" "toc"            O/P 1: 6 opract
        /// I/P 2:"ADOBECODEBANC" "ABC"             O/P 2: 4 BANC
        /// I/P 3: "this is a test string", "tist"  O/P 3: 6 t stri
        /// I/P 4: "geeksforgeeks", "ork"           O/P 4: 5 orgeek
        /// </summary>
        /// <param name="strGiven"></param>
        /// <param name="strToFind"></param>
        public void Find(string strGiven, string strToFind)
        {
            myDict.Clear();
            CreateMap(strToFind);
            int i = 0, j = 0, minLength=0;
            string result = "";
            var count = myDict.Count;
            while(j< strGiven.Length)
            {
                if (myDict.ContainsKey(strGiven[j]))
                {
                    myDict[strGiven[j]]--;
                    if (myDict[strGiven[j]] == 0)
                    {
                        count = count - 1;
                    }
                }

                if(count == 0)
                {     
                    //keep reducing the length unless the count is 0
                    while (count == 0)
                    {
                        if (minLength == 0 || minLength > j - i + 1)
                            minLength = j - i + 1;
                           result = strGiven.Substring(i, j - i + 1);
                        if (myDict.ContainsKey(strGiven[i]))
                        {
                            myDict[strGiven[i]]++;
                            if(myDict[strGiven[i]] == 1)
                            {
                                count = count + 1;
                            }
                        }

                        i++;

                    }
                    
                }
                j++;
                
                
            }
            Console.WriteLine(minLength);
            Console.WriteLine(result);


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
