namespace student_houses_app
{
    partial class TasksSchedule
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvSchedule = new DataGridView();
            btnCurrentWeek = new Button();
            btnNextWeek = new Button();
            btnPreviousWeek = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // dgvSchedule
            // 
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.AllowUserToDeleteRows = false;
            dgvSchedule.AllowUserToResizeColumns = false;
            dgvSchedule.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.BackgroundColor = SystemColors.ControlLight;
            dgvSchedule.BorderStyle = BorderStyle.None;
            dgvSchedule.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvSchedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Padding = new Padding(16, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(51, 51, 76);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSchedule.ColumnHeadersHeight = 37;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSchedule.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSchedule.EnableHeadersVisualStyles = false;
            dgvSchedule.Location = new Point(3, 3);
            dgvSchedule.MultiSelect = false;
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Transparent;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.Transparent;
            dgvSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSchedule.RowHeadersVisible = false;
            dgvSchedule.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvSchedule.RowTemplate.Height = 50;
            dgvSchedule.ScrollBars = ScrollBars.Vertical;
            dgvSchedule.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSchedule.ShowEditingIcon = false;
            dgvSchedule.Size = new Size(749, 385);
            dgvSchedule.TabIndex = 1;
            dgvSchedule.CellClick += dgvSchedule_CellClick;
            dgvSchedule.CellMouseEnter += dgvSchedule_CellMouseEnter;
            dgvSchedule.CellMouseLeave += dgvSchedule_CellMouseLeave;
            dgvSchedule.SelectionChanged += DataGridView_SelectionChanged;
            // 
            // btnCurrentWeek
            // 
            btnCurrentWeek.Location = new Point(337, 394);
            btnCurrentWeek.Name = "btnCurrentWeek";
            btnCurrentWeek.Size = new Size(109, 23);
            btnCurrentWeek.TabIndex = 2;
            btnCurrentWeek.Text = "Current Week";
            btnCurrentWeek.UseVisualStyleBackColor = true;
            btnCurrentWeek.Click += btnCurrentWeek_Click;
            // 
            // btnNextWeek
            // 
            btnNextWeek.Location = new Point(485, 394);
            btnNextWeek.Name = "btnNextWeek";
            btnNextWeek.Size = new Size(55, 23);
            btnNextWeek.TabIndex = 3;
            btnNextWeek.Text = ">>";
            btnNextWeek.UseVisualStyleBackColor = true;
            btnNextWeek.Click += btnNextWeek_Click;
            // 
            // btnPreviousWeek
            // 
            btnPreviousWeek.Location = new Point(242, 394);
            btnPreviousWeek.Name = "btnPreviousWeek";
            btnPreviousWeek.Size = new Size(55, 23);
            btnPreviousWeek.TabIndex = 4;
            btnPreviousWeek.Text = "<<";
            btnPreviousWeek.UseVisualStyleBackColor = true;
            btnPreviousWeek.Click += btnPreviousWeek_Click;
            // 
            // TasksSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnPreviousWeek);
            Controls.Add(btnNextWeek);
            Controls.Add(btnCurrentWeek);
            Controls.Add(dgvSchedule);
            Name = "TasksSchedule";
            Size = new Size(755, 420);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSchedule;
        private Button btnCurrentWeek;
        private Button btnNextWeek;
        private Button btnPreviousWeek;
    }
}
