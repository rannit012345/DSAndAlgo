using DSAndAlgo.Stacks;

namespace DSAndAlgo.Queues
{
    /// <summary>
    /// Using two stacks - Dequeue Costly - Better than Enqueue Costly
    /// </summary>
    class QueueByStack<T>
    {
        private StackByLinkedList<T> s1, s2;
        public int Count { get; private set; }

        public QueueByStack()
        {
            s1 = new StackByLinkedList<T>();
            s2 = new StackByLinkedList<T>();
            Count = 0;
        }

        public T Dequeue()
        {
            if (s1.IsEmpty() && s2.IsEmpty()) return default(T);

            if (s2.IsEmpty())
            {
                while (!s1.IsEmpty())
                {
                    s2.Push(s1.Pop());
                }
            }

            Count--;
            return s2.Pop();
        }

        public T Front()
        {
            if (s1.IsEmpty() && s2.IsEmpty()) return default(T);

            if (s2.IsEmpty())
            {
                while (!s1.IsEmpty())
                {
                    s2.Push(s1.Pop());
                }
            }

            return s2.Peek();
        }

        public void Enqueue(T data)
        {
            s1.Push(data);
            Count++;
        }
    }


    /// <summary>
    /// Using single stack - Dequeue Costly - Recursion
    /// </summary>
    class QueueByStackRecursion<T>
    {
        private StackByLinkedList<T> s;
        public int Count
        {
            get
            {
                return s.Count;
            }
            private set { }
        }
            

        public QueueByStackRecursion()
        {
            s = new StackByLinkedList<T>();
        }

        public T Dequeue()
        {
            if (s.IsEmpty()) return default(T);

            if (s.Count == 1)
            {
                return s.Pop();
            }
            else
            {
                // pop an item from the stack 
                T x = s.Peek();
                s.Pop();

                // recursive call 
                T item = Dequeue();

                // push popped item back to the stack 
                s.Push(x);

                // return the result of deQueue() call 
                return item;
            }
        }

        public void Enqueue(T data)
        {
            s.Push(data);
        }
    }


    /// <summary>
    /// Using two stacks - Enqueue Costly - Better way
    /// </summary>
    class QueueByStack2<T>
    {
        private StackByLinkedList<T> s1, s2;
        public int Count { get; private set; }

        public QueueByStack2()
        {
            s1 = new StackByLinkedList<T>();
            s2 = new StackByLinkedList<T>();
            Count = 0;
        }

        public void Enqueue(T data)
        {
            if (!s1.IsEmpty())
            {
                while (!s1.IsEmpty())
                {
                    s2.Push(s1.Pop());
                }
            }

            s1.Push(data);
            Count++;

            if (!s2.IsEmpty())
            {
                while (!s2.IsEmpty())
                {
                    s1.Push(s2.Pop());
                }
            }
        }

        public T Dequeue()
        {
            if (s1.IsEmpty()) return default(T);

            Count--;
            return s1.Pop();
        }

        public T Front()
        {
            if (s1.IsEmpty()) return default(T);

            return s1.Peek();
        }
    }

    /*  Put below code in main for testing
     
        QueueByStack<int> queue = new QueueByStack<int>();
        Console.WriteLine("Enqueing 1, 5");
        queue.Enqueue(1);
        queue.Enqueue(5);
        Console.WriteLine("Front {0}", queue.Front());
        Console.WriteLine("Enqueing 3");
        queue.Enqueue(3);
        Console.WriteLine("Dequeued {0}", queue.Dequeue());
        Console.WriteLine("Enqueing 6");
        queue.Enqueue(6);
        Console.WriteLine("Enqueing 8");
        queue.Enqueue(8);
        Console.WriteLine("Dequeued {0}", queue.Dequeue());
        Console.WriteLine("Dequeued {0}", queue.Dequeue());
        Console.WriteLine("Count {0}", queue.Count);

        Console.WriteLine();
     */
}
