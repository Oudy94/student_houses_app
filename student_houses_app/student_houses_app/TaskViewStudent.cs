using student_houses_app.Enums;
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
    public partial class TaskViewStudent : Form
    {
        private TaskAssignment Task { get; set; }
        public TaskViewStudent(TaskAssignment task)
        {
            InitializeComponent();

            this.Task = task;

            txtTaskId.Text = this.Task.Id.ToString();
            txtTaskInfo.Text = this.Task.TaskInfo.Name;
            txtTaskStudent.Text = this.Task.Student.Name;
            txtTaskDate.Text = this.Task.Date.ToString("dd/MM/yyyy");
            txtTaskStatus.Text = this.Task.Status.ToString();

            if (Task.Status == TaskInfoStatus.Completed)
            {
                btnCompleteTask.Text = "Undo Complete";
                btnCompleteTask.Click -= btnCompleteTask_Click;
                btnCompleteTask.Click += btnUndoCompleteTask_Click;
            }
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            Task.Status = TaskInfoStatus.Completed;

            CompleteTaskDialog completeTaskDialog = new CompleteTaskDialog();
            completeTaskDialog.ShowDialog();
            this.Close();
        }

        private void btnUndoCompleteTask_Click(object sender, EventArgs e)
        {
            Task.Status = TaskInfoStatus.Incomplete;

            MessageBox.Show("Task set as not completed yet.");
            this.Close();
        }

        private void btnSendExcuse_Click(object sender, EventArgs e)
        {
            Task.Status = TaskInfoStatus.UnableToComplete;
            Task.UnableToCompleteReason = txtUnableToComplete.Text;

            MessageBox.Show("Task set as Unable to complete.");
            this.Close();
        }
    }
}
