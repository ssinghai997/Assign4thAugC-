using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lList = new LinkedList<string>(new string[] {"quick","fox","the","lazy"});
           var n = lList.AddFirst("the");
           var n1= lList.Find("quick");
            var n2=lList.AddAfter(n1, "brown");
            var l= lList.AddLast("fox");
            var f = lList.Find("fox");
            lList.AddAfter(f, "jumps");
            var fLast = lList.FindLast("the");
            lList.AddBefore(fLast, "over");
           



            foreach  (string str in lList)
            {
                Console.WriteLine(str);
            }
        }
    }

}


//the quick brown fox jumps over the lazy fox
