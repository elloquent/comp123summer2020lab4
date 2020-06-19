using System;

namespace comp123summer2020lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //instaniate object of type person
            Person rich = new Person("Richard", 39);

            //use say hello method with . accessor
            rich.sayhello();

            Console.ReadLine();


        }
    }
}
