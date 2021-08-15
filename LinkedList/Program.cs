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

            //Display Data Before Delete First element 
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Display Data Before Delete First element ::");
            Console.WriteLine("-----------------------------------------------");
            linkedList.Display();

            //Delete First Element
            linkedList.POP();

            //Display Data After Delete First element 
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Display Data After Delete First element ::");
            Console.WriteLine("-----------------------------------------------");

            linkedList.Display();
        }
    }
}