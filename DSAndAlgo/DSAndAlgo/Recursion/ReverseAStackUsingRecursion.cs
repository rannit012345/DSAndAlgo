using System.Collections.Generic;

namespace DSAndAlgo.Recursion
{
    class ReverseAStackUsingRecursion
    {
        //I/P - 5,4,3,2,1 | O/P - 1,2,3,4,5
        public void Reverse(Stack<int> s)
        {
            if (s.Count == 1) return;

            int temp = s.Pop();

            Reverse(s);

            Insert(s, temp);

            return;
        }

        public void Insert(Stack<int> s, int temp)
        {
            if(s.Count == 0)
            {
                s.Push(temp);
                return;
            }

            int val = s.Pop();

            Insert(s, temp);

            s.Push(val);

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

            Console.WriteLine();
            Console.WriteLine("** Top value **");
            Console.WriteLine(stack.Peek());
            Console.WriteLine();

            ReverseAStackUsingRecursion sort = new ReverseAStackUsingRecursion();
            sort.Reverse(stack);

            Console.WriteLine();
            Console.WriteLine("** Top value **");
            Console.WriteLine(stack.Peek());
            Console.WriteLine();

    */
}
