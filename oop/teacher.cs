using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class teacher : Person
    {
        public string TeacherId { get; set; }
        public string  Subject { get; set; }

        public teacher(string name, int age, string teacherid, string subject): base(name, age)
        {
            Name = name;
            Age = age;
            TeacherId = teacherid;
            Subject = subject;
        }
    }
}
