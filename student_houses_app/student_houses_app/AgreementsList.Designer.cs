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
            dgvAgreementisList = new DataGridView();
            btnAddAgreement = new Button();
            ID = new DataGridViewTextBoxColumn();
            StudentA = new DataGridViewTextBoxColumn();
            StudentB = new DataGridViewTextBoxColumn();
            Agreement = new DataGridViewTextBoxColumn();
            View = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAgreementisList).BeginInit();
            SuspendLayout();
            // 
            // dgvAgreementisList
            // 
            dgvAgreementisList.AllowUserToAddRows = false;
            dgvAgreementisList.AllowUserToDeleteRows = false;
            dgvAgreementisList.AllowUserToResizeColumns = false;
            dgvAgreementisList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvAgreementisList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAgreementisList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAgreementisList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAgreementisList.BackgroundColor = SystemColors.ControlLight;
            dgvAgreementisList.BorderStyle = BorderStyle.None;
            dgvAgreementisList.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvAgreementisList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Padding = new Padding(16, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvAgreementisList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAgreementisList.ColumnHeadersHeight = 37;
            dgvAgreementisList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAgreementisList.Columns.AddRange(new DataGridViewColumn[] { ID, StudentA, StudentB, Agreement, View });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAgreementisList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAgreementisList.EnableHeadersVisualStyles = false;
            dgvAgreementisList.Location = new Point(3, 3);
            dgvAgreementisList.MultiSelect = false;
            dgvAgreementisList.Name = "dgvAgreementisList";
            dgvAgreementisList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Transparent;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.Transparent;
            dgvAgreementisList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAgreementisList.RowHeadersVisible = false;
            dgvAgreementisList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvAgreementisList.RowTemplate.Height = 50;
            dgvAgreementisList.ScrollBars = ScrollBars.Vertical;
            dgvAgreementisList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvAgreementisList.ShowEditingIcon = false;
            dgvAgreementisList.Size = new Size(749, 324);
            dgvAgreementisList.TabIndex = 1;
            dgvAgreementisList.CellContentClick += dgvAgreementisList_CellContentClick;
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
            // StudentA
            // 
            StudentA.FillWeight = 35F;
            StudentA.HeaderText = "Student A";
            StudentA.Name = "StudentA";
            StudentA.ReadOnly = true;
            // 
            // StudentB
            // 
            StudentB.FillWeight = 35F;
            StudentB.HeaderText = "Student B";
            StudentB.Name = "StudentB";
            StudentB.ReadOnly = true;
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
            Controls.Add(dgvAgreementisList);
            Name = "AgreementsList";
            Size = new Size(755, 375);
            ((System.ComponentModel.ISupportInitialize)dgvAgreementisList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAgreementisList;
        private Button btnAddAgreement;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn StudentA;
        private DataGridViewTextBoxColumn StudentB;
        private DataGridViewTextBoxColumn Agreement;
        private DataGridViewButtonColumn View;
    }
}
