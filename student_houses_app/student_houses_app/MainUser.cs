using student_houses_app.models;
using student_houses_app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_houses_app
{
    public partial class MainUser : UserControl
    {
        Main Main { get; }
        public TasksSchedule TasksSchedule { get; }
        public AgreementsList AgreementsList { get; }

        public MainUser(Main main)
        {
            InitializeComponent();

            this.Main = main;

            this.TasksSchedule = new TasksSchedule(this.Main.TaskManager);
            this.AgreementsList = new AgreementsList(this.Main.AgreementManager, this.Main.StudentManager);

            pnlMainUser.Controls.Add(this.TasksSchedule);
            this.TasksSchedule.AddTasksToSchedule(this.Main.TaskManager.GetTasksForWeek(0));
        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin(this.Main);
            loginForm.ShowDialog();
        }

        private void btnTasksSchedule_Click(object sender, EventArgs e)
        {
            pnlMainUser.Controls.Clear();
            pnlMainUser.Controls.Add(this.TasksSchedule);
            this.TasksSchedule.AddTasksToSchedule(this.Main.TaskManager.GetTasksForWeek(0));
        }

        private void btnAgreements_Click(object sender, EventArgs e)
        {
            pnlMainUser.Controls.Clear();
            pnlMainUser.Controls.Add(this.AgreementsList);
            this.AgreementsList.UpdateAgreementsList();
        }

        private void btncomplaint_Click(object sender, EventArgs e)
        {
            ComplaintForm complaintForm = new ComplaintForm(this.Main.ComplaintManager, this.Main.StudentManager);
            complaintForm.ShowDialog();
        }
    }
}
