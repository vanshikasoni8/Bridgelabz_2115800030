//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2feb
//{
//    internal class Person
//    {
//        private string Name { get; set; }
//        private int Age { get; set; }

//        // Parameterized Constructor
//        public Person(string name, int age)
//        {
//            Name = name;
//            Age = age;
//        }

//        // Copy Constructor
//        public Person(Person other)
//        {
//            Name = other.Name;
//            Age = other.Age;
//        }

//        // Display Method
//        public void Display()
//        {
//            Console.WriteLine($"Name: {Name}, Age: {Age}");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            // Creating an original Person object
//            Person person1 = new Person("Alice", 25);
//            person1.Display();

//            // Using Copy Constructor
//            Person person2 = new Person(person1);
//            person2.Display();
//        }
//    }
//}
