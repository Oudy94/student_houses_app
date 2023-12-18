using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.models
{
    public class Task
    {
        public Days day;
        public TaskName taskName;
        public Student student;
        public bool Check {  get; set; }

        public Task (Student student, bool check, Days day, TaskName taskName)
        {
            this.student = student;
            this.Check = check;
            this.day = day;
            this.taskName = taskName;
        }
    }
}
