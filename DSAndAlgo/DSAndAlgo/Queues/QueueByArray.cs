using System;

namespace DSAndAlgo.Queues
{
    class QueueByArray<T>
    {
        private T[] arr;
        private int arrSize;
        private int front;
        private int rear;

        public int Count => arr.Length;

        public QueueByArray(int queueSize)
        {
            front = rear = -1;
            arrSize = queueSize;
            arr = new T[queueSize];
        }

        /// <summary>
        /// Enqueing data to rear of queue - Rear incremented and Element added to the rear
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(T data)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }
            else if(IsEmpty())
            {
                front = rear = 0;
            }
            else
            {
                rear++;
            }
            arr[rear] = data;
        }

        /// <summary>
        /// Dequeing data from front of queue - Element on front is returned (Not deleted) and front is incremented
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }
            else if(front == rear)
            {
                T frontElement = arr[front];
                front = rear = -1;
                return frontElement;
            }
            else
            {
                T frontElement = arr[front];
                front++;
                return frontElement;
            }
        }

        /// <summary>
        /// Element on front is returned
        /// </summary>
        /// <returns></returns>
        public T Front()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }
            else
            {
                return arr[front];
            }
        }

        /// <summary>
        /// Delete the queue
        /// </summary>
        public void DeleteQueue()
        {
            arr = null;
        }

        /// <summary>
        ///  Check if queue is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return front == -1 && rear == -1;
        }

        /// <summary>
        /// Check if queue is full
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return rear == arrSize - 1 ;
        }

    }

    /*  Put below code in main for testing
     
        QueueByArray<int> queue = new QueueByArray<int>(5);
        Console.WriteLine("Enqueing 1, 2, 3, 4, 5");
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        Console.WriteLine("Dequeued {0}", queue.Dequeue());
        Console.WriteLine("Dequeued {0}", queue.Dequeue());
        Console.WriteLine("Enqueing 6, 7, 8");
        queue.Enqueue(6);
        queue.Enqueue(7);
        queue.Enqueue(8);
        Console.WriteLine("Front {0}", queue.Front());

        Console.WriteLine();
     */
}
