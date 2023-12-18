using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.models
{
    public class Form
    {
        public Student student;
        public string description;
        public DateTime date;

        public Form (Student student, string description, DateTime date)
        {
            this.student = student;
            this.description = description;
            this.date = date;
        }

        public Form(string description, DateTime date)
        {
            this.description = description;
            this.date = date;
        }

    }
}
