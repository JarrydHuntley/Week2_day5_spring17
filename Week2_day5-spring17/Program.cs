using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day5_spring17
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Bob", 30, "Cleveland");
            Console.WriteLine(person1.name);
            Console.WriteLine(person1.favFood);

            Person person2 = new Person("Abby", 28, "NYC", "Ice Cream");
            Console.WriteLine(person2.name);
            Console.WriteLine(person2.favFood);
        }
    }
}
