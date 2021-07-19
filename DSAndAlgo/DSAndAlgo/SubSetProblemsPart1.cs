using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgo
{
    //Problem 1 : Find whether a subset exist with a given sum in an array. For Example: {3, 5, 7, 1, 2, 9, 4} Sum = 8
    //Problem 2 : Find count of subsets with a given sum in an array. For Example: {3, 5, 7, 1, 2, 9, 4} Sum = 8 

    class SubSetProblemsPart1
    {
        public int CountSubsetExists(int[] arr, int sum)
        {
            
            var length = arr.Length;
            int[,] t = new int[length + 1,sum +1];
            for (int i=0; i< length+1; i++)
            {
                for (int j = 0; j < sum + 1; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        if (i == 0)
                        {
                            t[i, j] = 0;
                        }
                        if (j == 0)
                        {
                            t[i, j] = 1;
                        }
                    }
                    else
                    { 
                    if (arr[i - 1] <= j)
                    {

                        t[i, j] = t[i - 1, j - arr[i - 1]] + t[i - 1, j];
                    }
                    else
                    {
                        t[i, j] = t[i - 1, j];
                    }
                }
                }


            }
            Console.WriteLine("Count Of subsets with Given sum is " + t[length, sum]);
            return t[length, sum];
        }

        public bool IsSubsetExists(int[] arr, int sum)
        {

            var length = arr.Length;
            bool[,] t = new bool[length + 1, sum + 1];
            for (int i = 0; i < length + 1; i++)
            {
                for (int j = 0; j < sum + 1; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        if (i == 0)
                        {
                            t[i, j] = false;
                        }
                        if (j == 0)
                        {
                            t[i, j] = true;
                        }
                    }
                    else
                    {
                        if (arr[i - 1] <= j)
                        {

                            t[i, j] = t[i - 1, j - arr[i - 1]] || t[i - 1, j];
                        }
                        else
                        {
                            t[i, j] = t[i - 1, j];
                        }
                    }
                }


            }
            Console.WriteLine(t[length, sum]);
            return t[length, sum];
        }
    }
}
