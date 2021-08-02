using System;
using System.Collections.Generic;

namespace DSAndAlgo.Stacks
{
    class StockSpanProblem
    {
        /// <summary>
        /// AV
        /// Similar to NearestGreaterToLeft
        /// I/P - 100, 80, 60, 70, 60, 75, 85 | O/P - 100->1, 80->1, 60->1, 70->2, 60->1, 75->4, 85->6
        /// </summary>
        /// <param name="arr"></param>
        public void Find(int[] arr)
        {
            // (ArrayValueAtIndex, (Index, IndexOfNearestToLeftForTheGivenArrayValue))  [For example - (70, (3,1))]
            List<KeyValuePair<int, KeyValuePair<int, int>>> list = new List<KeyValuePair<int, KeyValuePair<int, int>>>();

            // (ArrayValueAtIndex, Index)
            Stack<KeyValuePair<int, int>> stack = new Stack<KeyValuePair<int, int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (stack.Count == 0)
                {
                    list.Add(new KeyValuePair<int, KeyValuePair<int, int>>(arr[i], new KeyValuePair<int, int>(i, -1)));
                }
                else if (stack.Count > 0 && stack.Peek().Key > arr[i])
                {
                    list.Add(new KeyValuePair<int, KeyValuePair<int, int>>(arr[i], new KeyValuePair<int, int>(i, stack.Peek().Value)));
                }
                else if (stack.Count > 0 && stack.Peek().Key <= arr[i])
                {
                    while (stack.Count > 0 && stack.Peek().Key <= arr[i])
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0)
                    {
                        list.Add(new KeyValuePair<int, KeyValuePair<int, int>>(arr[i], new KeyValuePair<int, int>(i, -1)));
                    }
                    else
                    {
                        list.Add(new KeyValuePair<int, KeyValuePair<int, int>>(arr[i], new KeyValuePair<int, int>(i, stack.Peek().Value)));
                    }
                }

                stack.Push(new KeyValuePair<int, int>(arr[i], i));
            }

            foreach (var item in list)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value.Key - item.Value.Value);
            }
        }


        /// <summary>
        /// Similar to NearestGreaterToLeft
        /// I/P - 100, 80, 60, 70, 60, 75, 85 | O/P - 100->1, 80->1, 60->1, 70->2, 60->1, 75->4, 85->6
        /// </summary>
        /// <param name="arr"></param>
        public void Find1(int[] arr)
        {
            // (ArrayValueAtIndex, (Index, IndexOfNearestToLeftForTheGivenArrayValue))  [For example - (70, (3,1))]
            List<KeyValuePair<int, KeyValuePair<int, int>>> list = new List<KeyValuePair<int, KeyValuePair<int, int>>>();

            // (ArrayValueAtIndex, Index)
            Stack<KeyValuePair<int, int>> stack = new Stack<KeyValuePair<int, int>>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                while(stack.Count != 0 && stack.Peek().Key < arr[i] )
                {
                    list.Add(new KeyValuePair<int, KeyValuePair<int, int>>(stack.Peek().Key, new KeyValuePair<int, int>(stack.Peek().Value, i)));
                    stack.Pop();
                }

                stack.Push(new KeyValuePair<int, int>(arr[i], i));
            }

            while (stack.Count != 0)
            {
                list.Add(new KeyValuePair<int, KeyValuePair<int, int>>(stack.Peek().Key, new KeyValuePair<int, int>(stack.Peek().Value, -1)));
                stack.Pop();
            }

            foreach (var item in list)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value.Key - item.Value.Value);
            }
        }
    }
}
