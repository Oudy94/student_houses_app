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
    public partial class MainAdmin : UserControl
    {
        public Main Main { get; }
        public TasksSchedule TasksSchedule { get; }
        public AgreementsList AgreementsList { get; }
        public ComplaintsList ComplaintsList { get; }
        public TaskSettings TaskSettings { get; }
        public StudentSettings StudentSettings { get; }

        public MainAdmin(Main main)
        {
            InitializeComponent();

            this.Main = main;

            this.TasksSchedule = new TasksSchedule(this.Main.TaskManager);
            this.AgreementsList = new AgreementsList(this.Main.AgreementManager, this.Main.StudentManager);
            this.ComplaintsList = new ComplaintsList(this.Main.ComplaintManager, this.Main.StudentManager);
            this.TaskSettings = new TaskSettings(this.Main.TaskManager);
            this.StudentSettings = new StudentSettings(this.Main.StudentManager);

            pnlMainAdmin.Controls.Add(this.TasksSchedule);
            this.TasksSchedule.AddTasksToSchedule(this.Main.TaskManager.GetTasksForWeek(0));
        }

        private void btnTasksSchedule_Click(object sender, EventArgs e)
        {
            pnlMainAdmin.Controls.Clear();
            pnlMainAdmin.Controls.Add(this.TasksSchedule);
            this.TasksSchedule.AddTasksToSchedule(this.Main.TaskManager.GetTasksForWeek(0));
        }

        private void btnAgreements_Click(object sender, EventArgs e)
        {
            pnlMainAdmin.Controls.Clear();
            pnlMainAdmin.Controls.Add(this.AgreementsList);
            this.AgreementsList.UpdateAgreementsList();
        }

        private void btnComplaintsList_Click(object sender, EventArgs e)
        {
            pnlMainAdmin.Controls.Clear();
            pnlMainAdmin.Controls.Add(this.ComplaintsList);
            this.ComplaintsList.UpdateComplaintsList();
        }

        private void btnTaskSettings_Click(object sender, EventArgs e)
        {
            pnlMainAdmin.Controls.Clear();
            pnlMainAdmin.Controls.Add(this.TaskSettings);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Main.OpenMainUser();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Main.TaskManager.SetTasksForTheWeek(this.Main.StudentManager);
            this.TasksSchedule.CreateTaskScheduleTable();
            this.TasksSchedule.AddTasksToSchedule(this.Main.TaskManager.GetTasksForWeek(0));
        }

        private void btnStudentSettings_Click(object sender, EventArgs e)
        {
            pnlMainAdmin.Controls.Clear();
            pnlMainAdmin.Controls.Add(this.StudentSettings);
        }
    }
}
