using student_houses_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.Models
{
    [Serializable]
    public class ComplaintManager
    {
        private List<Complaint> complaints;

        public List<Complaint> Complaints
        {
            get { return complaints; }
        }

        public ComplaintManager()
        {
            complaints = new List<Complaint>();
        }

        public Complaint AddComplaint(Student student, string complaintDesc)
        {
            Complaint newcomplaint = new Complaint(student, complaintDesc);
            complaints.Add(newcomplaint);
            return newcomplaint;
        }
    }
}
