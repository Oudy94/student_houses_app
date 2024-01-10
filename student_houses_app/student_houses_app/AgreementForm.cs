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
    public partial class AgreementForm : Form
    {
        AgreementManager agreementManager;
        StudentManager studentManager;
        AgreementsList agreementList;

        public AgreementForm(AgreementManager agreementManager, StudentManager studentManager, AgreementsList agreementList)
        {
            InitializeComponent();

            this.agreementManager = agreementManager;
            this.studentManager = studentManager;
            this.agreementList = agreementList;

            foreach (Student student in studentManager.StudentsDict.Values)
            {
                cmbStudentA.Items.Add(student);
                cmbStudentB.Items.Add(student);
            }
        }

        private void btnSubmitAgreement_Click(object sender, EventArgs e)
        {
            int selectedIndexStudentA = cmbStudentA.SelectedIndex;
            int selectedIndexStudentB = cmbStudentB.SelectedIndex;
            string agreementDescription = txtAgreement.Text;

            if (selectedIndexStudentA == -1 || selectedIndexStudentB == -1)
            {
                MessageBox.Show("You have to select the students.");
                return;
            }

            if (selectedIndexStudentA == selectedIndexStudentB)
            {
                MessageBox.Show("You cannot select the same student.");
                return;
            }

            if (string.IsNullOrWhiteSpace(agreementDescription))
            {
                MessageBox.Show("Agreement description cannot be empty.");
                return;
            }

            Agreement agreement = agreementManager.AddAgreement((Student)cmbStudentA.SelectedItem, (Student)cmbStudentB.SelectedItem, agreementDescription);
            agreementList.AddAgreementToList(agreement);
            MessageBox.Show("Your agrement was sent successfully.");
            this.Close();
        }
    }
}
