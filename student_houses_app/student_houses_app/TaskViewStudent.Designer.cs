namespace student_houses_app
{
    partial class TaskViewStudent
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
            panel1 = new Panel();
            txtTaskDate = new TextBox();
            btnCompleteTask = new Button();
            txtTaskStatus = new TextBox();
            txtTaskInfo = new TextBox();
            txtTaskStudent = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTaskId = new TextBox();
            label1 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            btnSendExcuse = new Button();
            txtUnableToComplete = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(txtTaskDate);
            panel1.Controls.Add(btnCompleteTask);
            panel1.Controls.Add(txtTaskStatus);
            panel1.Controls.Add(txtTaskInfo);
            panel1.Controls.Add(txtTaskStudent);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTaskId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 464);
            panel1.TabIndex = 0;
            // 
            // txtTaskDate
            // 
            txtTaskDate.BackColor = Color.White;
            txtTaskDate.BorderStyle = BorderStyle.None;
            txtTaskDate.Location = new Point(472, 108);
            txtTaskDate.Multiline = true;
            txtTaskDate.Name = "txtTaskDate";
            txtTaskDate.ReadOnly = true;
            txtTaskDate.Size = new Size(186, 23);
            txtTaskDate.TabIndex = 27;
            // 
            // btnCompleteTask
            // 
            btnCompleteTask.BackColor = Color.FromArgb(51, 51, 76);
            btnCompleteTask.Cursor = Cursors.Hand;
            btnCompleteTask.FlatAppearance.BorderSize = 0;
            btnCompleteTask.FlatStyle = FlatStyle.Flat;
            btnCompleteTask.ForeColor = Color.White;
            btnCompleteTask.Location = new Point(235, 167);
            btnCompleteTask.Name = "btnCompleteTask";
            btnCompleteTask.Size = new Size(241, 35);
            btnCompleteTask.TabIndex = 22;
            btnCompleteTask.Text = "Complete";
            btnCompleteTask.UseVisualStyleBackColor = false;
            btnCompleteTask.Click += btnCompleteTask_Click;
            // 
            // txtTaskStatus
            // 
            txtTaskStatus.BackColor = Color.White;
            txtTaskStatus.BorderStyle = BorderStyle.None;
            txtTaskStatus.Location = new Point(116, 121);
            txtTaskStatus.Multiline = true;
            txtTaskStatus.Name = "txtTaskStatus";
            txtTaskStatus.ReadOnly = true;
            txtTaskStatus.Size = new Size(186, 23);
            txtTaskStatus.TabIndex = 21;
            // 
            // txtTaskInfo
            // 
            txtTaskInfo.BackColor = Color.White;
            txtTaskInfo.BorderStyle = BorderStyle.None;
            txtTaskInfo.Location = new Point(116, 93);
            txtTaskInfo.Multiline = true;
            txtTaskInfo.Name = "txtTaskInfo";
            txtTaskInfo.ReadOnly = true;
            txtTaskInfo.Size = new Size(186, 23);
            txtTaskInfo.TabIndex = 20;
            // 
            // txtTaskStudent
            // 
            txtTaskStudent.BackColor = Color.White;
            txtTaskStudent.BorderStyle = BorderStyle.None;
            txtTaskStudent.Location = new Point(472, 64);
            txtTaskStudent.Multiline = true;
            txtTaskStudent.Name = "txtTaskStudent";
            txtTaskStudent.ReadOnly = true;
            txtTaskStudent.Size = new Size(186, 23);
            txtTaskStudent.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 127);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 19;
            label6.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(387, 108);
            label5.Name = "label5";
            label5.Size = new Size(39, 17);
            label5.TabIndex = 18;
            label5.Text = "Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 96);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 16;
            label3.Text = "Task:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(387, 70);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 13;
            label2.Text = "Student:";
            // 
            // txtTaskId
            // 
            txtTaskId.BackColor = Color.White;
            txtTaskId.BorderStyle = BorderStyle.None;
            txtTaskId.Location = new Point(116, 64);
            txtTaskId.Multiline = true;
            txtTaskId.Name = "txtTaskId";
            txtTaskId.ReadOnly = true;
            txtTaskId.Size = new Size(186, 23);
            txtTaskId.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 64);
            label1.Name = "label1";
            label1.Size = new Size(23, 17);
            label1.TabIndex = 4;
            label1.Text = "Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(51, 51, 76);
            label4.Location = new Point(302, 9);
            label4.Name = "label4";
            label4.Size = new Size(72, 37);
            label4.TabIndex = 3;
            label4.Text = "Task";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnSendExcuse);
            groupBox1.Controls.Add(txtUnableToComplete);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(685, 227);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Unabe to complete";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(19, 27);
            label7.Name = "label7";
            label7.Size = new Size(55, 17);
            label7.TabIndex = 24;
            label7.Text = "Reason:";
            // 
            // btnSendExcuse
            // 
            btnSendExcuse.BackColor = Color.FromArgb(51, 51, 76);
            btnSendExcuse.Cursor = Cursors.Hand;
            btnSendExcuse.FlatAppearance.BorderSize = 0;
            btnSendExcuse.FlatStyle = FlatStyle.Flat;
            btnSendExcuse.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSendExcuse.ForeColor = Color.White;
            btnSendExcuse.Location = new Point(223, 185);
            btnSendExcuse.Name = "btnSendExcuse";
            btnSendExcuse.Size = new Size(241, 36);
            btnSendExcuse.TabIndex = 25;
            btnSendExcuse.Text = "Send";
            btnSendExcuse.UseVisualStyleBackColor = false;
            btnSendExcuse.Click += btnSendExcuse_Click;
            // 
            // txtUnableToComplete
            // 
            txtUnableToComplete.Location = new Point(19, 47);
            txtUnableToComplete.Multiline = true;
            txtUnableToComplete.Name = "txtUnableToComplete";
            txtUnableToComplete.Size = new Size(660, 124);
            txtUnableToComplete.TabIndex = 23;
            // 
            // TaskViewStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(709, 464);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "TaskViewStudent";
            Text = "TaskViewStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label1;
        private TextBox txtTaskId;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtTaskStatus;
        private TextBox txtTaskInfo;
        private TextBox txtTaskStudent;
        private Button btnCompleteTask;
        private TextBox txtTaskDate;
        private GroupBox groupBox1;
        private Label label7;
        private Button btnSendExcuse;
        private TextBox txtUnableToComplete;
    }
}