using System;

namespace DSAndAlgo.Stacks
{
    class StackByArray<T>
    {
        private T[] arr;
        private int arrSize;
        private int top;
        public int Count => arr.Length;

        public StackByArray(int stackSize)
        {
            top = -1;
            arrSize = stackSize;
            arr = new T[stackSize];
        }

        /// <summary>
        /// Pushing data to top of stack - Top incremented and Element added on the top
        /// </summary>
        /// <param name="data"></param>
        public void Push(T data)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                top++;
                arr[top] = data;
            }
        }

        /// <summary>
        /// Popping data from top of stack - Element on top is returned (Not deleted) and top is decremented
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return default(T);
            }
            else
            {
                T value = arr[top];
                top--;
                return value;
            }
        }

        /// <summary>
        /// Element on top is returned
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return default(T);
            }
            else
            {
                Console.WriteLine("The topmost element of Stack is : {0}", arr[top]);
                return arr[top];
            }

        }

        /// <summary>
        /// Delete the stack
        /// </summary>
        public void DeleteStack()
        {
            arr = null;
        }

        /// <summary>
        ///  Check if stack is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return top < 0;
        }

        /// <summary>
        /// Check if stack is full
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return top == arrSize - 1;
        }

    }

    //Put the same i/p in main which is used in StackByLinkedList
}
