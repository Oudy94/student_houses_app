using student_houses_app.models;
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
    public partial class StudentSettings : UserControl
    {
        public StudentManager StudentManager { get; }

        public StudentSettings(StudentManager studentManager)
        {
            InitializeComponent();

            this.StudentManager = studentManager;

            foreach (Student student in this.StudentManager.StudentsDict.Values)
            {
                lstStudents.Items.Add(student);
            }
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                lblStudentRegisteredDate.Text = "";
                txtStudentEmail.Text = "";
                cmbStudentActivity.SelectedIndex = 0;
                lstStudentTasks.SelectedItems.Clear();
                return;
            }

            Student student = (Student)lstStudents.SelectedItem;
            lblStudentRegisteredDate.Text = student.RegistrationDate.ToString("MM/dd/yyyy");
            txtStudentEmail.Text = student.Email;
            cmbStudentActivity.SelectedIndex = student.IsActive ? 0 : 1;
            lstStudentTasks.SelectedItems.Clear();
            foreach (TaskAssignment task in student.Tasks)
            {
                lstStudentTasks.Items.Add(task.TaskInfo);
                lstStudentTasks.DisplayMember = "Name";
            }
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select a student");
                return;
            }

            Student student = (Student)lstStudents.SelectedItem;
            string studentEmail = txtStudentEmail.Text;
            bool studentActivity = cmbStudentActivity.SelectedIndex == 0 ? true : false;
            if (string.IsNullOrWhiteSpace(studentEmail))
            {
                MessageBox.Show("Student email cannot be empty");
                return;
            }

            student.Email = studentEmail;
            student.IsActive = studentActivity;
            MessageBox.Show("Student information updated successfully.");
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string studentName = txtAddStudentName.Text;
            string studentEmail = txtAddStudentEmail.Text;

            if (string.IsNullOrWhiteSpace(studentName) || string.IsNullOrWhiteSpace(studentEmail))
            {
                MessageBox.Show("Student name or email cannot be empty");
                return;
            }

            Student newStudent = StudentManager.AddStudent(studentName, studentEmail);
            lstStudents.Items.Add(newStudent);
            MessageBox.Show("Student added successfully.");
        }
    }
}
