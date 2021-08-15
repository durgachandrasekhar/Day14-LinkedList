using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome To Linked List !");

            //Calling Class LinkedList
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);

            //Searching an Element
            linkedList.SearchElement(30);
            Console.WriteLine("Data In Linked List");
            linkedList.Display();
        }
    }
}