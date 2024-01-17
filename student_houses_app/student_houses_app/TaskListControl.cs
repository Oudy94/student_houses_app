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
    public partial class TaskListControl : UserControl
    {
        Main Main { get; set; }

        public TaskListControl(Main main)
        {
            InitializeComponent();

            this.Main = main;

            cmbFilterTask.Items.Add("All");
            cmbFilterStudent.Items.Add("All");
            cmbFilterStatus.Items.Add("All");

            cmbFilterTask.SelectedIndex = 0;
            cmbFilterStudent.SelectedIndex = 0;
            cmbFilterStatus.SelectedIndex = 0;

            foreach (TaskInformation taskInfo in this.Main.MC.TaskManager.TasksInformation)
            {
                cmbFilterTask.Items.Add(taskInfo);
            }
            foreach (Student student in this.Main.MC.StudentManager.StudentsByEmail.Values)
            {
                cmbFilterStudent.Items.Add(student);
            }
            foreach (TaskInfoStatus status in Enum.GetValues(typeof(TaskInfoStatus)))
            {
                cmbFilterStatus.Items.Add(status);
            }

            UpdateDgvTasksList();
        }

        public void UpdateDgvTasksList()
        {
            dgvTasksList.Rows.Clear();

            List<TaskAssignment> filteredTasks = cmbFilterTask.SelectedIndex > 0
                ? this.Main.MC.TaskManager.Tasks.Where(task => task.TaskInfo == (TaskInformation)cmbFilterTask.SelectedItem).ToList()
                : this.Main.MC.TaskManager.Tasks;

            if (cmbFilterStudent.SelectedIndex > 0)
            {
                filteredTasks = filteredTasks.Intersect(filteredTasks.Where(task => task.Student == (Student)cmbFilterStudent.SelectedItem)).ToList();
            }

            if (cmbFilterStatus.SelectedIndex > 0)
            {
                filteredTasks = filteredTasks.Intersect(filteredTasks.Where(task => task.Status == (TaskInfoStatus)cmbFilterStatus.SelectedItem)).ToList();
            }

            foreach (TaskAssignment task in filteredTasks)
            {
                int rowIndex = dgvTasksList.Rows.Add(task.Id, task.TaskInfo.Name, task.Student, task.Status.ToString(), task.Date.ToString("dd/MM/yyyy"));
                dgvTasksList.Rows[rowIndex].Tag = task;
            }
        }

        private void dgvTasksList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvTasksList.Columns["View"].Index)
            {
                DataGridViewRow clickedRow = dgvTasksList.Rows[e.RowIndex];

                if (clickedRow.Tag is TaskAssignment task)
                {
                    TaskViewAdmin taskViewAdmin = new TaskViewAdmin(this.Main, task);
                    taskViewAdmin.ShowDialog();
                }
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(this.Main);
            addTaskForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateDgvTasksList();
        }

        private void cmbFilterTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDgvTasksList();
        }

        private void cmbFilterStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDgvTasksList();
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDgvTasksList();
        }
    }
}
