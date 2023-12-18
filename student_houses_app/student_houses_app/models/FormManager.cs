using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.models
{
    public class FormManager
    {
        public List<Form> parties = new List<Form>();
        public List<Form> complaints = new List<Form>();

        public void AddParty(Form form)
        {
            int verify = 1;

            foreach (Form p in this.parties)
                if (p == form) verify = 0;

            if (verify == 1) this.parties.Add(form);
            else MessageBox.Show("Already added this party");

        }

        public void AddComplaint(Form form)
        {
            int verify = 1;

            foreach (Form c in this.complaints)
                if (c == form) verify = 0;

            if (verify == 1) this.complaints.Add(form);
            else MessageBox.Show("Already added this complaint");
        }
    }
}
