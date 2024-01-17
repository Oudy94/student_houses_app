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
    public partial class AgreementForm : Form
    {
        public Main Main { get; set; }
        private AgreementsList agreementList;

        public AgreementForm(Main main, AgreementsList agreementList)
        {
            InitializeComponent();

            this.Main = main;
            this.agreementList = agreementList;

            foreach (Student student in this.Main.MC.StudentManager.StudentsByEmail.Values)
            {
                cmbStudents.Items.Add(student);
            }
        }

        private void btnSubmitAgreement_Click(object sender, EventArgs e)
        {
            string agreementDescription = txtAgreement.Text;

            if (lstStudents.Items.Count < 2)
            {
                MessageBox.Show("You have to add the students.");
                return;
            }

            if (string.IsNullOrWhiteSpace(agreementDescription))
            {
                MessageBox.Show("Agreement description cannot be empty.");
                return;
            }

            Agreement agreement = this.Main.MC.AgreementManager.AddAgreement(lstStudents.Items.Cast<Student>().ToList(), agreementDescription);
            agreementList.AddAgreementToList(agreement);
            MessageBox.Show("Your agreement was sent successfully.");
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (lstStudents.Items.Contains((Student)cmbStudents.SelectedItem))
            {
                MessageBox.Show("This student is already added.");
                return;
            }

            lstStudents.Items.Add((Student)cmbStudents.SelectedItem);
        }
    }
}
