using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetNameandAge()
        {
            Console.WriteLine(" The person has name : {0} and age : {1}", Name, Age);
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
