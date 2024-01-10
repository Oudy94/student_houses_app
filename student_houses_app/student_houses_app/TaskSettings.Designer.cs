namespace student_houses_app
{
    partial class TaskSettings
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
            lstTasksInfo = new ListBox();
            label1 = new Label();
            label2 = new Label();
            lstTaskDays = new ListBox();
            groupBox1 = new GroupBox();
            btnDeleteTask = new Button();
            btnSaveTask = new Button();
            txtTaskDescription = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnAddTask = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lstAddTaskDescription = new TextBox();
            lstAddTaskDays = new ListBox();
            txtAddTaskName = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lstTasksInfo
            // 
            lstTasksInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstTasksInfo.FormattingEnabled = true;
            lstTasksInfo.ItemHeight = 17;
            lstTasksInfo.Location = new Point(17, 48);
            lstTasksInfo.Name = "lstTasksInfo";
            lstTasksInfo.Size = new Size(168, 293);
            lstTasksInfo.TabIndex = 0;
            lstTasksInfo.SelectedIndexChanged += lstTasksInfo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 28);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 1;
            label1.Text = "Tasks:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(210, 28);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 3;
            label2.Text = "Days:";
            // 
            // lstTaskDays
            // 
            lstTaskDays.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstTaskDays.FormattingEnabled = true;
            lstTaskDays.ItemHeight = 17;
            lstTaskDays.Location = new Point(210, 48);
            lstTaskDays.Name = "lstTaskDays";
            lstTaskDays.SelectionMode = SelectionMode.None;
            lstTaskDays.Size = new Size(168, 123);
            lstTaskDays.TabIndex = 2;
            lstTaskDays.SelectedIndexChanged += lstTaskDays_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteTask);
            groupBox1.Controls.Add(btnSaveTask);
            groupBox1.Controls.Add(txtTaskDescription);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lstTasksInfo);
            groupBox1.Controls.Add(lstTaskDays);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(21, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 401);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task manager";
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteTask.Location = new Point(31, 351);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(143, 35);
            btnDeleteTask.TabIndex = 7;
            btnDeleteTask.Text = "Delete";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // btnSaveTask
            // 
            btnSaveTask.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveTask.Location = new Point(223, 351);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(143, 35);
            btnSaveTask.TabIndex = 6;
            btnSaveTask.Text = "Save";
            btnSaveTask.UseVisualStyleBackColor = true;
            btnSaveTask.Click += btnSaveTask_Click;
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaskDescription.Location = new Point(210, 209);
            txtTaskDescription.Multiline = true;
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(168, 130);
            txtTaskDescription.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(210, 189);
            label3.Name = "label3";
            label3.Size = new Size(83, 17);
            label3.TabIndex = 4;
            label3.Text = "Description:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAddTask);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lstAddTaskDescription);
            groupBox2.Controls.Add(lstAddTaskDays);
            groupBox2.Controls.Add(txtAddTaskName);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(448, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(288, 394);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add task";
            // 
            // btnAddTask
            // 
            btnAddTask.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddTask.Location = new Point(92, 344);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(143, 35);
            btnAddTask.TabIndex = 7;
            btnAddTask.Text = "Add";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(7, 222);
            label6.Name = "label6";
            label6.Size = new Size(41, 17);
            label6.TabIndex = 6;
            label6.Text = "Desc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 76);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 6;
            label5.Text = "Days:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 41);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 6;
            label4.Text = "Name:";
            // 
            // lstAddTaskDescription
            // 
            lstAddTaskDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstAddTaskDescription.Location = new Point(66, 222);
            lstAddTaskDescription.Multiline = true;
            lstAddTaskDescription.Name = "lstAddTaskDescription";
            lstAddTaskDescription.Size = new Size(208, 110);
            lstAddTaskDescription.TabIndex = 6;
            // 
            // lstAddTaskDays
            // 
            lstAddTaskDays.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstAddTaskDays.FormattingEnabled = true;
            lstAddTaskDays.ItemHeight = 17;
            lstAddTaskDays.Location = new Point(66, 76);
            lstAddTaskDays.Name = "lstAddTaskDays";
            lstAddTaskDays.SelectionMode = SelectionMode.MultiSimple;
            lstAddTaskDays.Size = new Size(208, 123);
            lstAddTaskDays.TabIndex = 6;
            // 
            // txtAddTaskName
            // 
            txtAddTaskName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddTaskName.Location = new Point(66, 35);
            txtAddTaskName.Name = "txtAddTaskName";
            txtAddTaskName.Size = new Size(208, 25);
            txtAddTaskName.TabIndex = 0;
            // 
            // TaskSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TaskSettings";
            Size = new Size(755, 430);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstTasksInfo;
        private Label label1;
        private Label label2;
        private ListBox lstTaskDays;
        private GroupBox groupBox1;
        private TextBox txtTaskDescription;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox lstAddTaskDescription;
        private ListBox lstAddTaskDays;
        private TextBox txtAddTaskName;
        private Button btnSaveTask;
        private Button btnAddTask;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnDeleteTask;
    }
}
