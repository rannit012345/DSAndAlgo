using System.Collections.Generic;

namespace DSAndAlgo.Stacks
{
    class MinimumElementInStackWithExtraSpace
    {
        Stack<int> stack = new Stack<int>();
        Stack<int> supportingStack = new Stack<int>();

        public int GetMinimum()
        {
            if (supportingStack.Count == 0) return -1;

            return supportingStack.Peek();
        }

        public void Push(int a)
        {
            stack.Push(a);

            if (supportingStack.Count == 0 || supportingStack.Peek() >= a) supportingStack.Push(a);
        }

        public int Pop()
        {
            if (stack.Count == 0) return -1;

            int ans = stack.Pop();
            if (supportingStack.Peek() == ans) supportingStack.Pop();
            return ans;
        }
    }

    /*  Put this main

        MinimumElementInStackWithExtraSpace min = new MinimumElementInStackWithExtraSpace();
        min.Push(18);
        min.Push(19);
        min.Push(29);
        min.Push(15);
        Console.WriteLine("Pushed - 18, 19, 29, 15");
        Console.WriteLine("Pop - {0}", min.Pop());
        min.Push(16);
        Console.WriteLine("Pushed - 16");
        Console.WriteLine("Minimum Element - {0}", min.GetMinimum());

    */
}
