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
    public partial class AgreementView : Form
    {
        public AgreementView(Agreement agreement)
        {
            InitializeComponent();

            foreach (Student student in agreement.Students)
            {
                lstStudents.Items.Add(student);
            }
            txtAgreement.Text = agreement.AgreementDesc;
            lblCreatedDate.Text = agreement.CreatedDate.ToString("dd/MM/yyyy");
        }
    }
}
