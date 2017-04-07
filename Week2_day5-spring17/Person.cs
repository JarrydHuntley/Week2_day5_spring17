using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day5_spring17
{
    class Person
    {
        public string name;
        public int age;
        public string hometown;
        public string favFood;

        public Person()
        {
            this.name = "John Doe";
        }
   
        public Person(string name, int age, string hometown)
        {
            this.name = name;
            this.age = age;
            this.hometown = hometown;
            this.favFood = "[Not entered]";
        }

        public Person(string name, int age, string hometown, string favFood)
        {
            this.name = name;
            this.age = age;
            this.hometown = hometown;
            this.favFood = favFood;
        }

        public void Greeting()
        {
            Console.WriteLine("Hello, my name is " + name);
            Console.WriteLine("I'm " + age + " and I'm from " + hometown);
            Console.WriteLine("My favorite food is " + favFood);
            Console.WriteLine();
        }
    }
}
