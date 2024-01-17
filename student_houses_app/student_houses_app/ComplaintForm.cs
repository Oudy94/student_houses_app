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
    public partial class ComplaintForm : Form
    {
        public Main Main { get; set; }

        public ComplaintForm(Main main)
        {
            InitializeComponent();

            this.Main = main;

            cmbStudent.Items.Insert(0, "Anonymous");
            foreach (Student student in this.Main.MC.StudentManager.StudentsByEmail.Values)
            {
                cmbStudent.Items.Add(student);
            }
            cmbStudent.SelectedIndex = 0;
        }

        private void btnSubmitComplaint_Click(object sender, EventArgs e)
        {
            int selectedIndexStudent = cmbStudent.SelectedIndex;
            string complaintDescription = txtComplaint.Text;

            if (string.IsNullOrWhiteSpace(complaintDescription))
            {
                MessageBox.Show("Complaint description cannot be empty.");
                return;
            }

            this.Main.MC.ComplaintManager.AddComplaint(selectedIndexStudent > 0 ? (Student)cmbStudent.SelectedItem : null, complaintDescription);
            MessageBox.Show("Your complaint was sent successfully.");
            this.Close();
        }
    }
}
