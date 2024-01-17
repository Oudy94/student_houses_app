namespace student_houses_app
{
    partial class AgreementsList
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
            dgvAgreementsList = new DataGridView();
            btnAddAgreement = new Button();
            ID = new DataGridViewTextBoxColumn();
            Students = new DataGridViewTextBoxColumn();
            Agreement = new DataGridViewTextBoxColumn();
            View = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAgreementsList).BeginInit();
            SuspendLayout();
            // 
            // dgvAgreementsList
            // 
            dgvAgreementsList.AllowUserToAddRows = false;
            dgvAgreementsList.AllowUserToDeleteRows = false;
            dgvAgreementsList.AllowUserToResizeColumns = false;
            dgvAgreementsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvAgreementsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAgreementsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAgreementsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAgreementsList.BackgroundColor = SystemColors.ControlLight;
            dgvAgreementsList.BorderStyle = BorderStyle.None;
            dgvAgreementsList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvAgreementsList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Padding = new Padding(16, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvAgreementsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAgreementsList.ColumnHeadersHeight = 37;
            dgvAgreementsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAgreementsList.Columns.AddRange(new DataGridViewColumn[] { ID, Students, Agreement, View });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAgreementsList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAgreementsList.EnableHeadersVisualStyles = false;
            dgvAgreementsList.Location = new Point(3, 3);
            dgvAgreementsList.MultiSelect = false;
            dgvAgreementsList.Name = "dgvAgreementsList";
            dgvAgreementsList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Transparent;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.Transparent;
            dgvAgreementsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAgreementsList.RowHeadersVisible = false;
            dgvAgreementsList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAgreementsList.RowTemplate.Height = 50;
            dgvAgreementsList.ScrollBars = ScrollBars.Vertical;
            dgvAgreementsList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvAgreementsList.ShowEditingIcon = false;
            dgvAgreementsList.Size = new Size(749, 324);
            dgvAgreementsList.TabIndex = 1;
            dgvAgreementsList.CellContentClick += dgvAgreementsList_CellContentClick;
            // 
            // btnAddAgreement
            // 
            btnAddAgreement.BackColor = Color.FromArgb(51, 51, 76);
            btnAddAgreement.Cursor = Cursors.Hand;
            btnAddAgreement.FlatAppearance.BorderSize = 0;
            btnAddAgreement.FlatStyle = FlatStyle.Flat;
            btnAddAgreement.ForeColor = Color.White;
            btnAddAgreement.Location = new Point(295, 333);
            btnAddAgreement.Name = "btnAddAgreement";
            btnAddAgreement.Size = new Size(156, 35);
            btnAddAgreement.TabIndex = 8;
            btnAddAgreement.Text = "Add agreement";
            btnAddAgreement.UseVisualStyleBackColor = false;
            btnAddAgreement.Click += btnAddAgreement_Click;
            // 
            // ID
            // 
            ID.FillWeight = 15F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Students
            // 
            Students.FillWeight = 50F;
            Students.HeaderText = "Students";
            Students.Name = "Students";
            Students.ReadOnly = true;
            // 
            // Agreement
            // 
            Agreement.HeaderText = "Agreement";
            Agreement.Name = "Agreement";
            Agreement.ReadOnly = true;
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
            // AgreementsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddAgreement);
            Controls.Add(dgvAgreementsList);
            Name = "AgreementsList";
            Size = new Size(755, 375);
            ((System.ComponentModel.ISupportInitialize)dgvAgreementsList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAgreementsList;
        private Button btnAddAgreement;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Students;
        private DataGridViewTextBoxColumn Agreement;
        private DataGridViewButtonColumn View;
    }
}
