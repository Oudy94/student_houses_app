using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.Models
{
    [Serializable]
    public class StudentManager
    {
        public Dictionary<string, Student> StudentsByEmail { get; set; }

        public StudentManager()
        {
            StudentsByEmail = new Dictionary<string, Student>();
        }

        public Student AddStudent(string name, string email)
        {
            if (StudentsByEmail.ContainsKey(email))
            {
                throw new Exception("A student with the same email already exists.");
            }

            Student student = new Student(name, email);
            StudentsByEmail.Add(email, student);
            return student;
        }
    }
}
