using System.Collections.Generic;

namespace DSAndAlgo.SlidingWindow
{
    /// <summary>
    /// LeetCode - 30. Substring with Concatenation of All Words
    /// </summary>
    public class WordsConcatenation
    {
        Dictionary<string, int> wordsFrequency = new Dictionary<string, int>();

        /// <summary>
        /// Edu
        /// i/p - s = barfoofoobarthefoobarman, c = ["bar","foo","the"] | o/p - [6,9,12]
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public IList<int> FindSubstring(string s, string[] c)
        {
            if (c == null || c.Length == 0)
                return null;
            
            CreateMap(c);

            IList<int> list = new List<int>();

            int j = 0, wordLength = c[0].Length, wordsCount = c.Length;

            while (j <= s.Length - wordLength * wordsCount)      //  Ex - Say s.Length = 20, wordLength = 3, wordsCount = 2. When j = 14, inner loop will search for all words (wordsCount = 2) in c 
                                                                 // of length 3 (wordLength) present b/w j = 14 to j = 19, so no need to iterate the j fully.
            {
                Dictionary<string, int> wordsSeen = new Dictionary<string, int>();

                for (int i = 0; i < wordsCount; i++)                   
                {
                    int nextWordIndex = j + i * wordLength;
                    string nextWord = s.Substring(nextWordIndex, wordLength);
                    bool isWordPresent = wordsFrequency.ContainsKey(nextWord);

                    if (isWordPresent)
                    {
                        if (!wordsSeen.ContainsKey(nextWord))
                        {
                            wordsSeen[nextWord] = 1;
                        }
                        else
                        {
                            wordsSeen[nextWord]++;
                        }
                    }
                    else
                    {
                        break;
                    }

                    if (wordsSeen[nextWord] > wordsFrequency[nextWord])  //This means we have seen more words than they actually are in wordsFrequency
                        break;

                    if (i == wordsCount - 1)    //This means all words were present (otherwise loop would have broke on isWordPresent else condition) and wordsSeen is equals to wordsFrequency
                        list.Add(j);
                }

                j++;
            }
            return list;
        }

        private void CreateMap(string[] c)
        {
            for (int k = 0; k < c.Length; k++)
            {
                if (!wordsFrequency.ContainsKey(c[k]))
                {
                    wordsFrequency[c[k]] = 1;
                }
                else
                {
                    wordsFrequency[c[k]]++;
                }
            }
        }
    }
}
