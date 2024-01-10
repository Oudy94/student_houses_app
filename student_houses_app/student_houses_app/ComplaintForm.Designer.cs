namespace student_houses_app
{
    partial class ComplaintForm
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
            txtComplaint = new TextBox();
            cmbStudent = new ComboBox();
            btnSubmitComplaint = new Button();
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
            label1.Size = new Size(228, 37);
            label1.TabIndex = 2;
            label1.Text = "Make Complaint";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtComplaint);
            panel1.Controls.Add(cmbStudent);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSubmitComplaint);
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
            label4.Size = new Size(73, 17);
            label4.TabIndex = 10;
            label4.Text = "Complaint:";
            // 
            // txtComplaint
            // 
            txtComplaint.BackColor = Color.FromArgb(230, 231, 233);
            txtComplaint.BorderStyle = BorderStyle.None;
            txtComplaint.Location = new Point(16, 136);
            txtComplaint.Multiline = true;
            txtComplaint.Name = "txtComplaint";
            txtComplaint.Size = new Size(478, 132);
            txtComplaint.TabIndex = 9;
            // 
            // cmbStudent
            // 
            cmbStudent.BackColor = Color.FromArgb(230, 231, 233);
            cmbStudent.FlatStyle = FlatStyle.Flat;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(16, 83);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(208, 23);
            cmbStudent.TabIndex = 6;
            // 
            // btnSubmitComplaint
            // 
            btnSubmitComplaint.BackColor = Color.FromArgb(51, 51, 76);
            btnSubmitComplaint.Cursor = Cursors.Hand;
            btnSubmitComplaint.FlatAppearance.BorderSize = 0;
            btnSubmitComplaint.FlatStyle = FlatStyle.Flat;
            btnSubmitComplaint.ForeColor = Color.White;
            btnSubmitComplaint.Location = new Point(135, 287);
            btnSubmitComplaint.Name = "btnSubmitComplaint";
            btnSubmitComplaint.Size = new Size(241, 35);
            btnSubmitComplaint.TabIndex = 5;
            btnSubmitComplaint.Text = "SUBMIT";
            btnSubmitComplaint.UseVisualStyleBackColor = false;
            btnSubmitComplaint.Click += btnSubmitComplaint_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 0;
            label2.Text = "Student:";
            // 
            // ComplaintForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(528, 360);
            Controls.Add(panel1);
            Name = "ComplaintForm";
            Text = "ComplaintForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnSubmitComplaint;
        private Label label2;
        private ComboBox cmbStudent;
        private Label label4;
        private TextBox txtComplaint;
    }
}