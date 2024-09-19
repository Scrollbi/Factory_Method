using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Course : Class_1
    {
        public string Name { get; set; }
        public int Teacher_Id { get; set; }
        public List<int> Students { get; set; } = new List<int>();

        public Course(int id, string name, int teacher_Id)
        {
            Id = id;
            Name = name;
            Teacher_Id = teacher_Id;
            
        }
        public override void Write()
        {
            using (StreamWriter sw = new StreamWriter("data.txt", true))
            {
                sw.WriteLine($"Course, Id: {Id}, Name: {Name}, Teacher_Id: {Teacher_Id}, Students: {string.Join("; ", Students)}");
            }
        }
    }
}
