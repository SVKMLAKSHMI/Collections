using System.Collections.Generic;
namespace LinkedList1{
    public class LinkedList1{
        public static void Main(String[] args){

            QueueUsingLinkedList<int> q = new QueueUsingLinkedList<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            Console.Write("Display all elements in the queue: ");
            q.DisplayElements();
            Console.WriteLine();

            Console.Write("Count: ");
            int count = q.Count();
            Console.WriteLine(count);
            Console.WriteLine();

            Console.WriteLine("Dequeue one after another");
            for(int i=0; i<count; i++){
                q.Dequeue();
            }
            
        }
    }

    public class QueueUsingLinkedList<T>{

        LinkedList<T> list = new LinkedList<T>();

        public void Enqueue(T item){
            list.AddLast(item);
        }

        public void DisplayElements(){
            foreach(var item in list){
                Console.Write(item+" ");
            }
        }

        public void Dequeue(){
            T value = list.First.Value;
            Console.WriteLine(value);
            list.RemoveFirst();
        }

        public int Count(){
            return list.Count();
        }
    }
}