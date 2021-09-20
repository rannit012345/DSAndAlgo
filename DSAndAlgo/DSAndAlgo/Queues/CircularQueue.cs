using System;

namespace DSAndAlgo.Queues
{

    /* Circular Array (Concept)

     For a simple array, if current_position = i, then next_position will be i + 1 and previous_position will be i - 1. 
     For a circular array, if current_position = i, then next_position will be (i + 1) % N and previous_position will be (i + N -1) % N where N is size of the array.
        Ex: N = 10, Say current_position i.e, i = 9;
            next_position = (9 + 1) % 10 = 10 % 10 = 0;
            previous_position = (9 + (10 - 1)) % 10 = 18 % 10 = 8;

    Below code is similar to QueueByArray<T>, only differences is in IsFull() method and incrementing rear in Enqueue and front in Dequeue
    */

    class CircularQueue<T>
    {
        private T[] arr;
        private int arrSize;
        private int front;
        private int rear;

        public int Size => arr.Length;

        public int Count
        {
            get
            {
                if (rear >= front)
                {
                    return rear - front + 1;
                }
                else
                {
                    return (Size - front) + rear + 1; 
                }
            } 
        }

        public CircularQueue(int queueSize)
        {
            front = rear = - 1;
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
            else if (IsEmpty())
            {
                front = rear = 0;
            }
            else
            {
                rear = (rear + 1) % arrSize;
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
            else if (front == rear)
            {
                T frontElement = arr[front];
                front = rear = -1;
                return frontElement;
            }
            else
            {
                T frontElement = arr[front];
                front = (front + 1) % arrSize;
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
        ///  Check if queue is full
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return (rear + 1) % arrSize == front;
        }
    }

    //Put the same i/p in main which is used in QueueByArray
}
