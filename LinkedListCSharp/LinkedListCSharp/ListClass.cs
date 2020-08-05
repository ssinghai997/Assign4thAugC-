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
            
            List<Person> Persons = new List<Person>(); //Method I
            Person per1 = new Person(22, "Ron", "A", "Paris");
            Person per2 = new Person(23, "Todd", "B", "London");
            Person per3 = new Person(24, "Ray", "C", "Michigan");
            Person per4 = new Person(25, "Aron", "D", "NewYork");
            Person per5 = new Person(26, "sam", "E", "Sydney");

            Persons.Add(per1);
            Persons.Add(per2);
            Persons.Add(per3);
            Persons.Add(per4);
            Persons.Add(per5);


            var listPerson = new List<Person>   //Method II
            {
                new Person(21,"David", "Paul", "Mumbai"),
                new Person(22,"Todd", "B", "London" ),
                new Person(24, "Ray", "C", "Michigan")
            };

            foreach (Person p in Persons)
            {
                
                p.DisplayPerson();
            }
            foreach  (Person pp in listPerson)
            {
                pp.DisplayPerson();
            }


        }
    }
}
