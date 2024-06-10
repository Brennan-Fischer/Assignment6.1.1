using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._1._1
{
    internal class SingleLinkedList
    {
        internal Node head;

        internal void AddHouse(Houses house)
        {
            Node newHouseNode = new Node(house);
            if (head == null)
            {
                head = newHouseNode;
                return;
            }
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newHouseNode;
        }
        internal void SearchHouse()
        {
            Console.WriteLine("Input House Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (head == null)
            {
                Console.WriteLine("No houses on list");
                return;
            }
            Node current = head;
            while (current != null)
            {
                if (current.House.Number == num)
                {
                    Console.WriteLine($"House found!");
                    Console.WriteLine("");
                    Console.WriteLine($"House number: {current.House.Number}");
                    Console.WriteLine($"Street: {current.House.Street}");
                    Console.WriteLine($"Type: {current.House.Type}");
                    Console.WriteLine("");
                    return;

                }
                else { current = current.Next; }
            }
            Console.WriteLine("No house with that number on the list");
            return;
        }
    }
}
