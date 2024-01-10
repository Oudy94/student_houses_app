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
            label4 = new Label();
            txtAgreement = new TextBox();
            cmbStudentB = new ComboBox();
            label3 = new Label();
            cmbStudentA = new ComboBox();
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
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtAgreement);
            panel1.Controls.Add(cmbStudentB);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbStudentA);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSubmitAgreement);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 336);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 116);
            label4.Name = "label4";
            label4.Size = new Size(79, 17);
            label4.TabIndex = 10;
            label4.Text = "Agreement:";
            // 
            // txtAgreement
            // 
            txtAgreement.BackColor = Color.FromArgb(230, 231, 233);
            txtAgreement.BorderStyle = BorderStyle.None;
            txtAgreement.Location = new Point(16, 136);
            txtAgreement.Multiline = true;
            txtAgreement.Name = "txtAgreement";
            txtAgreement.Size = new Size(478, 132);
            txtAgreement.TabIndex = 9;
            // 
            // cmbStudentB
            // 
            cmbStudentB.BackColor = Color.FromArgb(230, 231, 233);
            cmbStudentB.FlatStyle = FlatStyle.Flat;
            cmbStudentB.FormattingEnabled = true;
            cmbStudentB.Location = new Point(253, 83);
            cmbStudentB.Name = "cmbStudentB";
            cmbStudentB.Size = new Size(208, 23);
            cmbStudentB.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(253, 65);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 7;
            label3.Text = "Student B:";
            // 
            // cmbStudentA
            // 
            cmbStudentA.BackColor = Color.FromArgb(230, 231, 233);
            cmbStudentA.FlatStyle = FlatStyle.Flat;
            cmbStudentA.FormattingEnabled = true;
            cmbStudentA.Location = new Point(16, 83);
            cmbStudentA.Name = "cmbStudentA";
            cmbStudentA.Size = new Size(208, 23);
            cmbStudentA.TabIndex = 6;
            // 
            // btnSubmitAgreement
            // 
            btnSubmitAgreement.BackColor = Color.FromArgb(51, 51, 76);
            btnSubmitAgreement.Cursor = Cursors.Hand;
            btnSubmitAgreement.FlatAppearance.BorderSize = 0;
            btnSubmitAgreement.FlatStyle = FlatStyle.Flat;
            btnSubmitAgreement.ForeColor = Color.White;
            btnSubmitAgreement.Location = new Point(135, 287);
            btnSubmitAgreement.Name = "btnSubmitAgreement";
            btnSubmitAgreement.Size = new Size(241, 35);
            btnSubmitAgreement.TabIndex = 5;
            btnSubmitAgreement.Text = "SUBMIT";
            btnSubmitAgreement.UseVisualStyleBackColor = false;
            btnSubmitAgreement.Click += btnSubmitAgreement_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 0;
            label2.Text = "Student A:";
            // 
            // AgreementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(528, 360);
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
        private ComboBox cmbStudentB;
        private Label label3;
        private ComboBox cmbStudentA;
        private Label label4;
        private TextBox txtAgreement;
    }
}