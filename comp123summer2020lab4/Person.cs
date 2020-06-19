using System;
using System.Collections.Generic;
using System.Text;

namespace comp123summer2020lab4
{
    class Person
    {
        // Private Instance Varible

        // Public Properties
        public string Name { get; set; }
        public int Age { get; set; }

        //contrctors
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //public method
        public void sayhello()
        {
            Console.WriteLine($"{Name} say hello to you");
        }
    }
}
