using System.Collections.Generic;

namespace DSAndAlgo.Recursion
{
    class DeleteMiddleElementOfAStack
    {
        // I/P - 5,4,3,2,1 | O/P - 5,4,2,1
        public Stack<int> DeleteMiddle(Stack<int> stack, int size)
        {
            if (size == 0)
            {
                return stack;
            }

            int middle = size / 2 + 1;

            Solve(stack, middle);

            return stack;
        }

        public void Solve(Stack<int> stack, int middle)
        {
            if (middle == 1)
            {
                stack.Pop();
                return;
            }

            int temp = stack.Pop();

            Solve(stack, middle - 1);

            stack.Push(temp);

            return;
        }
    }

    /**
    
   //I/P - Put below code in main for testing

        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        DeleteMiddleElementOfAStack deleteMiddle = new DeleteMiddleElementOfAStack();
        deleteMiddle.DeleteMiddle(stack, stack.Count);

        while (stack.Count != 0)
        {
            Console.WriteLine(stack.Pop());
        }

    */
}
