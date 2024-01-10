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
        public ComplaintView(Complaint comlaint)
        {
            InitializeComponent();

            txtStudent.Text = comlaint.Student != null ? comlaint.Student.Name : "Anonymous";
            txtComplaint.Text = comlaint.ComplaintDesc;
            lblCreatedDate.Text = comlaint.CreatedDate.ToString("dd/MM/yyyy");
        }
    }
}
