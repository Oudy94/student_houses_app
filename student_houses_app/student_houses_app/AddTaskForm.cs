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
    public partial class AddTaskForm : Form
    {
        public Main Main { get; set; }

        public AddTaskForm(Main main)
        {
            InitializeComponent();

            this.Main = main;

            txtTaskId.Text = TaskAssignment.nextId.ToString();
            foreach (Student student in this.Main.MC.StudentManager.StudentsByEmail.Values)
            {
                cmbTaskStudent.Items.Add(student);
            }
            foreach (TaskInformation taskInfo in this.Main.MC.TaskManager.TasksInformation)
            {
                cmbTaskInfo.Items.Add(taskInfo);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskId.Text)
               || cmbTaskStudent.SelectedIndex == -1
               || cmbTaskInfo.SelectedIndex == -1)

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

            this.Main.MC.TaskManager.AddTask(student, taskInfo, date);
            MessageBox.Show("Task added successfully.");
            this.Close();
        }
    }
}
