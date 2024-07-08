using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Student
    {
        public string Name { get; set; }   
        public string Surname { get; set; }

        public Student(string n, string s)
        {
            Name = n;
            Surname = s;
        }
    }
}
