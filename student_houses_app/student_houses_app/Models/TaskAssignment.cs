using student_houses_app.Enums;
using student_houses_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace student_houses_app.Models
{
    [Serializable]
    public class TaskAssignment
    {
        public static int nextId = 1;

        public int Id { get; }
        public Student Student { get; set; }
        public TaskInformation TaskInfo { get; set; }
        public DateTime Date { get; set; }
        public TaskInfoStatus Status { get; set; }
        public string UnableToCompleteReason { get; set; }

        public TaskAssignment(Student student, TaskInformation taskInfo, DateTime date)
        {
            this.Id = nextId++;
            this.Student = student;
            this.TaskInfo = taskInfo;
            this.Date = date;
            this.Status = TaskInfoStatus.Incomplete;
            this.UnableToCompleteReason = "";
        }

        public override string ToString()
        {
            return GetInfo(); 
        }

        public string GetInfo()
        {
            return Status == TaskInfoStatus.Completed ? $"{Student.Name} ✓" : $"{Student.Name}";

        }
    }
}
