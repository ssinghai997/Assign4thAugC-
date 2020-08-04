using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LinkedListCSharp
{
    class LinkedListExplore
    {
        static void Main()
        {
            LinkedList<string> List1 = new LinkedList<string>();
            List1.AddLast("item1");
            List1.AddLast("item2");
            List1.AddLast("item3");
            List1.AddLast("item4");
            List1.AddLast("item5");

            Console.WriteLine("Adding item6 at the first node using AddFirst()");
            List1.AddFirst("item6");
            LinkedListNode<string> n1 = List1.Find("item1");
            LinkedListNode<string> var1 = List1.AddAfter(n1, "item x");
            List1.AddBefore(var1, "item y");

            foreach (string str in List1)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Iteration using GetEnumerator method");
            LinkedList<string>.Enumerator lle = List1.GetEnumerator();
            while (lle.MoveNext())
            {
                Console.WriteLine(lle.Current);
                
            }
            Console.WriteLine("****Contains Method****");
            bool ht = List1.Contains("item3");
            Console.WriteLine(ht);

            Console.WriteLine("--------Using CopytTo method------------");
            string[] arr = new string[List1.Count];
            List1.CopyTo(arr, 0);
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
            
            bool rem = List1.Remove("item5");
            Console.WriteLine("Removing Element from the linked list:{0}", rem);
            foreach (string show in List1)
            {
                Console.WriteLine(show);
            }
            Console.WriteLine("Removing the starting node from the linked list");
            List1.RemoveFirst();
            foreach (string rem1 in List1)
            {
                Console.WriteLine(rem1);
            }
            Console.WriteLine("Removing the node at the last from the linked list");
            List1.RemoveLast();
            foreach (string disp in List1)
            {
                Console.WriteLine(disp);
            }
            
            Console.Read();



        }
    }
}
