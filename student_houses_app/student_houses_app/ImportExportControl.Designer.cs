namespace student_houses_app
{
    partial class ImportExportControl
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
            groupBox3 = new GroupBox();
            btnExportAppData = new Button();
            txtExportAppDataFile = new TextBox();
            label3 = new Label();
            btnBrowseExportAppData = new Button();
            groupBox4 = new GroupBox();
            btnImportAppData = new Button();
            pnlDragAppData = new Panel();
            label5 = new Label();
            txtImportAppDataFile = new TextBox();
            label6 = new Label();
            btnBrowseimportAppData = new Button();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            pnlDragAppData.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExportAppData);
            groupBox3.Controls.Add(txtExportAppDataFile);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnBrowseExportAppData);
            groupBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(367, 44);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(376, 194);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Export app data";
            // 
            // btnExportAppData
            // 
            btnExportAppData.BackColor = Color.FromArgb(51, 51, 76);
            btnExportAppData.FlatAppearance.BorderSize = 0;
            btnExportAppData.FlatStyle = FlatStyle.Flat;
            btnExportAppData.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportAppData.ForeColor = SystemColors.Window;
            btnExportAppData.Location = new Point(112, 137);
            btnExportAppData.Name = "btnExportAppData";
            btnExportAppData.Size = new Size(184, 37);
            btnExportAppData.TabIndex = 6;
            btnExportAppData.Text = "EXPORT";
            btnExportAppData.UseVisualStyleBackColor = false;
            btnExportAppData.Click += btnExportAppData_Click;
            // 
            // txtExportAppDataFile
            // 
            txtExportAppDataFile.BorderStyle = BorderStyle.None;
            txtExportAppDataFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExportAppDataFile.Location = new Point(19, 54);
            txtExportAppDataFile.Name = "txtExportAppDataFile";
            txtExportAppDataFile.Size = new Size(340, 22);
            txtExportAppDataFile.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(19, 30);
            label3.Name = "label3";
            label3.Size = new Size(41, 21);
            label3.TabIndex = 3;
            label3.Text = "File:";
            // 
            // btnBrowseExportAppData
            // 
            btnBrowseExportAppData.BackColor = Color.FromArgb(51, 51, 76);
            btnBrowseExportAppData.FlatAppearance.BorderSize = 0;
            btnBrowseExportAppData.FlatStyle = FlatStyle.Flat;
            btnBrowseExportAppData.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowseExportAppData.ForeColor = SystemColors.Window;
            btnBrowseExportAppData.Location = new Point(166, 83);
            btnBrowseExportAppData.Name = "btnBrowseExportAppData";
            btnBrowseExportAppData.Size = new Size(78, 28);
            btnBrowseExportAppData.TabIndex = 1;
            btnBrowseExportAppData.Text = "Browse";
            btnBrowseExportAppData.UseVisualStyleBackColor = false;
            btnBrowseExportAppData.Click += btnBrowseExportAppData_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnImportAppData);
            groupBox4.Controls.Add(pnlDragAppData);
            groupBox4.Controls.Add(txtImportAppDataFile);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(btnBrowseimportAppData);
            groupBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(3, 29);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(346, 348);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Import app data";
            // 
            // btnImportAppData
            // 
            btnImportAppData.BackColor = Color.FromArgb(51, 51, 76);
            btnImportAppData.FlatAppearance.BorderSize = 0;
            btnImportAppData.FlatStyle = FlatStyle.Flat;
            btnImportAppData.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnImportAppData.ForeColor = SystemColors.Window;
            btnImportAppData.Location = new Point(85, 298);
            btnImportAppData.Name = "btnImportAppData";
            btnImportAppData.Size = new Size(168, 34);
            btnImportAppData.TabIndex = 6;
            btnImportAppData.Text = "IMPORT";
            btnImportAppData.UseVisualStyleBackColor = false;
            btnImportAppData.Click += btnImportAppData_Click;
            // 
            // pnlDragAppData
            // 
            pnlDragAppData.AllowDrop = true;
            pnlDragAppData.BackColor = SystemColors.Window;
            pnlDragAppData.BorderStyle = BorderStyle.FixedSingle;
            pnlDragAppData.Controls.Add(label5);
            pnlDragAppData.Location = new Point(19, 149);
            pnlDragAppData.Name = "pnlDragAppData";
            pnlDragAppData.Size = new Size(304, 112);
            pnlDragAppData.TabIndex = 5;
            pnlDragAppData.DragDrop += pnlDragAppData_DragDrop;
            pnlDragAppData.DragEnter += pnlDragAppData_DragEnter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(65, 36);
            label5.Name = "label5";
            label5.Size = new Size(181, 37);
            label5.TabIndex = 0;
            label5.Text = "Drag file here";
            // 
            // txtImportAppDataFile
            // 
            txtImportAppDataFile.BorderStyle = BorderStyle.None;
            txtImportAppDataFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImportAppDataFile.Location = new Point(19, 61);
            txtImportAppDataFile.Name = "txtImportAppDataFile";
            txtImportAppDataFile.Size = new Size(304, 22);
            txtImportAppDataFile.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(19, 30);
            label6.Name = "label6";
            label6.Size = new Size(41, 21);
            label6.TabIndex = 3;
            label6.Text = "File:";
            // 
            // btnBrowseimportAppData
            // 
            btnBrowseimportAppData.BackColor = Color.FromArgb(51, 51, 76);
            btnBrowseimportAppData.FlatAppearance.BorderSize = 0;
            btnBrowseimportAppData.FlatStyle = FlatStyle.Flat;
            btnBrowseimportAppData.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowseimportAppData.ForeColor = SystemColors.Window;
            btnBrowseimportAppData.Location = new Point(134, 94);
            btnBrowseimportAppData.Name = "btnBrowseimportAppData";
            btnBrowseimportAppData.Size = new Size(78, 28);
            btnBrowseimportAppData.TabIndex = 1;
            btnBrowseimportAppData.Text = "Browse";
            btnBrowseimportAppData.UseVisualStyleBackColor = false;
            btnBrowseimportAppData.Click += btnBrowseimportAppData_Click;
            // 
            // ImportExportControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ImportExportControl";
            Size = new Size(755, 430);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            pnlDragAppData.ResumeLayout(false);
            pnlDragAppData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button btnExportAppData;
        private TextBox txtExportAppDataFile;
        private Label label3;
        private Button btnBrowseExportAppData;
        private GroupBox groupBox4;
        private Button btnImportAppData;
        private Panel pnlDragAppData;
        private Label label5;
        private TextBox txtImportAppDataFile;
        private Label label6;
        private Button btnBrowseimportAppData;
    }
}
