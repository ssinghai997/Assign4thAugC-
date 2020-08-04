using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkedListCSharp
{
    class SortExplore
    {
        static void Main()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(1, "This");
            sortedList.Add(2, "is");
            sortedList.Add(3, "my");
            sortedList.Add(4, "Sort");
            sortedList.Add(5, "method");
            sortedList.Add(6, "demo");
            Console.WriteLine("Elements of Sorted List are");
            foreach (KeyValuePair<int, string> item in sortedList)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            int sl1 = sortedList.IndexOfValue("Sort");
            Console.WriteLine("The index of 'Sort' is :{0}", sl1);
            
            Console.WriteLine("The sorted list can contain {0} elements", sortedList.Capacity);
            Console.WriteLine("Count of the key value pairs in the  SortedList is:{0}", sortedList.Count);
            Console.WriteLine("****Values of Sorted list****");
            foreach (string item2 in sortedList.Values)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine("**** keys of the SortedList****");
            foreach (int item3 in sortedList.Keys)
            {
                Console.WriteLine(item3);
            }
            Console.WriteLine("------------ContainsKey method-----------");
            bool a = sortedList.ContainsKey(9);
            Console.WriteLine("Contains Key:{0}", a);


            Console.WriteLine("--------ContainsValue method------------");
            bool b = sortedList.ContainsValue("my");
            Console.WriteLine("Contains the value: {0}", b);

            int key = sortedList.IndexOfKey(6);
            Console.WriteLine("The index of the key 6 is :{0}", key);
            int value = sortedList.IndexOfValue("demo");
            Console.WriteLine("The index of the value DEMO is:{0}", value);


            Console.WriteLine("Removing the element with key 6:{0}", sortedList.Remove(6));
            foreach (KeyValuePair<int, string> kv in sortedList)
            {
                Console.WriteLine(kv);
            }
            Console.WriteLine("Removing element from the index 2:");
            sortedList.RemoveAt(2);
            foreach (KeyValuePair<int, string> kp in sortedList)
            {
                Console.WriteLine(kp);
            }




            Console.Read();
        }
    }
}





