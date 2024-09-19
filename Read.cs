using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class Read
    {
        public List<Student> ReadStudents()
        {
            List<Student> students = new List<Student>();
            using (StreamReader sr = new StreamReader("data.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("Student,"))
                    {
                        string[] parts = line.Split(',');
                        int id = int.Parse(parts[1].Trim().Split(':')[1]);
                        string name = parts[2].Trim().Split(':')[1];
                        List<int> courses = new List<int>();
                        string coursesStr = parts[3].Trim().Split(':')[1];
                        foreach (string courseStr in coursesStr.Split(';'))
                        {
                            courses.Add(int.Parse(courseStr.Trim()));
                        }
                        Student student = new Student(id, name);
                        student.Courses = courses;
                        students.Add(student);
                    }
                }
            }
            return students;
        }

        public List<Teacher> ReadTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            using (StreamReader sr = new StreamReader("data.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("Teacher,"))
                    {
                        string[] parts = line.Split(',');
                        int id = int.Parse(parts[1].Trim().Split(':')[1]);
                        int exp = int.Parse(parts[2].Trim().Split(':')[1]);
                        string name = parts[3].Trim().Split(':')[1];
                        List<int> courses = new List<int>();
                        string coursesStr = parts[4].Trim().Split(':')[1];
                        foreach (string courseStr in coursesStr.Split(';'))
                        {
                            courses.Add(int.Parse(courseStr.Trim()));
                        }
                        Teacher teacher = new Teacher(id, exp, name);
                        teacher.Courses = courses;
                        teachers.Add(teacher);
                    }
                }
            }
            return teachers;
        }

        public List<Course> ReadCourses()
        {
            List<Course> courses = new List<Course>();
            using (StreamReader sr = new StreamReader("data.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("Course,"))
                    {
                        string[] parts = line.Split(',');
                        int id = int.Parse(parts[1].Trim().Split(':')[1]);
                        string name = parts[2].Trim().Split(':')[1];
                        int teacherId = int.Parse(parts[3].Trim().Split(':')[1]);
                        List<int> students = new List<int>();
                        string studentsStr = parts[4].Trim().Split(':')[1];
                        foreach (string x in studentsStr.Split(';'))
                        {
                            students.Add(int.Parse(x.Trim()));
                        }
                        Course course = new Course(id, name, teacherId);
                        course.Students = students;
                        courses.Add(course);
                    }
                }
            }
            return courses;
        }
    }
}
