namespace student_houses_app
{
    partial class StudentSettings
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
            label4 = new Label();
            txtAddStudentName = new TextBox();
            btnSaveTask = new Button();
            groupBox1 = new GroupBox();
            cmbStudentActivity = new ComboBox();
            label7 = new Label();
            lblStudentRegisteredDate = new Label();
            txtStudentEmail = new TextBox();
            label3 = new Label();
            lblEmail = new Label();
            label2 = new Label();
            lstStudents = new ListBox();
            lstStudentTasks = new ListBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            txtAddStudentEmail = new TextBox();
            btnAddStudent = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 41);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 6;
            label4.Text = "Name:";
            // 
            // txtAddStudentName
            // 
            txtAddStudentName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddStudentName.Location = new Point(15, 61);
            txtAddStudentName.Name = "txtAddStudentName";
            txtAddStudentName.Size = new Size(219, 25);
            txtAddStudentName.TabIndex = 0;
            // 
            // btnSaveTask
            // 
            btnSaveTask.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveTask.Location = new Point(138, 360);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(143, 35);
            btnSaveTask.TabIndex = 6;
            btnSaveTask.Text = "Save";
            btnSaveTask.UseVisualStyleBackColor = true;
            btnSaveTask.Click += btnSaveTask_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbStudentActivity);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblStudentRegisteredDate);
            groupBox1.Controls.Add(txtStudentEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(btnSaveTask);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lstStudents);
            groupBox1.Controls.Add(lstStudentTasks);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(20, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 401);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student manager";
            // 
            // cmbStudentActivity
            // 
            cmbStudentActivity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStudentActivity.FormattingEnabled = true;
            cmbStudentActivity.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStudentActivity.Location = new Point(287, 54);
            cmbStudentActivity.Name = "cmbStudentActivity";
            cmbStudentActivity.Size = new Size(151, 25);
            cmbStudentActivity.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(217, 56);
            label7.Name = "label7";
            label7.Size = new Size(64, 19);
            label7.TabIndex = 12;
            label7.Text = "Activity:";
            // 
            // lblStudentRegisteredDate
            // 
            lblStudentRegisteredDate.AutoSize = true;
            lblStudentRegisteredDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblStudentRegisteredDate.Location = new Point(300, 26);
            lblStudentRegisteredDate.Name = "lblStudentRegisteredDate";
            lblStudentRegisteredDate.Size = new Size(74, 17);
            lblStudentRegisteredDate.TabIndex = 11;
            lblStudentRegisteredDate.Text = "01/01/1970";
            // 
            // txtStudentEmail
            // 
            txtStudentEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudentEmail.Location = new Point(218, 110);
            txtStudentEmail.Name = "txtStudentEmail";
            txtStudentEmail.Size = new Size(221, 25);
            txtStudentEmail.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(217, 26);
            label3.Name = "label3";
            label3.Size = new Size(77, 19);
            label3.TabIndex = 9;
            label3.Text = "Reg. date:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(218, 88);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 19);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(217, 147);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 3;
            label2.Text = "Tasks:";
            // 
            // lstStudents
            // 
            lstStudents.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 17;
            lstStudents.Location = new Point(17, 48);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(182, 293);
            lstStudents.TabIndex = 0;
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged;
            // 
            // lstStudentTasks
            // 
            lstStudentTasks.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstStudentTasks.FormattingEnabled = true;
            lstStudentTasks.ItemHeight = 17;
            lstStudentTasks.Location = new Point(217, 167);
            lstStudentTasks.Name = "lstStudentTasks";
            lstStudentTasks.SelectionMode = SelectionMode.None;
            lstStudentTasks.Size = new Size(221, 174);
            lstStudentTasks.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 28);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 1;
            label1.Text = "Students list:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtAddStudentEmail);
            groupBox2.Controls.Add(btnAddStudent);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtAddStudentName);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(493, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 401);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add student";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 106);
            label5.Name = "label5";
            label5.Size = new Size(46, 17);
            label5.TabIndex = 9;
            label5.Text = "Email:";
            // 
            // txtAddStudentEmail
            // 
            txtAddStudentEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddStudentEmail.Location = new Point(15, 126);
            txtAddStudentEmail.Name = "txtAddStudentEmail";
            txtAddStudentEmail.Size = new Size(219, 25);
            txtAddStudentEmail.TabIndex = 8;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddStudent.Location = new Point(54, 176);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(143, 35);
            btnAddStudent.TabIndex = 7;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // StudentSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "StudentSettings";
            Size = new Size(755, 430);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Label label4;
        private TextBox lstAddTaskDescription;
        private TextBox txtAddStudentName;
        private Button btnSaveTask;
        private GroupBox groupBox1;
        private Label label2;
        private ListBox lstStudents;
        private ListBox lstStudentTasks;
        private Label label1;
        private GroupBox groupBox2;
        private Label lblEmail;
        private Label label3;
        private TextBox txtStudentEmail;
        private Label lblStudentRegisteredDate;
        private Label label5;
        private TextBox txtAddStudentEmail;
        private Button btnAddStudent;
        private ComboBox cmbStudentActivity;
        private Label label7;
    }
}
