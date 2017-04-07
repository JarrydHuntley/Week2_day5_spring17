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
            person1.Greeting();

            Console.WriteLine();

            Person person2 = new Person("Abby", 28, "NYC", "Ice Cream");
            person2.Greeting();
        }
    }
}
