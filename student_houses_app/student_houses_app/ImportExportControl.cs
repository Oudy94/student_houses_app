using student_houses_app.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_houses_app
{
    public partial class ImportExportControl : UserControl
    {
        private Main Main { get; set; }

        public ImportExportControl(Main main)
        {
            InitializeComponent();

            this.Main = main;
        }

        private void btnBrowseimportAppData_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select dat file";
                openFileDialog.Filter = "DAT Dat|*.dat";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtImportAppDataFile.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowseExportAppData_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select folder";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtExportAppDataFile.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void pnlDragAppData_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                string filePath = files[0];
                txtImportAppDataFile.Text = filePath;

            }
        }

        private void pnlDragAppData_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnImportAppData_Click(object sender, EventArgs e)
        {
            try
            {
                this.Main.MC = ImportExportHelper.ImportCompanyData(txtImportAppDataFile.Text);
                //this.Main.MC.UpdateDgvTasksInfo();

                MessageBox.Show("Data imported successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExportAppData_Click(object sender, EventArgs e)
        {
            try
            {
                ImportExportHelper.ExportCompanyData(txtExportAppDataFile.Text, this.Main.MC);
                MessageBox.Show("Data exported successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
