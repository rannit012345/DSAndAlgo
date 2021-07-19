using System;
using System.Collections.Generic;
using System.Collections;

namespace DSAndAlgo
{
    /// <summmary>
    /// Problem Variant1 : You are given an array of integers, {3,2,10,11,7,15}  target = 9. Find a pair whose sum equals to target is 9
    /// -----------------------------------------------------------------------------------------------------------------------------   
    /// Problem Variant2 : Count no. of pairs for a given target, there can be more that 1 pair. Input : arr[] = {1, 5, 7, -1}, sum = 6
    /// Output :  3 Pairs with sum 6 are (1, 5) & (7, -1)
    /// -----------------------------------------------------------------------------------------------------------------------------   
    /// Problem Variant3 :Count no. of pairs for a given target, when there are duplicates , there can be more that 1 pair Input : arr[] = {1, 5, 7, -1, 5}, sum = 6
    /// Output :  3 Pairs with sum 6 are (1, 5), (7, -1) & (1, 5) 
    /// 
    /// <summmary>
    class GivenSumInAnArray
    {
        public void FindPairNoDuplicates(int[] inputArray, int target)
        {
            var hashTable = new Hashtable();

            for(int i = 0; i < inputArray.Length; i++)
            {
                int complement = target - inputArray[i];
                if (!hashTable.ContainsValue(complement))
                    hashTable.Add(i, inputArray[i]);
                else
                {
                    Console.WriteLine("Pair values for a given target " + target + " is (" + complement + ", " + inputArray[i] + ")");
                    break;
                }
            }
        } 

        public int FindPairsCountWithDuplicates(int[] arr, int sum)
        {
            var length = arr.Length;
            Dictionary<int, int> hm = new Dictionary<int, int>();

            // Store counts of all elements
            // in map hm
            for (int i = 0; i < length; i++)
            {

                // initializing value to 0,
                // if key not found
                if (!hm.ContainsKey(arr[i]))
                {
                    hm[arr[i]] = 0;
                }

                hm[arr[i]] = hm[arr[i]] + 1;
            }
            int twice_count = 0;

            // iterate through each element and
            // increment the count (Notice that
            // every pair is counted twice)
            for (int i = 0; i < length; i++)
            {
                
                    if (hm.ContainsKey(sum - arr[i]))// && hm[sum - arr[i]] != 0)
                    {
                        twice_count += hm[sum - arr[i]];
                    }

                    // if (arr[i], arr[i]) pair satisfies
                    // the condition, then we need to ensure
                    // that the count is decreased by one
                    // such that the (arr[i], arr[i])
                    // pair is not considered
                    if (sum - arr[i] == arr[i])
                    {
                        twice_count--;
                    }                               
            }

            // return the half of twice_count
            return twice_count / 2;
        }
    }
}
