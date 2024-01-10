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
    public partial class TasksSchedule : UserControl
    {
        public TaskManager TaskManager { get; }
        public DataTable Dt { get; set; }
        public Dictionary<Point, TaskAssignment> CellToTaskInfoMap { get; }

        public TasksSchedule(TaskManager taskManager)
        {
            InitializeComponent();

            this.Dt = new DataTable("tasks");
            this.CellToTaskInfoMap = new Dictionary<Point, TaskAssignment>();

            this.TaskManager = taskManager;

            CreateTaskScheduleTable();
        }

        public void CreateTaskScheduleTable()
        {
            this.Dt.Clear();
            this.Dt.Columns.Clear();
            this.Dt = new DataTable("tasks");

            DataSet ds = new DataSet("student_house");

            this.Dt.Columns.Add("Day");

            foreach (TaskInformation taskInfo in this.TaskManager.TasksInformation)
            {
                this.Dt.Columns.Add(taskInfo.Name);
            }

            this.Dt.Columns.Add("Event");

            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                int adjustedIndex = ((int)day + 1) % 7;
                DataRow row = this.Dt.NewRow();
                row[0] = ((DayOfWeek)adjustedIndex).ToString();
                for (int i = 1; i < this.Dt.Columns.Count; i++)
                {
                    row[i] = DBNull.Value;
                }
                this.Dt.Rows.Add(row);
            }

            ds.Tables.Add(this.Dt);

            foreach (DataGridViewColumn column in dgvSchedule.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgvSchedule.DataSource = ds.Tables["tasks"];
        }

        public void AddTaskToSchedule(TaskAssignment task)
        {
            DataRow row = Dt.Select($"Day = '{task.Date.DayOfWeek.ToString()}'").FirstOrDefault();

            if (row != null)
            {
                int columnIndex = dgvSchedule.Columns[task.TaskInfo.Name].Index;
                int rowIndex = Dt.Rows.IndexOf(row);

                row[task.TaskInfo.Name] = task;
                this.CellToTaskInfoMap[new Point(columnIndex, rowIndex)] = task;
            }
        }

        public void AddTasksToSchedule(List<TaskAssignment> tasks)
        {
            foreach (TaskAssignment task in tasks)
            {
                DataRow row = Dt.Select($"Day = '{task.Date.DayOfWeek.ToString()}'").FirstOrDefault();

                if (row != null)
                {
                    int columnIndex = dgvSchedule.Columns[task.TaskInfo.Name].Index;
                    int rowIndex = Dt.Rows.IndexOf(row);

                    row[task.TaskInfo.Name] = task;
                    this.CellToTaskInfoMap[new Point(columnIndex, rowIndex)] = task;
                }
            }
        }

        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 1 && e.ColumnIndex <= this.TaskManager.TasksInformation.Count)
            {
                Point cellCoordinates = new Point(e.ColumnIndex, e.RowIndex);

                if (this.CellToTaskInfoMap.TryGetValue(cellCoordinates, out TaskAssignment task))
                {
                    DialogResult result = MessageBox.Show("Do you want to toggle the completion status of this task?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        task.IsCompleted = !task.IsCompleted;
                        dgvSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = task;
                        dgvSchedule.ClearSelection();
                    }
                }
            }
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dgvSchedule.SelectedCells)
            {
                if (cell.ColumnIndex < 1 || cell.ColumnIndex > this.TaskManager.TasksInformation.Count)
                {
                    cell.Selected = false;
                }
            }
        }

        private void dgvSchedule_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 1 && e.ColumnIndex <= this.TaskManager.TasksInformation.Count)
            {
                dgvSchedule.Cursor = Cursors.Hand;
            }
        }

        private void dgvSchedule_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvSchedule.Cursor = Cursors.Default;
        }
    }
}
