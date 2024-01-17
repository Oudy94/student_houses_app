using student_houses_app.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_houses_app.Models
{
    [Serializable]
    public class TaskManager
    {
        public List<TaskAssignment> Tasks { get; }
        public List<TaskInformation> TasksInformation { get; }

        [NonSerialized]
        private Random random;

        public TaskManager()
        {
            this.Tasks = new List<TaskAssignment>();
            this.TasksInformation = new List<TaskInformation>();
            this.random = new Random();
        }

        public TaskAssignment AddTask(Student student, TaskInformation taskInfo, DateTime date)
        {
            TaskAssignment newTask = new TaskAssignment(student, taskInfo, date);
            student.AddTask(newTask);
            this.Tasks.Add(newTask);

            return newTask;
        }

        public TaskInformation AddTaskInformation(string name, string description, List<DayOfWeek> days)
        {
            TaskInformation newTaskInfo = new TaskInformation(name, description, days);
            this.TasksInformation.Add(newTaskInfo);

            return newTaskInfo;
        }

        public void RemoveTaskInformation(TaskInformation taskInfo)
        {
            if (TasksInformation.Contains(taskInfo))
            {
                TasksInformation.Remove(taskInfo);
            }
        }

        public void SetTasksForTheWeek(StudentManager studentManager)
        {
            if (TasksInformation.Count == 0)
            {
                throw new Exception("There are no tasks to be assigned.");
            }

            if (studentManager.StudentsByEmail.Count == 0)
            {
                throw new Exception("Cannot set tasks while there are no students.");
            }

            List<Student> sortedStudents = studentManager.StudentsByEmail.Values
                .OrderBy(student => student.Tasks.Count(task => task.Date.Month == DateTime.Now.Month))
                .ToList();

            int totalTasksPerWeek = TasksInformation.Sum(taskInfo => taskInfo.Days.Count);

            if (totalTasksPerWeek < sortedStudents.Count)
            {
                sortedStudents.RemoveRange(totalTasksPerWeek, sortedStudents.Count - totalTasksPerWeek);
            }
            else if (totalTasksPerWeek > sortedStudents.Count)
            {
                int studentIndex = 0;

                while (sortedStudents.Count < totalTasksPerWeek)
                {
                    Student currentStudent = sortedStudents[studentIndex];
                    sortedStudents.Add(currentStudent);

                    studentIndex = (studentIndex + 1) % sortedStudents.Count;
                }
            }

            foreach (TaskInformation taskInfo in TasksInformation)
            {
                List<DayOfWeek> daysList = taskInfo.Days;
                foreach (DayOfWeek day in taskInfo.Days)
                {
                    int randomStudentIndex = this.random.Next(0, sortedStudents.Count);
                    Student student = sortedStudents[randomStudentIndex];
                    sortedStudents.RemoveAt(randomStudentIndex);

                    DateTime currentDate = DateTime.Now;
                    int daysUntilNextOccurrence = ((int)day == 0 ? 7 : (int)day) - (int)currentDate.DayOfWeek;
                    DateTime nextOccurrence = currentDate.AddDays(daysUntilNextOccurrence).Date;

                    AddTask(student, taskInfo, nextOccurrence);
                }
            }
        }

        public void SetTasksForTwoWeeks(StudentManager studentManager)
        {
            if (TasksInformation.Count == 0)
            {
                throw new Exception("There are no tasks to be assigned.");
            }

            if (studentManager.StudentsByEmail.Count == 0)
            {
                throw new Exception("Cannot set tasks while there are no students.");
            }

            List<Student> sortedStudents = studentManager.StudentsByEmail.Values
                .OrderBy(student => student.Tasks.Count(task => task.Date.Month == DateTime.Now.Month))
                .ToList();

            int totalTasksPerWeek = TasksInformation.Sum(taskInfo => (taskInfo.Days.Count)*3);

            if (totalTasksPerWeek < sortedStudents.Count)
            {
                sortedStudents.RemoveRange(totalTasksPerWeek, sortedStudents.Count - totalTasksPerWeek);
            }
            else if (totalTasksPerWeek > sortedStudents.Count)
            {
                int studentIndex = 0;

                while (sortedStudents.Count < totalTasksPerWeek)
                {
                    Student currentStudent = sortedStudents[studentIndex];
                    sortedStudents.Add(currentStudent);

                    studentIndex = (studentIndex + 1) % sortedStudents.Count;
                }
            }

            DateTime currentDate = DateTime.Now;

            for (int weekOffset = 0; weekOffset <= 2; weekOffset++)
            {
                DateTime weekStart = currentDate.AddDays(-((int)currentDate.DayOfWeek)).AddDays(7 * weekOffset);

                foreach (TaskInformation taskInfo in TasksInformation)
                {
                    List<DayOfWeek> daysList = taskInfo.Days;

                    foreach (DayOfWeek day in daysList)
                    {
                        int randomStudentIndex = this.random.Next(0, sortedStudents.Count);
                        Student student = sortedStudents[randomStudentIndex];
                        sortedStudents.RemoveAt(randomStudentIndex);

                        int daysUntilNextOccurrence = ((int)day - (int)currentDate.DayOfWeek + 7) % 7;
                        DateTime nextOccurrence = weekStart.AddDays(daysUntilNextOccurrence).Date;

                        AddTask(student, taskInfo, nextOccurrence);
                    }
                }
            }
        }

        public List<TaskAssignment> GetTasksForWeek(int weekIndex)
        {
            DateTime currentDate = DateTime.Now;

            int daysUntilMonday = (int)DayOfWeek.Monday - (int)currentDate.DayOfWeek;
            DateTime startOfWeek = currentDate.AddDays(daysUntilMonday + (7 * weekIndex)).Date;

            List<TaskAssignment> tasksForWeek = this.Tasks
                .Where(task => task.Date >= startOfWeek && task.Date < startOfWeek.AddDays(7))
                .ToList();

            return tasksForWeek;
        }
    }
}
