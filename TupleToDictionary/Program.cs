using System;
using System.Collections.Generic;
namespace TupleToDictionary
{
    public class TupleDictionary
    {
        public static void Main(String[] args)
        {
            //Dictionary creation
            Dictionary<object, object> dict = new Dictionary<object, object>();

            //Tuple creation
            Tuple<int, string, double, float, int, string> tup = new Tuple<int, string, double, float, int, string>(234, "Maha", 23.0, 20.0f, 65, "Surya");

            dict.Add(tup.Item1, tup.Item2);
            dict.Add(tup.Item3, tup.Item4);
            dict.Add(tup.Item5, tup.Item6);

            foreach(var item in dict)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Chatgpt");
            Console.WriteLine("Single tuple to dictionary");
            Tuple<int, string> tup1 = Tuple.Create(1, "Maha");

            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1.Add(tup1.Item1, tup1.Item2);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("List of tuples to dictionary");
            Dictionary<int, string> dict2 = new Dictionary<int, string>();
            List<(int, string)> tup2 = new List<(int, string)>()
            {
                (234,"Maha"),
                (65,"Swarna"),
                (34,"Surya")
            };

            foreach(var item in tup2)
            {
                dict2.Add(item.Item1,item.Item2);
            }

            foreach(var item in dict2)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
