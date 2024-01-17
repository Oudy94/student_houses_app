namespace student_houses_app
{
    partial class AgreementView
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
            panel2 = new Panel();
            lstStudents = new ListBox();
            lblCreatedDate = new Label();
            label5 = new Label();
            txtAgreement = new TextBox();
            label4 = new Label();
            label7 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lstStudents);
            panel2.Controls.Add(lblCreatedDate);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtAgreement);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 362);
            panel2.TabIndex = 6;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(16, 70);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(222, 94);
            lstStudents.TabIndex = 14;
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreatedDate.Location = new Point(480, 25);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(60, 17);
            lblCreatedDate.TabIndex = 13;
            lblCreatedDate.Text = "1/1/1975";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 178);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 10;
            label5.Text = "Agreement:";
            // 
            // txtAgreement
            // 
            txtAgreement.BackColor = Color.White;
            txtAgreement.BorderStyle = BorderStyle.None;
            txtAgreement.Location = new Point(16, 198);
            txtAgreement.Multiline = true;
            txtAgreement.Name = "txtAgreement";
            txtAgreement.Size = new Size(537, 142);
            txtAgreement.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(51, 51, 76);
            label4.Location = new Point(203, 9);
            label4.Name = "label4";
            label4.Size = new Size(161, 37);
            label4.TabIndex = 2;
            label4.Text = "Agreement";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 50);
            label7.Name = "label7";
            label7.Size = new Size(65, 17);
            label7.TabIndex = 0;
            label7.Text = "Students:";
            // 
            // AgreementView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(564, 362);
            Controls.Add(panel2);
            Name = "AgreementView";
            Text = "AgreementView";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblCreatedDate;
        private Label label5;
        private TextBox txtAgreement;
        private Label label4;
        private Label label7;
        private ListBox lstStudents;
    }
}