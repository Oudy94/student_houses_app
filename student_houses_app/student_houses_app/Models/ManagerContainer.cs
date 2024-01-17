using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.Models
{
    [Serializable]
    public class ManagerContainer
    {
        public StudentManager StudentManager { get; }
        public TaskManager TaskManager { get; }
        public AgreementManager AgreementManager { get; }
        public ComplaintManager ComplaintManager { get; }

        public ManagerContainer()
        {
            StudentManager = new StudentManager();
            TaskManager = new TaskManager();
            AgreementManager = new AgreementManager();
            ComplaintManager = new ComplaintManager();
        }

    }
}
