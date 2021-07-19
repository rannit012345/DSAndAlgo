namespace DSAndAlgo.Stacks
{
    class SortAStackUsingRecursion
    {
        /// <summary>
        /// I/P Stack = { 1, 5, 0, 2}
        /// </summary>
        /// <param name="arr"></param>
        public void Sort(StackByLinkedList stack)
        {
            if (stack.Count == 1) return;  //Base Conditon

            object temp = stack.Pop();     //Induction

            Sort(stack);                   //Hypothesis

            Insert(stack, temp);          //Induction
        }

        private void Insert(StackByLinkedList stack, object temp)
        {
            if (stack.Count == 0 || (int)stack.Peek() <= (int)temp) //BC
            {
                stack.Push(temp);
                return;
            }

            object val = stack.Pop();                               //I

            Insert(stack, temp);                                    //H

            stack.Push(val);                                        //I
        }
    }

    /**
    
   //I/P - Put below code in main for testing
   
            StackByLinkedList stack = new StackByLinkedList();
            Console.WriteLine("**Sorted Stack");
            stack.Push(1);
            stack.Push(5);
            stack.Push(0);
            stack.Push(2);

            SortAStackUsingRecursion sort = new SortAStackUsingRecursion();
            sort.Sort(stack);

            Console.WriteLine();

            Console.WriteLine("**UnSorted Stack");
            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());  
            }
    
    */
}
