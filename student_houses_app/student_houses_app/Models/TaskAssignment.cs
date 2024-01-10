using student_houses_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace student_houses_app.models
{
    public class TaskAssignment
    {
        private static int nextId = 1;

        public int Id { get; }
        public Student Student { get; }
        public TaskInformation TaskInfo { get; }
        public DateTime Date { get; }
        public bool IsCompleted { get; set; }

        public TaskAssignment(Student student, TaskInformation taskInfo, DateTime date)
        {
            this.Id = nextId++;
            this.Student = student;
            this.TaskInfo = taskInfo;
            this.Date = date;
        }

        public override string ToString()
        {
            return IsCompleted ? $"{Student.Name} ✓" : $"{Student.Name}";
        }

        public string GetInfo()
        {
            return IsCompleted ? $"{Student.Name} ✓" : $"{Student.Name}";
        }
    }
}
