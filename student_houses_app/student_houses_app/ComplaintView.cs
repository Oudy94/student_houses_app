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
    public partial class ComplaintView : Form
    {
        public ComplaintView(Complaint complaint)
        {
            InitializeComponent();

            txtStudent.Text = complaint.Student != null ? complaint.Student.Name : "Anonymous";
            txtComplaint.Text = complaint.ComplaintDesc;
            lblCreatedDate.Text = complaint.CreatedDate.ToString("dd/MM/yyyy");
        }
    }
}
