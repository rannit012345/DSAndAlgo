using System;
using System.Collections.Generic;

namespace DSAndAlgo.Stacks
{
    class MaximumAreaOfHistogram
    {
        /// <summary>
        /// I/P - 6, 2, 5, 4, 5, 1, 6 | O/P- 12
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public double Area(int[] arr)
        {
            List<int> nslOfEachElement = NearestSmallerToLeft(arr);
            List<int> nsrOfEachElement = NearestSmallerToRight(arr);

            double max = double.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                double area = arr[i] * (nsrOfEachElement[i] - nslOfEachElement[i] - 1);
                Console.WriteLine("Area {0}", area);

                max = Math.Max(max, area);
            }

            Console.WriteLine("Maximum Area {0}", max);
            return max;
        }

        public List<int> NearestSmallerToLeft(int[] arr)
        {
            List<int> list = new List<int>();
            Stack<KeyValuePair<int, int>> stack = new Stack<KeyValuePair<int, int>>();

            int pseudoIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (stack.Count == 0)
                {
                    list.Add(pseudoIndex);
                }
                else if (stack.Count > 0 && stack.Peek().Key < arr[i])
                {
                    list.Add(stack.Peek().Value);
                }
                else if (stack.Count > 0 && stack.Peek().Key >= arr[i])
                {
                    while (stack.Count > 0 && stack.Peek().Key >= arr[i])
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0)
                    {
                        list.Add(pseudoIndex);
                    }
                    else
                    {
                        list.Add(stack.Peek().Value);
                    }
                }

                stack.Push(new KeyValuePair<int, int>(arr[i], i));
            }

            return list;
        }

        public List<int> NearestSmallerToRight(int[] arr)
        {
            List<int> list = new List<int>();
            Stack<KeyValuePair<int, int>> stack = new Stack<KeyValuePair<int, int>>();

            int pseudoIndex = arr.Length;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (stack.Count == 0)
                {
                    list.Add(pseudoIndex);
                }
                else if (stack.Count > 0 && stack.Peek().Key < arr[i])
                {
                    list.Add(stack.Peek().Value);
                }
                else if (stack.Count > 0 && stack.Peek().Key >= arr[i])
                {
                    while (stack.Count > 0 && stack.Peek().Key >= arr[i])
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0)
                    {
                        list.Add(pseudoIndex);
                    }
                    else
                    {
                        list.Add(stack.Peek().Value);
                    }
                }
                stack.Push(new KeyValuePair<int, int>(arr[i], i));
            }

            //Since iterating from the end, just to maintain the order
            list.Reverse();     

            return list;
        }
    }

}
