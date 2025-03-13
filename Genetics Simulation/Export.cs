using Newtonsoft.Json;

namespace Genetics_Simulation
{
    // Export class to export population data to a JSON file.
    public static class Export
    {
        //Export population data to the given directory. This along with the ExportLog method go into a folder created for this specific simulation run.
        public static void ExportData(List<Person> population, string folderPath)
        {
            try
            {
                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

                string exportName = "simulation" + Simulation.SimulationName + "\\";
                string filePath = Path.Combine(folderPath, exportName);

                if (!Directory.Exists(filePath)) Directory.CreateDirectory(filePath);

                exportName = "simulation" + Simulation.SimulationName + "\\" + "data" + Simulation.SimulationName + ".json";
                filePath = Path.Combine(folderPath, exportName);

                using (StreamWriter file = File.CreateText(filePath))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    JsonSerializer serializer = new JsonSerializer { Formatting = Formatting.Indented };
                    serializer.Serialize(writer, population);
                }

                Simulation.Log($"Data exported to {filePath}.");
            }
            catch (Exception ex)
            {
                Simulation.Log($"Error exporting population to JSON: {ex.Message}");
            }
        }

        //Export log data to the given directory. This along with the ExportData method go into a folder created for this specific simulation run.
        public static void ExportLog(int lastLoggedIndex, RichTextBox loggingRichTextBox)
        {
            try
            {
                if (!string.IsNullOrEmpty(Simulation.ExportPath))
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
