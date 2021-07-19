using System;
using System.Collections.Generic;

namespace DSAndAlgo
{
    class SortAnArrayUsingRecursion
    {
        /// <summary>
        /// I/P - new int[] { 1, 5, 0, 2}
        /// </summary>
        /// <param name="arr"></param>
        public void SortArray(int[] arr)
        {
            List<int> list = new List<int>(arr);
            Sort(list);
            
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        private void Sort(List<int> list)
        {
            if (list.Count == 1) return;  //Base Conditon

            int length = list.Count;      //Induction
            int temp = list[length - 1];
            list.RemoveAt(length - 1);

            Sort(list);                  //Hypothesis

            Insert(list, temp);          //Induction

        }

        private void Insert(List<int> list, int temp)
        {
            if(list.Count == 0 || list[list.Count - 1] <= temp) //BC
            {
                list.Add(temp);
                return;
            }

            int length = list.Count;                        //I
            int val = list[length - 1];
            list.RemoveAt(length - 1);

            Insert(list, temp);                             //H

            list.Add(val);                                  //I
        }
    }
}
