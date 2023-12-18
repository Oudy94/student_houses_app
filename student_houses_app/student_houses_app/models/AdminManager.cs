using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.models
{
    public class AdminManager
    {
        public List<Admin> admins = new List<Admin>();

        public void addAdmin(Admin admin)
        {
            int verify = 1;

            foreach (Admin a in this.admins)
                if (a == admin) verify = 0;

            if (verify == 1) this.admins.Add(admin);
            else MessageBox.Show("Already added this admin");
        }

    }
}
