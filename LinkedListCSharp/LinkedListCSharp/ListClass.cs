using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCSharp
{
    class Person
    {
        int age;
        String fname;
        String lname;
        String city;

        public Person()
        {

        }
        public Person(int _age,string _fname, string _lname, string _city)
        {
            age = _age;
            fname = _fname;
            lname = _lname;
            city = _city;
                 
            

            
        }

        public void DisplayPerson()
        {
            Console.WriteLine("Age : {0}, first name: {1}, last name: {2}, City: {3}", age, fname, lname, city);

        }

    }
    class ListClass
    {
        static void Main()
        {
            List<int> Age = new List<int>();
            Age.Add(23);
            Age.Add(24);
            Age.Add(25);
            Age.Add(26);
            Age.Add(27);

            foreach (int item in Age)
            {
                Console.WriteLine(item);
            }

            Person P1 = new Person();
            P1.DisplayPerson();


        }
    }
}
