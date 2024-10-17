using System;
using System.Collections.Generic;

namespace RemoveDuplicatesFromList
{
    public class RemDuplicates
    {
        public static void Main(String[] args)
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(5);
            list.Add(2);
            list.Add(13);
            list.Add(2);
            list.Add(1);
            list.Add(4);
            list.Add(1);

            Console.WriteLine("Before removing duplicates");
            foreach(var item in list)
            {
                Console.Write(item + " ");
            }



            Console.WriteLine();
            Console.WriteLine();

            List<int> l = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        list.RemoveAt(j);
                        j--;
                    }
                }
            }


            Console.WriteLine("After removing duplicates");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Another way for removing duplicates");
            List<int> l1 = new List<int>();
            foreach (var item in list)
            {
                if (!l1.Contains(item))
                {
                    l1.Add(item);
                }
            }

            Console.WriteLine("After removing duplicates");
            foreach(var item in l1 )
            {
                Console.Write(item + " ");
            }

        }
    }
}
