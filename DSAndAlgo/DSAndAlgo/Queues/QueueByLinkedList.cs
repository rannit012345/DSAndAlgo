using System;
using DSAndAlgo.LinkedLists;

namespace DSAndAlgo.Queues
{
    /// <summary>
    /// Queue implementation using our linked list implementaion
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class QueueByLinkedList<T>
    {
        private LinkedList<T> list;

        public int Count => list.size;

        public QueueByLinkedList()
        {
            list = new LinkedList<T>();
        }

        /// <summary>
        /// Pushing data to top of queue - Node added to head
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(T data)
        {
            list.Add(data);
        }

        /// <summary>
        /// Return and remove data from front of queue - Head returned and removed
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
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
        /// Element on front is returned - Head returned
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
                return list.head.data;
            }
        }

        /// <summary>
        /// Delete the queue
        /// </summary>
        public void DeleteQueue()
        {
            list = null;
        }

        /// <summary>
        /// Check if queue is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return list.size == 0;
        }
    }


    
    /// <summary>
    /// Queue implementation using only node class - Efficient way
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class QueueByLinkedList1<T>
    {
        private Node<T> front;
        private Node<T> rear;

        public int size { get; set; } 

        public QueueByLinkedList1()
        {
            front = rear = null;
            size = 0;
        }

        /// <summary>
        /// New node added to rear
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(T data)
        {
            Node<T> temp = new Node<T>(data);

            if (front == null && rear == null)
            {
                front = rear = temp;
                return;
            }

            rear.next = temp;
            rear = temp;
        }

        /// <summary>
        /// Front returned and removed
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }
                
            if (front == rear)
            {
                front = rear = null;
                return default(T);
            }
            else
            {
                Node<T> temp = front;
                front = front.next;
                return temp.data;
            }
        }

        /// <summary>
        /// Front returned
        /// </summary>
        /// <returns></returns>
        public T Front()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }
            return front.data;
        }

        /// <summary>
        /// Delete the queue
        /// </summary>
        public void DeleteQueue()
        {
            front = rear = null;
        }

        /// <summary>
        /// Check if queue is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return front == null;
        }
    }

    //Put the same i/p in main which is used in QueueByArray
}
