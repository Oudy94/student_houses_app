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
    public partial class TaskSettings : UserControl
    {
        public TaskManager TaskManager { get; }

        public TaskSettings(TaskManager taskManager)
        {
            InitializeComponent();

            this.TaskManager = taskManager;
            foreach (TaskInformation taskInfo in this.TaskManager.TasksInformation)
            {
                lstTasksInfo.Items.Add(taskInfo);
            }
            lstTasksInfo.DisplayMember = "Name";

            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                int adjustedIndex = ((int)day + 1) % 7;
                lstTaskDays.Items.Add((DayOfWeek)adjustedIndex);
                lstAddTaskDays.Items.Add((DayOfWeek)adjustedIndex);
            }
        }

        private void lstTasksInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasksInfo.SelectedIndex == -1)
            {
                lstTaskDays.SelectedItems.Clear();
                return;
            }

            TaskInformation taskInfo = (TaskInformation)lstTasksInfo.SelectedItem;

            List<int> indicesToSelect = new List<int>();
            lstTaskDays.SelectedItems.Clear();
            lstTaskDays.SelectionMode = SelectionMode.MultiSimple;

            foreach (object dayObj in lstTaskDays.Items)
            {
                if (taskInfo.Days.Contains((DayOfWeek)dayObj))
                {
                    int indexToSelect = lstTaskDays.Items.IndexOf(dayObj);
                    indicesToSelect.Add(indexToSelect);
                }
            }

            foreach (int index in indicesToSelect)
            {
                lstTaskDays.SetSelected(index, true);
            }

            txtTaskDescription.Text = taskInfo.Description;
        }

        private void lstTaskDays_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            TaskInformation taskInfo = (TaskInformation)lstTasksInfo.SelectedItem;
            List<DayOfWeek> days = lstTaskDays.SelectedItems.Cast<DayOfWeek>().ToList();

            taskInfo.Days = days;
            taskInfo.Description = txtTaskDescription.Text;
            MessageBox.Show("Task informaion updated successfully.");
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            List<DayOfWeek> days = lstAddTaskDays.SelectedItems.Cast<DayOfWeek>().ToList();

            if (days.Count > 0)
            {
                TaskInformation taskInfo = TaskManager.AddTaskInformation(txtAddTaskName.Text, lstAddTaskDescription.Text, days);
                lstTasksInfo.Items.Add(taskInfo);
                MessageBox.Show("Task added successfully.");
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            TaskInformation taskInfo = (TaskInformation)lstTasksInfo.SelectedItem;
            DialogResult result = MessageBox.Show($"Are you sure you want to remove '{taskInfo.Name}' task?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.TaskManager.RemoveTaskInformation(taskInfo);
                MessageBox.Show("Task deleted successfully.");
            }
        }
    }
}
