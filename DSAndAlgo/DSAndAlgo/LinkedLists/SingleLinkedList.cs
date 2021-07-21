using System;

namespace DSAndAlgo.LinkedLists
{
    //Better to create generic single linked list
    class SingleLinkedList
    {
        public SingleNode head;
        public int size { private set; get; }

        public SingleLinkedList()
        {
            head = null;
        }

        /// <summary>
        /// Add node at the end
        /// </summary>
        public void Add(object data)
        {
            SingleNode node = new SingleNode(data);

            if (head == null)
            {
                head = node;
                size++;
                return;
            }
           
            SingleNode currentNode = head;
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
        /// <param name="node"></param>
        /// <param name="position">enter 0 to add to head</param>
        public void AddAt(int pos, object data)
        {
            SingleNode node = new SingleNode(data);

            if (head == null)
            {
                head = node;
            }
            else if(pos == 0)
            {
                node.next = head;
                head = node;
            }
            else
            {
                if (pos >= size)
                {
                    pos = size - 1;  //If there is one element in linked list, the head is at position 0 but size of the linked list is 1
                }

                SingleNode currentNode = head;
                int counter = 0;

                while(counter < pos)
                {
                    currentNode = currentNode.next;
                    counter++;
                }

                SingleNode temp = currentNode.next;
                currentNode.next = node;
                currentNode.next.next = temp;
            }
            size++;
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

            SingleNode currentNode = head;

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
        /// <param name="pos">enter 0 to remove the head</param>
        public void RemoveAt(int pos)
        {
            if (head == null)
            {
                return;
            }
            else if (pos == 0)
            {
                head = head.next;
            }
            else
            {
                if (pos >= size)
                {
                    pos = size - 1;  //If there is one element in linked list, the head is at position 0 but size of the linked list is 1
                }

                SingleNode currentNode = head;
                int counter = 0;

                while (counter < pos - 1)
                {
                    currentNode = currentNode.next;
                    counter++;
                }
                currentNode.next = currentNode.next.next;
            }
            size--;
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

            SingleNode currentNode = head;

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

            SingleNode currentNode = head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data?.ToString());
                currentNode = currentNode.next;
            }
        }
    }


    /**
    
     //I/P - Put below code in main for testing

            SingleLinkedList list = new SingleLinkedList();

            //Add
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.AddAt(2, 4);
            list.AddAt(7, 5);
            list.AddAt(0, 6);

            //Search
            list.SearchNode(4);

            //Remove
            list.Remove();
            list.RemoveAt(4);
            list.RemoveAt(10);
            list.RemoveAt(0);

            //Print list
            list.PrintList();

            //Size
            Console.WriteLine("Size: {0}", list.size.ToString());
     */
}
