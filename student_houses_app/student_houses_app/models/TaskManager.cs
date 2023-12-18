using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.models
{
    public class TaskManager
    {
        public List<Admin> tasks;

        public void addTask(Admin task)
        {
            int verify = 1;

            foreach (Admin t in this.tasks)
                if (t == task) verify = 0;

            if (verify == 1) this.tasks.Add(task);
            else MessageBox.Show("Already added this task");
        }

    }
}
