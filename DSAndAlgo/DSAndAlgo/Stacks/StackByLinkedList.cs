using System;
using DSAndAlgo.LinkedLists;

namespace DSAndAlgo.Stacks
{
    class StackByLinkedList
    {
        private SingleLinkedList list;
        public int Count => list.size;
        public object top => Peek();

        public StackByLinkedList()
        {
            list = new SingleLinkedList();
        }

        /// <summary>
        /// Pushing data to top of stack - Node added to head
        /// </summary>
        /// <param name="data"></param>
        public void Push(object data)
        {
            list.AddAt(0, data);
        }

        /// <summary>
        /// Return and remove data from top of stack - head removed
        /// </summary>
        /// <returns></returns>
        public object Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return null;
            }
            else
            {
                object top = list.head.data;
                list.RemoveAt(0);
                return top;
            }
        }

        /// <summary>
        /// Return data from top of stack
        /// </summary>
        /// <returns></returns>
        public object Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty, nothing to peek");
                return null;
            }
            else
            {
                return list.head.data;
            }
        }

        /// <summary>
        /// Delete the stack
        /// </summary>
        public void DeleteStack()
        {
            list.head = null;
        }

        /// <summary>
        /// Check if stack is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return list.size == 0;
        }
    }

    /**
     
    //I/P - Put below code in main for testing
    
            StackByLinkedList stack = new StackByLinkedList();

            Console.WriteLine("** Pushing 10 values into stack **");
            for (int i = 1; i <= 10; i++)
            {
                stack.Push(i * 10);
                Console.WriteLine("Inserted " + i.ToString() + " in stack");
            }

            Console.WriteLine();
            Console.WriteLine("** Peeking value **");
            Console.WriteLine(stack.Peek());
            Console.WriteLine();

            Console.WriteLine("**Poping 11 values from stack**");
            for (int i = 1; i <= 11; i++)
            {
               Console.WriteLine("Removed " + stack.Pop() + " from stack");
            }
            Console.WriteLine();
     
     */
}
