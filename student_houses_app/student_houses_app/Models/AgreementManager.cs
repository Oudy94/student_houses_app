using student_houses_app.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.Models
{
    public class AgreementManager
    {
        private List<Agreement> agreements;

        public List<Agreement> Agreements
        {
            get { return agreements; }
        }

        public AgreementManager()
        {
            agreements = new List<Agreement>();
        }

        public Agreement AddAgreement(Student studentA, Student studentB, string agreementDesc)
        {
            Agreement newAgreement = new Agreement(studentA, studentB, agreementDesc);
            agreements.Add(newAgreement);
            return newAgreement;
        }
    }
}
