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
    public partial class ComplaintsList : UserControl
    {
        private ComplaintManager complaintManager;
        private StudentManager studentManager;

        public ComplaintsList(ComplaintManager complaintManager, StudentManager studentManager)
        {
            InitializeComponent();

            this.complaintManager = complaintManager;
            this.studentManager = studentManager;
        }

        public void UpdateComplaintsList()
        {
            dgvComplaintsList.Rows.Clear();
            foreach (Complaint complaint in complaintManager.Complaints)
            {
                int rowIndex = dgvComplaintsList.Rows.Add(complaint.Id, complaint.Student != null ? complaint.Student : "Anonymous", complaint.ComplaintDesc);
                dgvComplaintsList.Rows[rowIndex].Tag = complaint;

            }
        }

        public void AddComplaintToList(Complaint complaint)
        {
            int rowIndex = dgvComplaintsList.Rows.Add(complaint.Id, complaint.Student != null ? complaint.Student : "Anonymous", complaint.ComplaintDesc);
            dgvComplaintsList.Rows[rowIndex].Tag = complaint;
        }

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            ComplaintForm complaintForm = new ComplaintForm(this.complaintManager, this.studentManager);
            complaintForm.ShowDialog();
        }

        private void dgvComplaintsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvComplaintsList.Columns["View"].Index)
            {
                DataGridViewRow clickedRow = dgvComplaintsList.Rows[e.RowIndex];

                if (clickedRow.Tag is Complaint complaint)
                {
                    ComplaintView complaintView = new ComplaintView(complaint);
                    complaintView.ShowDialog();
                }
            }
        }
    }
}
