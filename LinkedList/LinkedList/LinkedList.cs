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
        internal void AddAtFirst(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
                Console.WriteLine("{0} inserted into the linked list", node.data);
            }
            else
            {
                node.next = head;
                head = node;

                Console.WriteLine("{0} inserted into the linked list", node.data);
            }
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next; //temp=null
            }
        }



        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.AddAtFirst(70);
            list.AddAtFirst(30);
            list.AddAtFirst(56);
            list.Display();


        }
    }
}
