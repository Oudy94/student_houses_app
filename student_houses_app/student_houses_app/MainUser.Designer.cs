namespace student_houses_app
{
    partial class MainUser
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
            btnLoginForm = new Button();
            pnlMenu = new Panel();
            btncomplaint = new Button();
            btnAgreements = new Button();
            btnTasksSchedule = new Button();
            pnlLogo = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            pnlMainUser = new Panel();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoginForm
            // 
            btnLoginForm.BackColor = Color.DimGray;
            btnLoginForm.Cursor = Cursors.Hand;
            btnLoginForm.FlatAppearance.BorderSize = 0;
            btnLoginForm.FlatStyle = FlatStyle.Flat;
            btnLoginForm.ForeColor = Color.White;
            btnLoginForm.Location = new Point(657, 3);
            btnLoginForm.Name = "btnLoginForm";
            btnLoginForm.Size = new Size(78, 35);
            btnLoginForm.TabIndex = 6;
            btnLoginForm.Text = "admin";
            btnLoginForm.UseVisualStyleBackColor = false;
            btnLoginForm.Click += btnLoginForm_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(51, 51, 76);
            pnlMenu.Controls.Add(btncomplaint);
            pnlMenu.Controls.Add(btnAgreements);
            pnlMenu.Controls.Add(btnTasksSchedule);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 545);
            pnlMenu.TabIndex = 3;
            // 
            // btncomplaint
            // 
            btncomplaint.Dock = DockStyle.Top;
            btncomplaint.FlatAppearance.BorderSize = 0;
            btncomplaint.FlatStyle = FlatStyle.Flat;
            btncomplaint.ForeColor = Color.Gainsboro;
            btncomplaint.Image = Properties.Resources.complain;
            btncomplaint.ImageAlign = ContentAlignment.MiddleLeft;
            btncomplaint.Location = new Point(0, 200);
            btncomplaint.Name = "btncomplaint";
            btncomplaint.Padding = new Padding(12, 0, 0, 0);
            btncomplaint.Size = new Size(220, 60);
            btncomplaint.TabIndex = 2;
            btncomplaint.Text = " Complaint";
            btncomplaint.TextAlign = ContentAlignment.MiddleLeft;
            btncomplaint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncomplaint.UseVisualStyleBackColor = true;
            btncomplaint.Click += btncomplaint_Click;
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
            btnTasksSchedule.TabIndex = 4;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLoginForm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 80);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(318, 22);
            label1.Name = "label1";
            label1.Size = new Size(144, 40);
            label1.TabIndex = 7;
            label1.Text = "Welcome";
            // 
            // pnlMainUser
            // 
            pnlMainUser.Dock = DockStyle.Fill;
            pnlMainUser.Location = new Point(220, 80);
            pnlMainUser.Name = "pnlMainUser";
            pnlMainUser.Size = new Size(741, 465);
            pnlMainUser.TabIndex = 5;
            // 
            // MainUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(pnlMainUser);
            Controls.Add(panel1);
            Controls.Add(pnlMenu);
            Margin = new Padding(2, 1, 2, 1);
            Name = "MainUser";
            Size = new Size(961, 545);
            pnlMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLoginForm;
        private Panel pnlMenu;
        private Button btncomplaint;
        private Button btnAgreements;
        private Button btnTasksSchedule;
        private Panel pnlLogo;
        private Panel panel1;
        private Panel pnlMainUser;
        private Label label1;
    }
}
