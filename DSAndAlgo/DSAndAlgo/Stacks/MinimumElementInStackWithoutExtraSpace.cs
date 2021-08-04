using System.Collections.Generic;

namespace DSAndAlgo.Stacks
{
    class MinimumElementInStackWithoutExtraSpace
    {
        Stack<int> stack = new Stack<int>();
        int me;

        public int GetMinimum()
        {
            if (stack.Count == 0) return -1;

            return me;
        }

        public void Push(int x)
        {
            if (stack.Count == 0)
            {
                stack.Push(x);
                me = x;
            }
            else
            {
                if (x > me)
                {
                    stack.Push(x);
                }
                else if(x < me)
                {
                    stack.Push(2 * x - me);
                    me = x;
                }
            }
        }

        public int Pop()
        {
            if (stack.Count == 0)
            {
                return -1;
            }
            else
            {
                if (stack.Peek() >= me)
                {
                    return stack.Pop();
                }
                else if (stack.Peek() < me)
                {
                    int ans = me;
                    me = 2 * me - stack.Peek();
                    stack.Pop();
                    return ans;
                }

                return -1;
            }
        }

        public int Peek()
        {
            if (stack.Count == 0)
            {
                return -1;
            }
            else
            {
                if (stack.Peek() >= me)
                {
                    return stack.Peek();
                }
                else if (stack.Peek() < me)
                {
                    return me;
                }

                return -1;
            }
        }

    }

    /*  Put this main

        MinimumElementInStackWithoutExtraSpace min = new MinimumElementInStackWithoutExtraSpace();
        min.Push(5);
        min.Push(7);
        min.Push(3);
        Console.WriteLine("Pushed - 5, 7, 3");  
        Console.WriteLine("Peek - {0}", min.Peek());
        Console.WriteLine("Pop - {0}", min.Pop());
        Console.WriteLine("Pop - {0}", min.Pop());
        Console.WriteLine("Minimum Element - {0}", min.GetMinimum());

    */
}
