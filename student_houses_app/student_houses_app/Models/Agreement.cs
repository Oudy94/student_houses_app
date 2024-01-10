using student_houses_app.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.Models
{
    public class Agreement
    {
        private static int nextId = 1;

        public int Id { get; }
        public Student StudentA { get; }
        public Student StudentB { get; }
        public string AgreementDesc { get; set; }
        public DateTime CreatedDate { get; }

        public Agreement(Student studentA, Student studentB, string agreementDesc)
        {
            this.Id = nextId++;
            this.StudentA = studentA;
            this.StudentB = studentB;
            this.AgreementDesc = agreementDesc;
            this.CreatedDate = DateTime.Now;
        }
    }
}
