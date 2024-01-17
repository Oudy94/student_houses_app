using student_houses_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.Models
{
    [Serializable]
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

        public Agreement AddAgreement(List<Student> students, string agreementDesc)
        {
            Agreement newAgreement = new Agreement(students, agreementDesc);
            agreements.Add(newAgreement);
            return newAgreement;
        }
    }
}
