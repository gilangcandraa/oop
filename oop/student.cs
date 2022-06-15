using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class student : Person
    {
        public string StudentId { get; set; }
        public string Email { get; set; }

        public student(string name, int age, string studentid, string email): base(name, age)
        {
            Name = name;
            Age = age;
            StudentId = studentid;
            Email = email;
        }

    }
}
