namespace student_houses_app
{
    partial class TaskListControl
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
            dgvTasksList = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Task = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            View = new DataGridViewButtonColumn();
            btnAddTask = new Button();
            cmbFilterTask = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbFilterStudent = new ComboBox();
            label3 = new Label();
            cmbFilterStatus = new ComboBox();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTasksList).BeginInit();
            SuspendLayout();
            // 
            // dgvTasksList
            // 
            dgvTasksList.AllowUserToAddRows = false;
            dgvTasksList.AllowUserToDeleteRows = false;
            dgvTasksList.AllowUserToResizeRows = false;
            dgvTasksList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasksList.BackgroundColor = SystemColors.ControlLight;
            dgvTasksList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTasksList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTasksList.ColumnHeadersHeight = 37;
            dgvTasksList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTasksList.Columns.AddRange(new DataGridViewColumn[] { ID, Task, Student, Status, Date, View });
            dgvTasksList.EnableHeadersVisualStyles = false;
            dgvTasksList.Location = new Point(3, 88);
            dgvTasksList.MultiSelect = false;
            dgvTasksList.Name = "dgvTasksList";
            dgvTasksList.ReadOnly = true;
            dgvTasksList.RowHeadersVisible = false;
            dgvTasksList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTasksList.RowTemplate.Height = 25;
            dgvTasksList.ScrollBars = ScrollBars.Vertical;
            dgvTasksList.ShowEditingIcon = false;
            dgvTasksList.Size = new Size(749, 323);
            dgvTasksList.TabIndex = 1;
            dgvTasksList.CellContentClick += dgvTasksList_CellContentClick;
            // 
            // ID
            // 
            ID.FillWeight = 15F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Task
            // 
            Task.FillWeight = 40F;
            Task.HeaderText = "Task";
            Task.Name = "Task";
            Task.ReadOnly = true;
            // 
            // Student
            // 
            Student.FillWeight = 50F;
            Student.HeaderText = "Student";
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // Status
            // 
            Status.FillWeight = 40F;
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Date
            // 
            Date.FillWeight = 30F;
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // View
            // 
            View.FillWeight = 15F;
            View.HeaderText = "View";
            View.Name = "View";
            View.ReadOnly = true;
            View.Text = "View";
            View.ToolTipText = "View task";
            View.UseColumnTextForButtonValue = true;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.FromArgb(51, 51, 76);
            btnAddTask.Cursor = Cursors.Hand;
            btnAddTask.FlatAppearance.BorderSize = 0;
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.ForeColor = Color.White;
            btnAddTask.Location = new Point(308, 417);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(141, 35);
            btnAddTask.TabIndex = 8;
            btnAddTask.Text = "Add task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // cmbFilterTask
            // 
            cmbFilterTask.FormattingEnabled = true;
            cmbFilterTask.Location = new Point(53, 14);
            cmbFilterTask.Name = "cmbFilterTask";
            cmbFilterTask.Size = new Size(121, 25);
            cmbFilterTask.TabIndex = 9;
            cmbFilterTask.SelectedIndexChanged += cmbFilterTask_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 14);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 10;
            label1.Text = "Task:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(230, 14);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 12;
            label2.Text = "Student:";
            // 
            // cmbFilterStudent
            // 
            cmbFilterStudent.FormattingEnabled = true;
            cmbFilterStudent.Location = new Point(308, 14);
            cmbFilterStudent.Name = "cmbFilterStudent";
            cmbFilterStudent.Size = new Size(159, 25);
            cmbFilterStudent.TabIndex = 11;
            cmbFilterStudent.SelectedIndexChanged += cmbFilterStudent_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(520, 14);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 14;
            label3.Text = "Status:";
            // 
            // cmbFilterStatus
            // 
            cmbFilterStatus.FormattingEnabled = true;
            cmbFilterStatus.Location = new Point(585, 14);
            cmbFilterStatus.Name = "cmbFilterStatus";
            cmbFilterStatus.Size = new Size(140, 25);
            cmbFilterStatus.TabIndex = 13;
            cmbFilterStatus.SelectedIndexChanged += cmbFilterStatus_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(51, 51, 76);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(640, 51);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(85, 29);
            btnRefresh.TabIndex = 21;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // TaskListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(btnRefresh);
            Controls.Add(label3);
            Controls.Add(cmbFilterStatus);
            Controls.Add(label2);
            Controls.Add(cmbFilterStudent);
            Controls.Add(label1);
            Controls.Add(cmbFilterTask);
            Controls.Add(btnAddTask);
            Controls.Add(dgvTasksList);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "TaskListControl";
            Size = new Size(755, 455);
            ((System.ComponentModel.ISupportInitialize)dgvTasksList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTasksList;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Task;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewButtonColumn View;
        private Button btnAddTask;
        private ComboBox cmbFilterTask;
        private Label label1;
        private Label label2;
        private ComboBox cmbFilterStudent;
        private Label label3;
        private ComboBox cmbFilterStatus;
        private Button btnRefresh;
    }
}
