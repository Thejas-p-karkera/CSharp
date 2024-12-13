using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_3
{
    class LinkedList
    {
        static void addFront(LinkedList<int> linkedList)
        {
            Console.Write("Enter the element to insert at front of the list: ");
            int ele = int.Parse(Console.ReadLine());

            linkedList.AddFirst(ele);
        }

        static void addBack(LinkedList<int> linkedList)
        {
            Console.Write("Enter the element to insert at Back of the list: ");
            int ele = int.Parse(Console.ReadLine());

            linkedList.AddLast(ele);
        }

        static void deleteANode(LinkedList<int> linkedList)
        {
            Console.Write("Enter the element you want to delete from the list: ");
            int ele = int.Parse(Console.ReadLine());

            if(linkedList.Contains(ele))
        }

        static void displayList(LinkedList<int> linkedList)
        {
            if (linkedList.Count == 0)
            {
                Console.WriteLine("Empty stack");
            }

            Console.WriteLine("Stack elements are:");

            foreach (int st in linkedList)
            {
                Console.Write(st + "<-");
            }
            Console.WriteLine("NULL");

        }

        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            while (true)
            {
                Console.WriteLine("\n1. Add a Node to the Front of the list.");
                Console.WriteLine("2. Add a Node to the Back of the List.");
                Console.WriteLine("3. Delete a specified Node.");
                Console.WriteLine("4. Display the list.");
                Console.WriteLine("5. Exit.");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        pushStack(stack);
                        break;

                    case 2:
                        popStack(stack);
                        break;

                    case 3:
                        displayStack(stack);
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            }
        }
    }
}
