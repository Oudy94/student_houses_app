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
        public ManagerContainer MC { get; set; }

        public Main()
        {
            InitializeComponent();

            this.MC = new ManagerContainer();

            //For test
            this.MC.StudentManager.AddStudent("Saoud", "saoud@gmail.com");
            this.MC.StudentManager.AddStudent("Catalin", "Catalin@gmail.com");
            this.MC.StudentManager.AddStudent("Nikolay", "Nikolay@gmail.com");
            this.MC.StudentManager.AddStudent("John", "John@gmail.com");
            this.MC.StudentManager.AddStudent("Doe", "Doe@gmail.com");
            this.MC.TaskManager.AddTaskInformation("Cleaning", "", new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Wednesday, DayOfWeek.Friday });
            this.MC.TaskManager.AddTaskInformation("Grocery", "", new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Thursday, DayOfWeek.Saturday });
            this.MC.TaskManager.AddTaskInformation("Garbage", "", new List<DayOfWeek> { DayOfWeek.Tuesday, DayOfWeek.Sunday });

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
