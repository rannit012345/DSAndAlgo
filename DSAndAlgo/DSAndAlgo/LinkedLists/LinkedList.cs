using System;

namespace DSAndAlgo.LinkedLists
{
    class LinkedList<T>
    {
        public Node<T> head;
        public int size { private set; get; }

        public LinkedList()
        {
            head = null;
        }

        /// <summary>
        /// Add node at the end
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
            {
                head = node;
                size++;
                return;
            }

            Node<T> currentNode = head;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            currentNode.next = node;
            size++;
        }

        /// <summary>
        /// Add node at any position
        /// </summary>
        /// <param name="pos">Enter 1 to add to head</param>
        /// <param name="data"></param>
        public void AddAt(int pos, T data)
        {
            Node<T> node = new Node<T>(data);
            int index = pos - 1;

            if (head == null)
            {
                head = node;
                size++;
            }
            else if (index == 0)
            {
                node.next = head;
                head = node;
                size++;
            }
            else if (index >= size)
            {
                Add(data);
            }
            else
            {
                Node<T> currentNode = head;
                int counter = 0;

                while (counter < index - 1)
                {
                    currentNode = currentNode.next;
                    counter++;
                }

                Node<T> temp = currentNode.next;
                currentNode.next = node;
                currentNode.next.next = temp;
                size++;
            }
        }

        /// <summary>
        /// Remove node from end
        /// </summary>
        public void Remove()
        {
            if (head == null)
            {
                return;
            }

            Node<T> currentNode = head;

            while (currentNode.next.next != null)
            {
                currentNode = currentNode.next;
            }
            currentNode.next = currentNode.next.next;
            size--;
        }

        /// <summary>
        /// Remove node at specific position
        /// </summary>
        /// <param name="index">Enter 1 to remove from head</param>
        public void RemoveAt(int pos)
        {
            int index = pos - 1;

            if (head == null)
            {
                return;
            }
            else if (index == 0)
            {
                head = head.next;
                size--;
            }
            else if (index >= size)
            {
                Remove();
            }
            else
            {
                Node<T> currentNode = head;
                int counter = 0;

                while (counter < index - 1)
                {
                    currentNode = currentNode.next;
                    counter++;
                }
                currentNode.next = currentNode.next.next;
                size--;
            }
        }

        /// <summary>
        /// Search a value in a linked list
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool SearchNode(object data)
        {
            if (head == null)
            {
                return false;
            }

            Node<T> currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.data?.ToString() == data?.ToString())
                {
                    return true;
                }
                currentNode = currentNode.next;
            }
            return false;
        }

        /// <summary>
        /// Print all values in the linked list
        /// </summary>
        public void PrintList()
        {
            if (head == null)
            {
                return;
            }

            Node<T> currentNode = head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data?.ToString());
                currentNode = currentNode.next;
            }
        }
    }

    /*  Put below code in main for testing
     
        LinkedList<int> list = new LinkedList<int>();

        //Add
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.AddAt(3, 5);
        list.AddAt(8, 6);
        list.AddAt(1, 7);

        //Search
        list.SearchNode(4);

        //Remove
        list.Remove();
        list.RemoveAt(4);
        list.RemoveAt(10);
        list.RemoveAt(1);

        //Print list
        list.PrintList();

        //Size
        Console.WriteLine("Size: {0}", list.size.ToString());
     
     */
}


