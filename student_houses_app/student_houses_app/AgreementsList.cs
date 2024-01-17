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
        public Main Main { get; set; }

        public AgreementsList(Main main)
        {
            InitializeComponent();

            this.Main = main;
        }

        public void UpdateAgreementsList()
        {
            dgvAgreementsList.Rows.Clear();
            foreach (Agreement agreement in this.Main.MC.AgreementManager.Agreements)
            {
                int rowIndex = dgvAgreementsList.Rows.Add(agreement.Id, string.Join(", ", agreement.Students), agreement.AgreementDesc);
                dgvAgreementsList.Rows[rowIndex].Tag = agreement;
            }
        }

        public void AddAgreementToList(Agreement agreement)
        {
            int rowIndex = dgvAgreementsList.Rows.Add(agreement.Id, string.Join(", ", agreement.Students), agreement.AgreementDesc);
            dgvAgreementsList.Rows[rowIndex].Tag = agreement;
        }

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            AgreementForm agreementForm = new AgreementForm(this.Main, this);
            agreementForm.ShowDialog();
        }

        private void dgvAgreementsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvAgreementsList.Columns["View"].Index)
            {
                DataGridViewRow clickedRow = dgvAgreementsList.Rows[e.RowIndex];

                if (clickedRow.Tag is Agreement agreement)
                {
                    AgreementView agreementView = new AgreementView(agreement);
                    agreementView.ShowDialog();
                }
            }
        }
    }
}
