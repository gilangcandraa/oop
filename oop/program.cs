using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class program
    {
        static void Main(string[] args)
        {
            Person person = new Person("aldi", 20);
         
            person.GetNameandAge();

            teacher teacher = new teacher("paijo", 30, "1234", "Math");
            teacher.GetNameandAge();

            student student = new student("Sara", 10, "2121", "qweqwe.com");
            student.GetNameandAge();

            Console.ReadKey();

        }
    }
}
