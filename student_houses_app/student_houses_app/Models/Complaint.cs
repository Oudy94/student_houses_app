using student_houses_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.Models
{
    [Serializable]
    public class Complaint
    {
        private static int nextId = 1;

        public int Id { get; }
        public Student Student { get; }
        public string ComplaintDesc { get; set; }
        public DateTime CreatedDate { get; }

        public Complaint(Student student, string complaintDesc)
        {
            this.Id = nextId++;
            this.Student = student;
            this.ComplaintDesc = complaintDesc;
            this.CreatedDate = DateTime.Now;
        }
    }
}
