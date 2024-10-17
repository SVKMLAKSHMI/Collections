using System.Collections.Generic;
using System.Xml.Serialization;
namespace Linked1{
    public class Linked1
    {
        public static void Main(String[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            // adding item at the first
            // AddFirst()
            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            //linkedList.AddFirst(2);

            //adding items at the last
            // AddLast()
            linkedList.AddLast(30);
            linkedList.AddLast(40);
            linkedList.AddLast(10);

           

            // Find the node with value 30
            // Find()
            LinkedListNode<int> node = linkedList.Find(30);

            // Adding item before the node with value 30
            // AddBefore()
            // AddAfter()
            if (node != null)
            {
                linkedList.AddBefore(node, 3);
                linkedList.AddAfter(node, 300);
            }

            // finding item with value 10;
            // FindLast()
            LinkedListNode<int> node1 = linkedList.FindLast(10);
            if (node1 != null)
            {
                linkedList.AddBefore(node1, 1);
                linkedList.AddAfter(node1, 100);
            }

            foreach (var item in linkedList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            //Count the elements in the linkedlist
            Console.WriteLine("Count : " + linkedList.Count());

            // Contains()
            if (linkedList.Contains(1))
            {
                linkedList.AddLast(1000);
            }
            foreach(var item in linkedList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            // Clear()
            //Console.WriteLine("Before clear");
            //linkedList.Clear();
            //foreach (var item in linkedList)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("After clear");

            // Distinct()
            Console.WriteLine("Distinct items");
            var distinctLink = linkedList.Distinct();
            foreach (var link in distinctLink)
            {
                Console.Write(link + " ");

            }

            Console.WriteLine();

            // Reverse()
            Console.WriteLine("Reverse of a linkedList");
            var reverseLinkedList = linkedList.Reverse();
            foreach(var link in reverseLinkedList)
            {
                Console.Write(link + " ");
            }

            Console.WriteLine();

            // RemoveFirst()
            linkedList.RemoveFirst();
            // RemoveLast()
            linkedList.RemoveLast();
            Console.WriteLine("After removing first and last elements");
            foreach (var item in linkedList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            // finding middle element in the linkedlist
            Console.WriteLine("Middle element in the linked list");
            
            int count = linkedList.Count();
            int mid = count / 2;

            if (count % 2 == 0)
            {
                for (int i = count / 2 - 1; i <= count / 2; i++)
                {
                    Console.WriteLine("Middle element " + linkedList.ElementAt<int>(i));
                }



            }
            else
            {
                Console.WriteLine("Middle element: " + linkedList.ElementAt<int>(mid));
            }


            // Merging two linked lists

            Console.WriteLine("Merging two lists");
            LinkedList<int> l1 = new LinkedList<int>();
            l1.AddFirst(10);
            l1.AddLast(30);
            l1.AddLast(50);

            LinkedList<int> l2 = new LinkedList<int>();
            l2.AddFirst(20);
            l2.AddLast(40);
            l2.AddLast(60);

            LinkedList<int> l3 = new LinkedList<int>();
            foreach(var item in l1){
                l3.AddLast(item);
            }
            foreach(var item in l2)
            {
                l3.AddLast(item);
            }
            var sort = l3.Order();

            //List<int> sortedList = l3.ToList();
            //sortedList.Sort();
            foreach (var item in sort)
            {
                Console.Write(item + " ");
            }




        }
    }
}
