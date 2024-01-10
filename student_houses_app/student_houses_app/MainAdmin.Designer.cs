namespace student_houses_app
{
    partial class MainAdmin
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
            panel1 = new Panel();
            btnUpdate = new Button();
            btnLogout = new Button();
            pnlMenu = new Panel();
            btnTaskSettings = new Button();
            btnStudentSettings = new Button();
            btnEventRequestsList = new Button();
            btnComplaintsList = new Button();
            btnAgreements = new Button();
            btnTasksSchedule = new Button();
            pnlLogo = new Panel();
            pnlMainAdmin = new Panel();
            panel1.SuspendLayout();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnLogout);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 54);
            panel1.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(51, 51, 76);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(610, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 35);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(51, 51, 76);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(694, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(78, 35);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(51, 51, 76);
            pnlMenu.Controls.Add(btnTaskSettings);
            pnlMenu.Controls.Add(btnStudentSettings);
            pnlMenu.Controls.Add(btnEventRequestsList);
            pnlMenu.Controls.Add(btnComplaintsList);
            pnlMenu.Controls.Add(btnAgreements);
            pnlMenu.Controls.Add(btnTasksSchedule);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 545);
            pnlMenu.TabIndex = 6;
            // 
            // btnTaskSettings
            // 
            btnTaskSettings.Dock = DockStyle.Top;
            btnTaskSettings.FlatAppearance.BorderSize = 0;
            btnTaskSettings.FlatStyle = FlatStyle.Flat;
            btnTaskSettings.ForeColor = Color.Gainsboro;
            btnTaskSettings.Image = Properties.Resources.task_setting;
            btnTaskSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaskSettings.Location = new Point(0, 380);
            btnTaskSettings.Name = "btnTaskSettings";
            btnTaskSettings.Padding = new Padding(12, 0, 0, 0);
            btnTaskSettings.Size = new Size(220, 60);
            btnTaskSettings.TabIndex = 6;
            btnTaskSettings.Text = " Task settings";
            btnTaskSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnTaskSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaskSettings.UseVisualStyleBackColor = true;
            btnTaskSettings.Click += btnTaskSettings_Click;
            // 
            // btnStudentSettings
            // 
            btnStudentSettings.Dock = DockStyle.Top;
            btnStudentSettings.FlatAppearance.BorderSize = 0;
            btnStudentSettings.FlatStyle = FlatStyle.Flat;
            btnStudentSettings.ForeColor = Color.Gainsboro;
            btnStudentSettings.Image = Properties.Resources.student_manager;
            btnStudentSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudentSettings.Location = new Point(0, 320);
            btnStudentSettings.Name = "btnStudentSettings";
            btnStudentSettings.Padding = new Padding(12, 0, 0, 0);
            btnStudentSettings.Size = new Size(220, 60);
            btnStudentSettings.TabIndex = 5;
            btnStudentSettings.Text = " Student settings";
            btnStudentSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnStudentSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStudentSettings.UseVisualStyleBackColor = true;
            btnStudentSettings.Click += btnStudentSettings_Click;
            // 
            // btnEventRequestsList
            // 
            btnEventRequestsList.Dock = DockStyle.Top;
            btnEventRequestsList.FlatAppearance.BorderSize = 0;
            btnEventRequestsList.FlatStyle = FlatStyle.Flat;
            btnEventRequestsList.ForeColor = Color.Gainsboro;
            btnEventRequestsList.Image = Properties.Resources._event;
            btnEventRequestsList.ImageAlign = ContentAlignment.MiddleLeft;
            btnEventRequestsList.Location = new Point(0, 260);
            btnEventRequestsList.Name = "btnEventRequestsList";
            btnEventRequestsList.Padding = new Padding(12, 0, 0, 0);
            btnEventRequestsList.Size = new Size(220, 60);
            btnEventRequestsList.TabIndex = 3;
            btnEventRequestsList.Text = " Event requests list";
            btnEventRequestsList.TextAlign = ContentAlignment.MiddleLeft;
            btnEventRequestsList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEventRequestsList.UseVisualStyleBackColor = true;
            // 
            // btnComplaintsList
            // 
            btnComplaintsList.Dock = DockStyle.Top;
            btnComplaintsList.FlatAppearance.BorderSize = 0;
            btnComplaintsList.FlatStyle = FlatStyle.Flat;
            btnComplaintsList.ForeColor = Color.Gainsboro;
            btnComplaintsList.Image = Properties.Resources.complain;
            btnComplaintsList.ImageAlign = ContentAlignment.MiddleLeft;
            btnComplaintsList.Location = new Point(0, 200);
            btnComplaintsList.Name = "btnComplaintsList";
            btnComplaintsList.Padding = new Padding(12, 0, 0, 0);
            btnComplaintsList.Size = new Size(220, 60);
            btnComplaintsList.TabIndex = 2;
            btnComplaintsList.Text = " Complaints list";
            btnComplaintsList.TextAlign = ContentAlignment.MiddleLeft;
            btnComplaintsList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComplaintsList.UseVisualStyleBackColor = true;
            btnComplaintsList.Click += btnComplaintsList_Click;
            // 
            // btnAgreements
            // 
            btnAgreements.Dock = DockStyle.Top;
            btnAgreements.FlatAppearance.BorderSize = 0;
            btnAgreements.FlatStyle = FlatStyle.Flat;
            btnAgreements.ForeColor = Color.Gainsboro;
            btnAgreements.Image = Properties.Resources.agreement;
            btnAgreements.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgreements.Location = new Point(0, 140);
            btnAgreements.Name = "btnAgreements";
            btnAgreements.Padding = new Padding(12, 0, 0, 0);
            btnAgreements.Size = new Size(220, 60);
            btnAgreements.TabIndex = 1;
            btnAgreements.Text = " Agreements";
            btnAgreements.TextAlign = ContentAlignment.MiddleLeft;
            btnAgreements.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgreements.UseVisualStyleBackColor = true;
            btnAgreements.Click += btnAgreements_Click;
            // 
            // btnTasksSchedule
            // 
            btnTasksSchedule.Dock = DockStyle.Top;
            btnTasksSchedule.FlatAppearance.BorderSize = 0;
            btnTasksSchedule.FlatStyle = FlatStyle.Flat;
            btnTasksSchedule.ForeColor = Color.Gainsboro;
            btnTasksSchedule.Image = Properties.Resources.schedule;
            btnTasksSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnTasksSchedule.Location = new Point(0, 80);
            btnTasksSchedule.Name = "btnTasksSchedule";
            btnTasksSchedule.Padding = new Padding(12, 0, 0, 0);
            btnTasksSchedule.Size = new Size(220, 60);
            btnTasksSchedule.TabIndex = 7;
            btnTasksSchedule.Text = " Tasks schedule";
            btnTasksSchedule.TextAlign = ContentAlignment.MiddleLeft;
            btnTasksSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTasksSchedule.UseVisualStyleBackColor = true;
            btnTasksSchedule.Click += btnTasksSchedule_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Padding = new Padding(12, 0, 0, 0);
            pnlLogo.Size = new Size(220, 80);
            pnlLogo.TabIndex = 0;
            // 
            // pnlMainAdmin
            // 
            pnlMainAdmin.Dock = DockStyle.Fill;
            pnlMainAdmin.Location = new Point(220, 54);
            pnlMainAdmin.Name = "pnlMainAdmin";
            pnlMainAdmin.Size = new Size(775, 491);
            pnlMainAdmin.TabIndex = 8;
            // 
            // MainAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(pnlMainAdmin);
            Controls.Add(panel1);
            Controls.Add(pnlMenu);
            Name = "MainAdmin";
            Size = new Size(995, 545);
            panel1.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Panel pnlMenu;
        private Button btnTaskSettings;
        private Button btnStudentSettings;
        private Button btnEventRequestsList;
        private Button btnComplaintsList;
        private Button btnAgreements;
        private Button btnTasksSchedule;
        private Panel pnlLogo;
        private Panel pnlMainAdmin;
        private Button btnUpdate;
    }
}
