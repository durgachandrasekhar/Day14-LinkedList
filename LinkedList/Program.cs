using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome Message
            Console.WriteLine("Welcome To Linked List !");
            Console.WriteLine("-----------------------------------------------");

            //Object of Class Sorte LinkedList
            SortedLinkedList sortedLinkedList = new SortedLinkedList();
            sortedLinkedList.Add(56);
            sortedLinkedList.Add(30);
            sortedLinkedList.Add(40);
            sortedLinkedList.Add(70);

            Console.WriteLine("Ordered Linked List in Ascending Order ::");
            Console.WriteLine("-----------------------------------------");

            sortedLinkedList.Display();
            

        }
    }
}