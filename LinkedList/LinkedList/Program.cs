using System;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the linked list");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);

            list.Display();

            list.Insert(30);
            Console.WriteLine("list is : ");
            list.Display();

            //LinkedList linked = new LinkedList();
            //linked.Append(56);
            //linked.Append(30);
            //linked.Append(70);
            //Console.WriteLine("Appending 30 and 70 to 56 in LinkedList is: ");
            //linked.Display();


        }
    }
}
