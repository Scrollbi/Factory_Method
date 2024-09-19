using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Teacher : Class_1
    {
        public int Exp { get; set; }
        public string Name { get; set; }
        public List<int> Courses { get; set; } = new List<int>();

        public Teacher(int id, int exp, string name)
        {
            Id = id;
            Exp = exp;
            Name = name;
            
        }
        public override void Write()
        {
            using (StreamWriter sw = new StreamWriter("data.txt", true))
            {
                sw.WriteLine($"Teacher, Id: {Id}, Experience: {Exp}, Name: {Name}, Courses: {string.Join("; ", Courses)}");
            }
        }
    }
}
