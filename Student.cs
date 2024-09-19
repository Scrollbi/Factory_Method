using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Student : Class_1
    {
        public string Name { get; set; }
        public List<int> Courses { get; set; } = new List<int>();

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
           
        }
        public override void Write()
        {
            using (StreamWriter sw = new StreamWriter("data.txt", true))
            {
                sw.WriteLine($"Student, Id: {Id}, Name: {Name}, Courses: {string.Join("; ", Courses)}");
            }
        }


    }
}
