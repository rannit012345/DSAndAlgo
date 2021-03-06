using System.Collections.Generic;

namespace DSAndAlgo.Recursion
{
    class SortAStackUsingRecursion
    {
        /// <summary>
        /// I/P Stack = { 1, 5, 0, 2}
        /// </summary>
        /// <param name="arr"></param>
        public void Sort(Stack<int> stack)
        {
            if (stack.Count == 1) return;  //Base Conditon

            int temp = stack.Pop();     //Induction

            Sort(stack);                   //Hypothesis

            Insert(stack, temp);          //Induction
        }

        private void Insert(Stack<int> stack, int temp)
        {
            if (stack.Count == 0 || stack.Peek() <= temp) //BC
            {
                stack.Push(temp);
                return;
            }

            int val = stack.Pop();                               //I

            Insert(stack, temp);                                    //H

            stack.Push(val);                                        //I
        }
    }

    /**
    
   //I/P - Put below code in main for testing
   
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(5);
            stack.Push(0);
            stack.Push(2);

            SortAStackUsingRecursion sort = new SortAStackUsingRecursion();
            sort.Sort(stack);

            Console.WriteLine();

            Console.WriteLine("**Sorted Stack");
            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());  
            }
    
    */
}
