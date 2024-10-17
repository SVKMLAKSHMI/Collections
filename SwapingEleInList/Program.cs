using System;
using System.Collections.Generic;

namespace SwapingEleInList
{
    public class SwappingEleInList
    {
        public static void Main(String[] args)
        {
            List<int> intList = new List<int>() { 1, 2, 3, 4 };
            
            Console.Write("Elements before swaping: ");
            Display<int>(intList);


            Console.WriteLine();
            Console.WriteLine();


            Console.Write("Elements after swaping: ");
            SwapEle(intList, 0, 3);
            Display<int>(intList);
        }

        public static void SwapEle<T>(List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        public static void Display<T>(List<T> list)
        {
            foreach(var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
