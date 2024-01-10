using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.models
{
    public class StudentManager
    {
        private Dictionary<string, Student> studentsDict;

        public Dictionary<string, Student> StudentsDict
        {
            get { return studentsDict; }
        }

        public StudentManager()
        {
            studentsDict = new Dictionary<string, Student>();
        }

        public Student AddStudent(string name, string email)
        {
            if (studentsDict.ContainsKey(name))
            {
                throw new Exception("A student with the same name already exists.");
            }

            Student student = new Student(name, email);
            studentsDict.Add(name, student);
            return student;
        }
    }
}
