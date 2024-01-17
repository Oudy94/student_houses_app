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
        public TaskListControl TaskListControl { get; }
        public ImportExportControl ImportExportControl { get; }

        public MainAdmin(Main main)
        {
            InitializeComponent();

            this.Main = main;

            this.TasksSchedule = new TasksSchedule(this.Main);
            this.AgreementsList = new AgreementsList(this.Main);
            this.ComplaintsList = new ComplaintsList(this.Main);
            this.TaskSettings = new TaskSettings(this.Main.MC.TaskManager);
            this.StudentSettings = new StudentSettings(this.Main.MC.StudentManager);
            this.TaskListControl = new TaskListControl(this.Main);
            this.ImportExportControl = new ImportExportControl(this.Main);

            pnlMainAdmin.Controls.Add(this.TasksSchedule);
            this.TasksSchedule.AddTasksToSchedule(this.Main.MC.TaskManager.GetTasksForWeek(this.TasksSchedule.weekIndex));
        }

        private void btnTasksSchedule_Click(object sender, EventArgs e)
        {
            pnlMainAdmin.Controls.Clear();
            pnlMainAdmin.Controls.Add(this.TasksSchedule);
            this.TasksSchedule.AddTasksToSchedule(this.Main.MC.TaskManager.GetTasksForWeek(this.TasksSchedule.weekIndex));
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
            this.TasksSchedule.CreateTaskScheduleTable();
            this.TasksSchedule.AddTasksToSchedule(this.Main.MC.TaskManager.GetTasksForWeek(this.TasksSchedule.weekIndex));
        }

        private void btnStudentSettings_Click(object sender, EventArgs e)
        {
            pnlMainAdmin.Controls.Clear();
            pnlMainAdmin.Controls.Add(this.StudentSettings);
        }

        private void btnTasksList_Click(object sender, EventArgs e)
        {
            pnlMainAdmin.Controls.Clear();
            pnlMainAdmin.Controls.Add(this.TaskListControl);
        }

        private void btnSetTasks_Click(object sender, EventArgs e)
        {
            this.Main.MC.TaskManager.SetTasksForTwoWeeks(this.Main.MC.StudentManager);
        }

        private void btnImportExport_Click(object sender, EventArgs e)
        {
            pnlMainAdmin.Controls.Clear();
            pnlMainAdmin.Controls.Add(this.ImportExportControl);
        }
    }
}
