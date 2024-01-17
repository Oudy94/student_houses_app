namespace student_houses_app
{
    partial class AgreementForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            lstStudents = new ListBox();
            btnAddStudent = new Button();
            label4 = new Label();
            txtAgreement = new TextBox();
            cmbStudents = new ComboBox();
            btnSubmitAgreement = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(51, 51, 76);
            label1.Location = new Point(146, 10);
            label1.Name = "label1";
            label1.Size = new Size(238, 37);
            label1.TabIndex = 2;
            label1.Text = "Make Agreement";
            // 
            // panel1
            // 
            panel1.Controls.Add(lstStudents);
            panel1.Controls.Add(btnAddStudent);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtAgreement);
            panel1.Controls.Add(cmbStudents);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSubmitAgreement);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 391);
            panel1.TabIndex = 3;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(16, 69);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(267, 109);
            lstStudents.TabIndex = 15;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.FromArgb(51, 51, 76);
            btnAddStudent.Cursor = Cursors.Hand;
            btnAddStudent.FlatAppearance.BorderSize = 0;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.ForeColor = Color.White;
            btnAddStudent.Location = new Point(489, 69);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(63, 23);
            btnAddStudent.TabIndex = 11;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 184);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 10;
            label4.Text = "Agreement:";
            // 
            // txtAgreement
            // 
            txtAgreement.BackColor = Color.White;
            txtAgreement.BorderStyle = BorderStyle.None;
            txtAgreement.Location = new Point(12, 205);
            txtAgreement.Multiline = true;
            txtAgreement.Name = "txtAgreement";
            txtAgreement.Size = new Size(540, 131);
            txtAgreement.TabIndex = 9;
            // 
            // cmbStudents
            // 
            cmbStudents.BackColor = Color.White;
            cmbStudents.FlatStyle = FlatStyle.Flat;
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(298, 69);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(185, 23);
            cmbStudents.TabIndex = 8;
            // 
            // btnSubmitAgreement
            // 
            btnSubmitAgreement.BackColor = Color.FromArgb(51, 51, 76);
            btnSubmitAgreement.Cursor = Cursors.Hand;
            btnSubmitAgreement.FlatAppearance.BorderSize = 0;
            btnSubmitAgreement.FlatStyle = FlatStyle.Flat;
            btnSubmitAgreement.ForeColor = Color.White;
            btnSubmitAgreement.Location = new Point(163, 348);
            btnSubmitAgreement.Name = "btnSubmitAgreement";
            btnSubmitAgreement.Size = new Size(241, 37);
            btnSubmitAgreement.TabIndex = 5;
            btnSubmitAgreement.Text = "SUBMIT";
            btnSubmitAgreement.UseVisualStyleBackColor = false;
            btnSubmitAgreement.Click += btnSubmitAgreement_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 49);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 0;
            label2.Text = "Students:";
            // 
            // AgreementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(564, 391);
            Controls.Add(panel1);
            Name = "AgreementForm";
            Text = "AgreementForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnSubmitAgreement;
        private Label label2;
        private ComboBox cmbStudents;
        private Label label4;
        private TextBox txtAgreement;
        private Button btnAddStudent;
        private ListBox lstStudents;
    }
}