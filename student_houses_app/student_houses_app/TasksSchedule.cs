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
    public partial class TasksSchedule : UserControl
    {
        public Main Main { get; set; }
        public DataTable Dt { get; set; }
        public Dictionary<Point, TaskAssignment> CellToTaskInfoMap { get; }
        public int weekIndex { get; set; }

        public TasksSchedule(Main main)
        {
            InitializeComponent();

            this.Main = main;
            this.weekIndex = 0;

            this.Dt = new DataTable("tasks");
            this.CellToTaskInfoMap = new Dictionary<Point, TaskAssignment>();

            CreateTaskScheduleTable();
        }

        public void CreateTaskScheduleTable()
        {
            this.Dt.Clear();
            this.Dt.Columns.Clear();
            this.Dt = new DataTable("tasks");

            DataSet ds = new DataSet("student_house");

            this.Dt.Columns.Add("Day");

            foreach (TaskInformation taskInfo in this.Main.MC.TaskManager.TasksInformation)
            {
                this.Dt.Columns.Add(taskInfo.Name);
            }

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
            foreach (DataGridViewRow row in dgvSchedule.Rows)
            {
                for (int columnIndex = 1; columnIndex < dgvSchedule.Columns.Count; columnIndex++)
                {
                    row.Cells[columnIndex].Value = null;
                }
            }

            foreach (TaskAssignment task in tasks)
            {
                if (task.Status != TaskInfoStatus.Canceled)
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
        }

        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 1 && e.ColumnIndex <= this.Main.MC.TaskManager.TasksInformation.Count)
            {
                Point cellCoordinates = new Point(e.ColumnIndex, e.RowIndex);

                if (this.CellToTaskInfoMap.TryGetValue(cellCoordinates, out TaskAssignment task))
                {
                    TaskViewStudent taskViewStudent = new TaskViewStudent(task);
                    taskViewStudent.FormClosing += taskViewStudent_FormClosing;
                    taskViewStudent.ShowDialog();
                }
            }
        }

        private void taskViewStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            AddTasksToSchedule(this.Main.MC.TaskManager.GetTasksForWeek(weekIndex));
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dgvSchedule.SelectedCells)
            {
                if (cell.ColumnIndex < 1 || cell.ColumnIndex > this.Main.MC.TaskManager.TasksInformation.Count)
                {
                    cell.Selected = false;
                }
            }
        }

        private void dgvSchedule_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 1 && e.ColumnIndex <= this.Main.MC.TaskManager.TasksInformation.Count)
            {
                dgvSchedule.Cursor = Cursors.Hand;
            }
        }

        private void dgvSchedule_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvSchedule.Cursor = Cursors.Default;
        }

        private void btnCurrentWeek_Click(object sender, EventArgs e)
        {
            weekIndex = 0;
            AddTasksToSchedule(this.Main.MC.TaskManager.GetTasksForWeek(weekIndex));
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            weekIndex++;
            AddTasksToSchedule(this.Main.MC.TaskManager.GetTasksForWeek(weekIndex));
        }

        private void btnPreviousWeek_Click(object sender, EventArgs e)
        {
            weekIndex--;
            AddTasksToSchedule(this.Main.MC.TaskManager.GetTasksForWeek(weekIndex));
        }
    }
}
