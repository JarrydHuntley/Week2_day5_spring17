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

        }
   
        public Person(string name, int age, string hometown)
        {
            this.name = name;
            this.age = age;
            this.hometown = hometown;
        }

        public Person(string name, int age, string hometown, string favFood)
        {
            this.name = name;
            this.age = age;
            this.hometown = hometown;
            this.favFood = favFood;
        }
    }
}
