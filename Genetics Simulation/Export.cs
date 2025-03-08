using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Microsoft.VisualBasic.Logging;

namespace Genetics_Simulation
{
    public static class Export
    {
        public static void ExportData(List<Person> population, string folderPath)
        {
            try
            {
                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

                string exportName = "simulation" + Simulation.SimulationName + "\\";
                string filePath = Path.Combine(folderPath, exportName);

                if (!Directory.Exists(filePath)) Directory.CreateDirectory(filePath);

                try
                {
                    string json = JsonConvert.SerializeObject(population, Formatting.Indented);
                    exportName = "simulation" + Simulation.SimulationName + "\\" + "data" + Simulation.SimulationName + ".json";
                    filePath = Path.Combine(folderPath, exportName);
                    File.WriteAllText(filePath, json);
                    Simulation.Log($"Data exported to {filePath}.");
                }
                catch (Exception ex)
                {
                    Simulation.Log($"Error exporting population to JSON: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Simulation.Log($"Error creating export directory: {ex.Message}");
            }
        }

        public static void ExportLog(int lastLoggedIndex, RichTextBox loggingRichTextBox)
        {
            try
            {
                if (!string.IsNullOrEmpty(Simulation.JSONExportPath))
                {
                    string filePath = ConfigurationForm.GetFilePath("log", ".txt");

                    using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        if (lastLoggedIndex < loggingRichTextBox.TextLength)
                        {
                            string finalLog = loggingRichTextBox.Text.Substring(lastLoggedIndex).TrimEnd() + Environment.NewLine;
                            writer.Write(finalLog);
                        }
                    }

                    Simulation.Log($"Log saved to {filePath}.");
                }
            }
            catch (Exception ex)
            {
                Simulation.Log($"Error exporting log: {ex.Message}");
            }
        }
    }
}
