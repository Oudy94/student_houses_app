namespace student_houses_app
{
    partial class TaskViewAdmin
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
            txtIncompleteReason = new TextBox();
            label7 = new Label();
            btnRemoveTask = new Button();
            btnUpdateTask = new Button();
            cmbTaskStatus = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            dtpTaskDate = new DateTimePicker();
            label3 = new Label();
            cmbTaskInfo = new ComboBox();
            cmbTaskStudent = new ComboBox();
            label2 = new Label();
            txtTaskId = new TextBox();
            label1 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtIncompleteReason);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnRemoveTask);
            panel1.Controls.Add(btnUpdateTask);
            panel1.Controls.Add(cmbTaskStatus);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtpTaskDate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbTaskInfo);
            panel1.Controls.Add(cmbTaskStudent);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTaskId);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 346);
            panel1.TabIndex = 0;
            // 
            // txtIncompleteReason
            // 
            txtIncompleteReason.BackColor = Color.White;
            txtIncompleteReason.BorderStyle = BorderStyle.None;
            txtIncompleteReason.Location = new Point(12, 175);
            txtIncompleteReason.Multiline = true;
            txtIncompleteReason.Name = "txtIncompleteReason";
            txtIncompleteReason.ReadOnly = true;
            txtIncompleteReason.Size = new Size(588, 100);
            txtIncompleteReason.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 155);
            label7.Name = "label7";
            label7.Size = new Size(123, 17);
            label7.TabIndex = 23;
            label7.Text = "IncompleteReason:";
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.BackColor = Color.FromArgb(192, 0, 0);
            btnRemoveTask.Cursor = Cursors.Hand;
            btnRemoveTask.FlatAppearance.BorderSize = 0;
            btnRemoveTask.FlatStyle = FlatStyle.Flat;
            btnRemoveTask.ForeColor = Color.White;
            btnRemoveTask.Location = new Point(518, 299);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(82, 35);
            btnRemoveTask.TabIndex = 22;
            btnRemoveTask.Text = "Remove";
            btnRemoveTask.UseVisualStyleBackColor = false;
            btnRemoveTask.Click += btnRemoveTask_Click;
            // 
            // btnUpdateTask
            // 
            btnUpdateTask.BackColor = Color.FromArgb(51, 51, 76);
            btnUpdateTask.Cursor = Cursors.Hand;
            btnUpdateTask.FlatAppearance.BorderSize = 0;
            btnUpdateTask.FlatStyle = FlatStyle.Flat;
            btnUpdateTask.ForeColor = Color.White;
            btnUpdateTask.Location = new Point(177, 299);
            btnUpdateTask.Name = "btnUpdateTask";
            btnUpdateTask.Size = new Size(241, 35);
            btnUpdateTask.TabIndex = 21;
            btnUpdateTask.Text = "UPDATE";
            btnUpdateTask.UseVisualStyleBackColor = false;
            btnUpdateTask.Click += btnUpdateTask_Click;
            // 
            // cmbTaskStatus
            // 
            cmbTaskStatus.BackColor = Color.White;
            cmbTaskStatus.FlatStyle = FlatStyle.Flat;
            cmbTaskStatus.FormattingEnabled = true;
            cmbTaskStatus.Location = new Point(97, 124);
            cmbTaskStatus.Name = "cmbTaskStatus";
            cmbTaskStatus.Size = new Size(186, 25);
            cmbTaskStatus.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 127);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 19;
            label6.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(329, 99);
            label5.Name = "label5";
            label5.Size = new Size(39, 17);
            label5.TabIndex = 18;
            label5.Text = "Date:";
            // 
            // dtpTaskDate
            // 
            dtpTaskDate.Format = DateTimePickerFormat.Short;
            dtpTaskDate.Location = new Point(414, 93);
            dtpTaskDate.Name = "dtpTaskDate";
            dtpTaskDate.Size = new Size(186, 25);
            dtpTaskDate.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 16;
            label3.Text = "Task:";
            // 
            // cmbTaskInfo
            // 
            cmbTaskInfo.BackColor = Color.White;
            cmbTaskInfo.FlatStyle = FlatStyle.Flat;
            cmbTaskInfo.FormattingEnabled = true;
            cmbTaskInfo.Location = new Point(97, 93);
            cmbTaskInfo.Name = "cmbTaskInfo";
            cmbTaskInfo.Size = new Size(186, 25);
            cmbTaskInfo.TabIndex = 15;
            // 
            // cmbTaskStudent
            // 
            cmbTaskStudent.BackColor = Color.White;
            cmbTaskStudent.FlatStyle = FlatStyle.Flat;
            cmbTaskStudent.FormattingEnabled = true;
            cmbTaskStudent.Location = new Point(414, 62);
            cmbTaskStudent.Name = "cmbTaskStudent";
            cmbTaskStudent.Size = new Size(186, 25);
            cmbTaskStudent.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(329, 65);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 13;
            label2.Text = "Student:";
            // 
            // txtTaskId
            // 
            txtTaskId.BackColor = Color.White;
            txtTaskId.BorderStyle = BorderStyle.None;
            txtTaskId.Location = new Point(97, 64);
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
            label1.Location = new Point(12, 64);
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
            label4.Location = new Point(243, 9);
            label4.Name = "label4";
            label4.Size = new Size(72, 37);
            label4.TabIndex = 3;
            label4.Text = "Task";
            // 
            // TaskViewAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(612, 346);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "TaskViewAdmin";
            Text = "TaskViewStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label1;
        private TextBox txtTaskId;
        private Label label2;
        private ComboBox cmbTaskStudent;
        private Label label3;
        private Label label5;
        private DateTimePicker dtpTaskDate;
        private ComboBox cmbTaskStatus;
        private Label label6;
        private Button btnUpdateTask;
        private ComboBox cmbTaskInfo;
        private Button btnRemoveTask;
        private TextBox txtIncompleteReason;
        private Label label7;
    }
}