using System;

namespace LinkedList
{
    class LinkedList
    {


        internal Node head;


        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.head = new Node(56);
            Node second = new Node(30);
            Node third = new Node(70);
            list.head.next = second;
            second.next = third;

        }
    }
}
