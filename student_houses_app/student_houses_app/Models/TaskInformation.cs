using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.Models
{
    public class TaskInformation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<DayOfWeek> Days { get; set; }

        public TaskInformation(string name, string description, List<DayOfWeek> days)
        {
            this.Name = name;
            this.Description = description;
            this.Days = days;
        }
    }
}
