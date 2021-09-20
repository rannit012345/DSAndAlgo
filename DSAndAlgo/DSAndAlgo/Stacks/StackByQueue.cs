
using DSAndAlgo.Queues;

namespace DSAndAlgo.Stacks
{
    /// <summary>
    /// Using two stacks - Pop and Peek Costly
    /// </summary>
    class StackByQueue<T>
    {
        private QueueByLinkedList<T> q1, q2;

        public int Count { get; private set; }
        
        public StackByQueue()
        {
            q1 = new QueueByLinkedList<T>();
            q2 = new QueueByLinkedList<T>();
            Count = 0;
        }

        public T Pop()
        {
            if (q1.IsEmpty()) return default(T);

            while (q1.Count != 1)
            {
                q2.Enqueue(q1.Dequeue());
            }

            // Pop last element in q1 and return this element
            T element =  q1.Dequeue();
            Count--;

            // swap the names of two queues, making q2 empty again
            QueueByLinkedList<T> q = q1;
            q1 = q2;
            q2 = q;

            return element;
        }

        public T Peek()
        {
            if (q1.IsEmpty()) return default(T);

            while (q1.Count != 1)
            {
                q2.Enqueue(q1.Dequeue());
            }

            // Pop last element in q1 and push it back to q2 (peek operation), then same is returned
            T element = q1.Dequeue();

            // Push last element to q2 
            q2.Enqueue(element);

            // Swap the two queues names, making q2 empty again
            QueueByLinkedList<T> q = q1;
            q1 = q2;
            q2 = q;

            return element;
        }

        public void Push(T data)
        {
            q1.Enqueue(data);
            Count++;
        }
    }


    /// <summary>
    /// Using two stacks - Push Costly
    /// </summary>
    class StackByQueue1<T>
    {
        private QueueByLinkedList<T> q1, q2;

        public int Count { get; private set; }

        public StackByQueue1()
        {
            q1 = new QueueByLinkedList<T>();
            q2 = new QueueByLinkedList<T>();
        }

        public void Push(T data)
        {
            // Push data to empty q2 
            q2.Enqueue(data);
            Count++;

            // Push all the remaining elements of q1 to q2. 
            while (!q1.IsEmpty())
            {
                q2.Enqueue(q1.Dequeue());
            }

            // Swap the two queues names, making q2 empty again
            QueueByLinkedList<T> q = q1;
            q1 = q2;
            q2 = q;
        }

        public T Peek()
        {
            if (q1.IsEmpty()) return default(T);
                
            return q1.Front();
        }

        public T Pop()
        {
            if (q1.IsEmpty()) return default(T);

            T element = q1.Dequeue();
            Count--;
            return element;
        }
    }

    /*  Put below code in main for testing
     
        StackByQueue<int> stack = new StackByQueue<int>();
        Console.WriteLine("Push 1, 5");
        stack.Push(1);
        stack.Push(5);
        Console.WriteLine("Peek {0}", stack.Peek());
        Console.WriteLine("Push 3");
        stack.Push(3);
        Console.WriteLine("Pop {0}", stack.Pop());
        Console.WriteLine("Push 6");
        stack.Push(6);
        Console.WriteLine("Push 8");
        stack.Push(8);
        Console.WriteLine("Pop {0}", stack.Pop());
        Console.WriteLine("Pop {0}", stack.Pop());
        Console.WriteLine("Count {0}", queue.Count);
     */
}
