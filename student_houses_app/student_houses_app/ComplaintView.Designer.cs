﻿namespace student_houses_app
{
    partial class ComplaintView
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
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtComplaint = new TextBox();
            label5 = new Label();
            txtStudent = new TextBox();
            lblCreatedDate = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblCreatedDate);
            panel2.Controls.Add(txtStudent);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtComplaint);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 289);
            panel2.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 50);
            label7.Name = "label7";
            label7.Size = new Size(72, 17);
            label7.TabIndex = 0;
            label7.Text = "Student:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(51, 51, 76);
            label4.Location = new Point(154, 3);
            label4.Name = "label4";
            label4.Size = new Size(161, 37);
            label4.TabIndex = 2;
            label4.Text = "Complaint";
            // 
            // txtComplaint
            // 
            txtComplaint.BackColor = Color.FromArgb(230, 231, 233);
            txtComplaint.BorderStyle = BorderStyle.None;
            txtComplaint.Location = new Point(16, 121);
            txtComplaint.Multiline = true;
            txtComplaint.Name = "txtComplaint";
            txtComplaint.Size = new Size(467, 154);
            txtComplaint.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 101);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 10;
            label5.Text = "Complaint:";
            // 
            // txtStudent
            // 
            txtStudent.BackColor = Color.FromArgb(230, 231, 233);
            txtStudent.BorderStyle = BorderStyle.None;
            txtStudent.Location = new Point(16, 68);
            txtStudent.Multiline = true;
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(186, 23);
            txtStudent.TabIndex = 11;
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreatedDate.Location = new Point(423, 19);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(60, 17);
            lblCreatedDate.TabIndex = 13;
            lblCreatedDate.Text = "1/1/1975";
            // 
            // ComplaintView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(521, 313);
            Controls.Add(panel2);
            Name = "ComplaintView";
            Text = "ComplaintView";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblCreatedDate;
        private TextBox txtStudent;
        private Label label5;
        private TextBox txtComplaint;
        private Label label6;
        private Label label4;
        private Label label7;
    }
}