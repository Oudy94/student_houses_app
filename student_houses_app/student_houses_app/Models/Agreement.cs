using student_houses_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.Models
{
    [Serializable]
    public class Agreement
    {
        private static int nextId = 1;

        public int Id { get; }

        public List<Student> Students { get; set; }
        public string AgreementDesc { get; set; }
        public DateTime CreatedDate { get; }
        public bool IsActive { get; set; }

        public Agreement(List<Student> students, string agreementDesc)
        {
            this.Id = nextId++;
            this.Students = students;
            this.AgreementDesc = agreementDesc;
            this.CreatedDate = DateTime.Now;
            this.IsActive = true;
        }
    }
}
