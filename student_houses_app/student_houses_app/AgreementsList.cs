using student_houses_app.models;
using student_houses_app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_houses_app
{
    public partial class AgreementsList : UserControl
    {
        private AgreementManager agreementManager;
        private StudentManager studentManager;

        public AgreementsList(AgreementManager agreementManager, StudentManager studentManager)
        {
            InitializeComponent();

            this.agreementManager = agreementManager;
            this.studentManager = studentManager;
        }

        public void UpdateAgreementsList()
        {
            dgvAgreementisList.Rows.Clear();
            foreach (Agreement agreement in agreementManager.Agreements)
            {
                int rowIndex = dgvAgreementisList.Rows.Add(agreement.Id, agreement.StudentA, agreement.StudentB, agreement.AgreementDesc);
                dgvAgreementisList.Rows[rowIndex].Tag = agreement;

            }
        }

        public void AddAgreementToList(Agreement agreement)
        {
            int rowIndex = dgvAgreementisList.Rows.Add(agreement.Id, agreement.StudentA, agreement.StudentB, agreement.AgreementDesc);
            dgvAgreementisList.Rows[rowIndex].Tag = agreement;
        }

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            AgreementForm agreementForm = new AgreementForm(this.agreementManager, this.studentManager, this);
            agreementForm.ShowDialog();
        }

        private void dgvAgreementisList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvAgreementisList.Columns["View"].Index)
            {
                DataGridViewRow clickedRow = dgvAgreementisList.Rows[e.RowIndex];

                if (clickedRow.Tag is Agreement agreement)
                {
                    AgreementView agreementView = new AgreementView(agreement);
                    agreementView.ShowDialog();
                }
            }
        }
    }
}
