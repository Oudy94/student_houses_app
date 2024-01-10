namespace student_houses_app
{
    partial class ComplaintsList
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvComplaintsList = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Complaint = new DataGridViewTextBoxColumn();
            View = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvComplaintsList).BeginInit();
            SuspendLayout();
            // 
            // dgvComplaintsList
            // 
            dgvComplaintsList.AllowUserToAddRows = false;
            dgvComplaintsList.AllowUserToDeleteRows = false;
            dgvComplaintsList.AllowUserToResizeColumns = false;
            dgvComplaintsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvComplaintsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvComplaintsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvComplaintsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComplaintsList.BackgroundColor = SystemColors.ControlLight;
            dgvComplaintsList.BorderStyle = BorderStyle.None;
            dgvComplaintsList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvComplaintsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Padding = new Padding(16, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvComplaintsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvComplaintsList.ColumnHeadersHeight = 37;
            dgvComplaintsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvComplaintsList.Columns.AddRange(new DataGridViewColumn[] { ID, Student, Complaint, View });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvComplaintsList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvComplaintsList.EnableHeadersVisualStyles = false;
            dgvComplaintsList.Location = new Point(3, 3);
            dgvComplaintsList.MultiSelect = false;
            dgvComplaintsList.Name = "dgvComplaintsList";
            dgvComplaintsList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Transparent;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.Transparent;
            dgvComplaintsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvComplaintsList.RowHeadersVisible = false;
            dgvComplaintsList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvComplaintsList.RowTemplate.Height = 50;
            dgvComplaintsList.ScrollBars = ScrollBars.Vertical;
            dgvComplaintsList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvComplaintsList.ShowEditingIcon = false;
            dgvComplaintsList.Size = new Size(749, 369);
            dgvComplaintsList.TabIndex = 1;
            dgvComplaintsList.CellContentClick += dgvComplaintsList_CellContentClick;
            // 
            // ID
            // 
            ID.FillWeight = 15F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Student
            // 
            Student.FillWeight = 35F;
            Student.HeaderText = "Student";
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Complaint
            // 
            Complaint.HeaderText = "Complaint";
            Complaint.Name = "Complaint";
            Complaint.ReadOnly = true;
            // 
            // View
            // 
            View.FillWeight = 15F;
            View.HeaderText = "View";
            View.Name = "View";
            View.ReadOnly = true;
            View.Text = "View";
            View.UseColumnTextForButtonValue = true;
            // 
            // ComplaintsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvComplaintsList);
            Name = "ComplaintsList";
            Size = new Size(755, 375);
            ((System.ComponentModel.ISupportInitialize)dgvComplaintsList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvComplaintsList;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Complaint;
        private DataGridViewButtonColumn View;
    }
}
