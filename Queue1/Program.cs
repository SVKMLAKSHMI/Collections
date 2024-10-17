using System;
using System.Collections.Generic;
namespace Queue1
{
    public class Queue1
    {
        public static void Main(String[] args)
        {
            //Queue<int> queue = new Queue<int>();
            //Console.WriteLine("Elements in the queue: ");
            //queue.Enqueue(100);
            //queue.Enqueue(2);
            //queue.Enqueue(30);

            //foreach (int i in queue)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.WriteLine();

            //Console.WriteLine("Dequeue each element at a time");
            //while (queue.Count > 0)
            //{
            //    Console.Write(queue.Dequeue() + " ");
            //}

            //var order = queue.Order();
            //foreach (var item in order)
            //{
            //    Console.Write(item + " ");
            //}






            QueueUsingLinkedList<int> queue = new QueueUsingLinkedList<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Peek at the front of the queue
            Console.WriteLine("Front element is: " + queue.Peek());

            //dequeue elements
            Console.WriteLine("Dequeued: " + queue.Dequeue());
            Console.WriteLine("Dequeued: " + queue.Dequeue());

            // check if the queue is empty
            Console.WriteLine("IS queue empty? " + queue.IsEmpty());

            // Dequeue remainin elements
            Console.WriteLine("Dequeued " + queue.Dequeue());

            // check again if the queue is empty
            Console.WriteLine("Is queue empty? "+queue.IsEmpty());
        }
    }

    public class QueueUsingLinkedList<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        // Enqueue : Add item to the end of the queue
        public void Enqueue(T item)
        {
            list.AddLast(item);
        }

        // Dequeue: Remove item from the front of the queue
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T value = list.First.Value; // get the value of the first node
            list.RemoveFirst();           // remove the first node
            return value;                   // return the dequeued value
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return list.First.Value;   // Return the value of the first node
        }

        // IsEmpty : check if the queue is empty
        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        // Count: Get the number of elementsin the queue
        public int Count()
        {
            return list.Count;
        }
    }


}
