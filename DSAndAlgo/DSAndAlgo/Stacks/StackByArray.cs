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

        public void Push(T data)
        {
            if (top >= arrSize)
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

        public T Pop()
        {
            if (top < 0)
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

        public T Peek()
        {
            if (top < 0)
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

        public void DeleteStack()
        {
            arr = null;
        }

        public bool IsEmpty()
        {
            return top < 0;
        }

    }

    //Put the same i/p used in StackByLinkedList
}
