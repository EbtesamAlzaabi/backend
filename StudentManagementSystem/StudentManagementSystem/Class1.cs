using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }

        public Student(int id, string name, string major)
        {
            ID = id;
            Name = name;
            Major = major;
        }
    }
}