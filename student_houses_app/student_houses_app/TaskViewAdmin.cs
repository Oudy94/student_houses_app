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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace student_houses_app
{
    public partial class TaskViewAdmin : Form
    {
        public Main Main { get; set; }
        private TaskAssignment Task { get; set; }
        public TaskViewAdmin(Main main, TaskAssignment task)
        {
            InitializeComponent();

            this.Main = main;
            this.Task = task;

            txtTaskId.Text = this.Task.Id.ToString();
            foreach (Student student in this.Main.MC.StudentManager.StudentsByEmail.Values)
            {
                cmbTaskStudent.Items.Add(student);
            }
            foreach (TaskInformation taskInfo in Main.MC.TaskManager.TasksInformation)
            {
                cmbTaskInfo.Items.Add(taskInfo);
            }
            dtpTaskDate.Value = task.Date;
            foreach (TaskInfoStatus status in Enum.GetValues(typeof(TaskInfoStatus)))
            {
                cmbTaskStatus.Items.Add(status);
            }

            cmbTaskStudent.SelectedItem = task.Student;
            cmbTaskInfo.SelectedItem = task.TaskInfo;
            cmbTaskStatus.SelectedItem = task.Status;
            txtIncompleteReason.Text = task.UnableToCompleteReason;
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskId.Text)
               || cmbTaskStudent.SelectedIndex == -1
               || cmbTaskInfo.SelectedIndex == -1
               || cmbTaskStatus.SelectedIndex == -1)

            {
                MessageBox.Show("Make sure all your values are correct.");
                return;
            }

            TaskInformation taskInfo = (TaskInformation)cmbTaskInfo.SelectedItem;
            Student student = (Student)cmbTaskStudent.SelectedItem;
            DateTime date = dtpTaskDate.Value;

            foreach (TaskAssignment task in this.Main.MC.TaskManager.Tasks)
            {
                if (task.TaskInfo == taskInfo && task.Date == date && task.Status != TaskInfoStatus.Canceled)
                {
                    MessageBox.Show("There is already the same task in the same day.");
                    return;
                }
            }

            Task.Student = student;
            Task.TaskInfo = taskInfo;
            Task.Date = date;
            Task.Status = (TaskInfoStatus)cmbTaskStatus.SelectedItem;

            MessageBox.Show("Task updated successfully.");
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you really want to delete this task?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Main.MC.TaskManager.Tasks.Remove(Task);
                this.Close();
            }
        }
    }
}
