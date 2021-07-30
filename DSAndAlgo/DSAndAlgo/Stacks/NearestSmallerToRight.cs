using System;
using System.Collections.Generic;

namespace DSAndAlgo.Stacks
{
    class NearestSmallerToRight
    {
        /// <summary>
        /// AV
        /// I/P - 4, 5, 2, 10, 8 | O/P - 4->2, 5->2, 2->-1, 10->8, 8->-1
        /// </summary>
        /// <param name="arr"></param>
        public void Find(int[] arr)
        {
            //Used List of KeyValuePair over Dictionary because Dictionary overides the values for duplicate elements (For ex: dict[key] = value) or throws exception while using Add() method.
            List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();
            Stack<int> stack = new Stack<int>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (stack.Count == 0)
                {
                    list.Add(new KeyValuePair<int, int>(arr[i], -1));
                }
                else if (stack.Count > 0 && stack.Peek() < arr[i])
                {
                    list.Add(new KeyValuePair<int, int>(arr[i], stack.Peek()));
                }
                else if (stack.Count > 0 && stack.Peek() >= arr[i])
                {
                    while (stack.Count > 0 && stack.Peek() >= arr[i])
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0)
                    {
                        list.Add(new KeyValuePair<int, int>(arr[i], -1));
                    }
                    else
                    {
                        list.Add(new KeyValuePair<int, int>(arr[i], stack.Peek()));
                    }
                }

                stack.Push(arr[i]);
            }

            foreach (var item in list)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }

        /// <summary>
        /// Better code
        /// I/P - 4, 5, 2, 10, 8 | O/P - 4->2, 5->2, 2->-1, 10->8, 8->-1
        /// </summary>
        /// <param name="arr"></param>
        public void Find1(int[] arr)
        {
            //Used List of KeyValuePair over Dictionary because Dictionary overides the values for duplicate elements (For ex: dict[key] = value) or throws exception while using Add() method.
            List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                while (stack.Count != 0 && stack.Peek() > arr[i])
                {
                    list.Add(new KeyValuePair<int, int>(stack.Pop(), arr[i]));
                }
                stack.Push(arr[i]);
            }

            while (stack.Count != 0)
            {
                list.Add(new KeyValuePair<int, int>(stack.Pop(), -1));
            }

            foreach (var item in list)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
