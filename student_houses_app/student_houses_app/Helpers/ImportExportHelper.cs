using student_houses_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace student_houses_app.Helpers
{
    public class ImportExportHelper
    {
        public static ManagerContainer ImportCompanyData(string filePath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    ManagerContainer manager = (ManagerContainer)binaryFormatter.Deserialize(fileStream);
                    return manager;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error importing app data file: {ex.Message}", ex);
            }
        }

        public static void ExportCompanyData(string selectedPath, ManagerContainer manager)
        {
            try
            {
                if (Directory.Exists(selectedPath))
                {
                    string filePath = Path.Combine(selectedPath, $"app_data_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.dat");

                    using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        binaryFormatter.Serialize(fileStream, manager);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error exporting app data file: {ex.Message}", ex);
            }
        }
    }
}
