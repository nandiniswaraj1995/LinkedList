using System;

namespace LinkedList
{
    class LinkedList
    {


        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }


        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

           list.Add(70);
            list.Add(30);
            list.Add(56);
           

        }
    }
}
