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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace student_houses_app
{
    public partial class Main : Form
    {
        public StudentManager StudentManager { get; }
        public TaskManager TaskManager { get; }
        public AgreementManager AgreementManager { get; }
        public ComplaintManager ComplaintManager { get; }

        public Main()
        {
            InitializeComponent();

            this.StudentManager = new StudentManager();
            this.TaskManager = new TaskManager();
            this.AgreementManager = new AgreementManager();
            this.ComplaintManager = new ComplaintManager();

            //For test
            this.StudentManager.AddStudent("Saoud", "saoud@gmail.com");
            this.StudentManager.AddStudent("Catalin", "saoud@gmail.com");
            this.StudentManager.AddStudent("Nikolay", "saoud@gmail.com");
            this.StudentManager.AddStudent("John", "saoud@gmail.com");
            this.StudentManager.AddStudent("Doe", "saoud@gmail.com");
            this.TaskManager.AddTaskInformation("Cleaning", "", new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Wednesday, DayOfWeek.Friday });
            this.TaskManager.AddTaskInformation("Grocery", "", new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Thursday, DayOfWeek.Saturday });
            this.TaskManager.AddTaskInformation("Garbage", "", new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Sunday });

            MainUser mainUser = new MainUser(this);
            pnlMain.Controls.Add(mainUser);
        }

        public void OpenMainUser()
        {
            foreach (Control control in pnlMain.Controls)
            {
                control.Dispose();
            }
            pnlMain.Controls.Clear();

            MainUser mainUser = new MainUser(this);
            pnlMain.Controls.Add(mainUser);
        }

        public void OpenMainAdmin()
        {
            foreach (Control control in pnlMain.Controls)
            {
                control.Dispose();
            }
            pnlMain.Controls.Clear();

            MainAdmin mainAdmin = new MainAdmin(this);
            pnlMain.Controls.Add(mainAdmin);
        }
    }
}
