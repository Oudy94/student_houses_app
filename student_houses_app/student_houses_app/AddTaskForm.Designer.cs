namespace student_houses_app
{
    partial class AddTaskForm
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
            btnAddTask = new Button();
            label5 = new Label();
            dtpTaskDate = new DateTimePicker();
            label3 = new Label();
            cmbTaskInfo = new ComboBox();
            cmbTaskStudent = new ComboBox();
            label2 = new Label();
            txtTaskId = new TextBox();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.FromArgb(51, 51, 76);
            btnAddTask.Cursor = Cursors.Hand;
            btnAddTask.FlatAppearance.BorderSize = 0;
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.ForeColor = Color.White;
            btnAddTask.Location = new Point(192, 208);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(241, 35);
            btnAddTask.TabIndex = 34;
            btnAddTask.Text = "Add task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(343, 109);
            label5.Name = "label5";
            label5.Size = new Size(39, 17);
            label5.TabIndex = 31;
            label5.Text = "Date:";
            // 
            // dtpTaskDate
            // 
            dtpTaskDate.Format = DateTimePickerFormat.Short;
            dtpTaskDate.Location = new Point(428, 103);
            dtpTaskDate.Name = "dtpTaskDate";
            dtpTaskDate.Size = new Size(186, 25);
            dtpTaskDate.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 106);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 29;
            label3.Text = "Task:";
            // 
            // cmbTaskInfo
            // 
            cmbTaskInfo.BackColor = Color.White;
            cmbTaskInfo.FlatStyle = FlatStyle.Flat;
            cmbTaskInfo.FormattingEnabled = true;
            cmbTaskInfo.Location = new Point(111, 103);
            cmbTaskInfo.Name = "cmbTaskInfo";
            cmbTaskInfo.Size = new Size(186, 25);
            cmbTaskInfo.TabIndex = 28;
            // 
            // cmbTaskStudent
            // 
            cmbTaskStudent.BackColor = Color.White;
            cmbTaskStudent.FlatStyle = FlatStyle.Flat;
            cmbTaskStudent.FormattingEnabled = true;
            cmbTaskStudent.Location = new Point(428, 72);
            cmbTaskStudent.Name = "cmbTaskStudent";
            cmbTaskStudent.Size = new Size(186, 25);
            cmbTaskStudent.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(343, 75);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 26;
            label2.Text = "Student:";
            // 
            // txtTaskId
            // 
            txtTaskId.BackColor = Color.White;
            txtTaskId.BorderStyle = BorderStyle.None;
            txtTaskId.Location = new Point(111, 74);
            txtTaskId.Multiline = true;
            txtTaskId.Name = "txtTaskId";
            txtTaskId.ReadOnly = true;
            txtTaskId.Size = new Size(186, 23);
            txtTaskId.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 74);
            label1.Name = "label1";
            label1.Size = new Size(23, 17);
            label1.TabIndex = 24;
            label1.Text = "Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(51, 51, 76);
            label4.Location = new Point(257, 19);
            label4.Name = "label4";
            label4.Size = new Size(72, 37);
            label4.TabIndex = 23;
            label4.Text = "Task";
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 276);
            Controls.Add(btnAddTask);
            Controls.Add(label5);
            Controls.Add(dtpTaskDate);
            Controls.Add(label3);
            Controls.Add(cmbTaskInfo);
            Controls.Add(cmbTaskStudent);
            Controls.Add(label2);
            Controls.Add(txtTaskId);
            Controls.Add(label1);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AddTaskForm";
            Text = "AddTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddTask;
        private Label label5;
        private DateTimePicker dtpTaskDate;
        private Label label3;
        private ComboBox cmbTaskInfo;
        private ComboBox cmbTaskStudent;
        private Label label2;
        private TextBox txtTaskId;
        private Label label1;
        private Label label4;
    }
}