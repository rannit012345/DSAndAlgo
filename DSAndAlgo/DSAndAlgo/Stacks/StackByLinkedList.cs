using System;
using DSAndAlgo.LinkedLists;

namespace DSAndAlgo.Stacks
{
    /// <summary>
    /// Stack implementation using our linked list implementaion
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class StackByLinkedList<T>
    {
        private LinkedList<T> list;
        public int Count => list.size;

        public StackByLinkedList()
        {
            list = new LinkedList<T>();
        }

        /// <summary>
        /// Pushing data to top of stack - Node added to head
        /// </summary>
        /// <param name="data"></param>
        public void Push(T data)
        {
            list.AddAt(1, data);
        }

        /// <summary>
        /// Return and remove data from top of stack - Head returned and removed
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty, nothing to pop");
                return default(T);
            }
            else
            {
                T top = list.head.data;
                list.RemoveAt(1);
                return top;
            }
        }

        /// <summary>
        /// Return data from top of stack - Head returned
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty, nothing to peek");
                return default(T);
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

    /*  Put below code in main for testing
     
        StackByLinkedList<int> stack = new StackByLinkedList<int>();

        Console.WriteLine("** Pushing 10 values into stack **");
        for (int i = 1; i <= 10; i++)
        {
            stack.Push(i * 10);
            Console.WriteLine("Pushed " + (i * 10).ToString() + " in stack");
        }

        Console.WriteLine();
        Console.WriteLine("** Peeking value **");
        Console.WriteLine(stack.Peek());
        Console.WriteLine();

        Console.WriteLine("**Poping 11 values from stack**");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Popped " + stack.Pop() + " from stack");
        }
        Console.WriteLine("Popped " + stack.Pop() + " from stack");
        Console.WriteLine("Peeked " + stack.Peek() + " from stack");

        Console.WriteLine();
     
     */
}
