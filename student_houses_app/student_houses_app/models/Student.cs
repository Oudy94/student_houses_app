using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.models
{
    public class Student
    {
        public string Name {  get; set; }
        public string Email { get; set; }
        public int Id { get; private set; }

       
        public Student(string name, string email, int id)
        {
            this.Name = name;
            this.Email = email;
            this.Id = id;
        }

    }
}
