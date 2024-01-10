using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.models
{
    public class Student
    {
        private static int nextId = 1;

        public int Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegistrationDate { get; }
        public List<TaskAssignment> Tasks { get; }

        public Student(string name, string email)
        {
            this.Id = nextId++;
            this.Name = name;
            this.Email = email;
            this.IsActive = true;
            this.RegistrationDate = DateTime.Now;
            this.Tasks = new List<TaskAssignment>();
        }

        public void AddTask(TaskAssignment task)
        {
            this.Tasks.Add(task);
        }

        public override string ToString()
        {
            return $"{this.Id}- {this.Name}";
        }
    }
}
