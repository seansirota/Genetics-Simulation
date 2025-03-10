using System.Data;

namespace Genetics_Simulation
{
    // Configuration form for entering the different settings the users wants to use for running the simulation. Also contains controls for displaying logs, resetting the state of the application, and importing a population file.
    public partial class ConfigurationForm : Form
    {
        private TableDataForm _tableDataForm;
        private int _lastLoggedIndex = 0;
        private readonly object _logLock = new object();

        // Constructor for the Configuration Form. Initializes the form and subscribes to the OnLogEvent event.
        public ConfigurationForm()
        {
            InitializeComponent();
            Simulation.OnLogEvent += AppendLog;
            _tableDataForm = new TableDataForm(Simulation.Population);
            ResetConfigDefaults();
        }

        // Method for getting the file path for exporting files including the population data and logs.
        public static string GetFilePath(string fileType, string fileExtension)
        {
            string? folderPath = Simulation.JSONExportPath;

            if (folderPath != null)
            {
                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

                string exportName = "simulation" + Simulation.SimulationName + "\\";
                string filePath = Path.Combine(folderPath, exportName);

                if (!Directory.Exists(filePath)) Directory.CreateDirectory(filePath);

                exportName = "simulation" + Simulation.SimulationName + "\\" + fileType + Simulation.SimulationName + fileExtension;
                filePath = Path.Combine(folderPath, exportName);

                return filePath;
            }
            else return string.Empty;
        }

        // Event handler for the Run Simulation button click event. Disposes of any open forms, disables the button while the simulation is running, and runs the simulation on a separate thread. Any previous data prior to running the simulation gets deleted.
        private async void RunSimulationButton_Click(object sender, EventArgs e)
        {
            DisposeOpenForms();

            RunSimulationButton.Enabled = false;
            ViewTableButton.Enabled = false;
            ResetDefaultsButton.Enabled = false;
            ImportJSONButton.Enabled = false;

            Simulation.InitialPopulation = (int)InitialPopulationNumericUpDown.Value;
            Simulation.TotalGenerations = (int)TotalGenerationsNumericUpDown.Value;
            Simulation.RecombinationChance = (int)RecombinationRateNumericUpDown.Value;
            Simulation.MutationChance = (int)MutationRateNumericUpDown.Value;
            Simulation.GenderRatio = (int)GenderRatioNumericUpDown.Value;
            Simulation.TotalRegions = (int)TotalRegionsNumericUpDown.Value;
            Simulation.EmigrationChance = (int)EmigrationRateNumericUpDown.Value;
            Simulation.BiasVarianceChance = (int)BiasVarianceRateNumericUpDown.Value;
            Simulation.MinimumDesirability = (int)MinimumDesirabilityNumericUpDown.Value;
            Simulation.MaximumDesirability = (int)MaximumDesirabilityNumericUpDown.Value;
            Simulation.MinimumChildren = (int)MinimumChildrenNumericUpDown.Value;
            Simulation.MaximumChildren = (int)MaximumChildrenNumericUpDown.Value;
            Simulation.MutationVarianceChance = (int)MutationVarianceRateNumericUpDown.Value;
            Simulation.Inbreeding = EnableInbreedingComboBox.Text;
            Simulation.CrossRegionBreeding = EnableCrossRegionBreedingCheckBox.Checked;
            Simulation.SameGenderBreeding = EnableSameGenderBreedingCheckBox.Checked;
            Simulation.EnableJSONExport = EnableJSONandLogExportCheckBox.Checked;
            Simulation.JSONExportPath = ExportPathTextBox.Text;

            LoggingRichTextBox.Clear();
            GUID.ClearUsedGUIDs();
            Simulation.Population.Clear();
            Simulation.RegionList.Clear();
            Person.PersonCount = 0;
            await Task.Run(() => Simulation.RunSimulation());

            if (Simulation.EnableJSONExport)
            {
                Export.ExportData(Simulation.Population, Simulation.JSONExportPath);
                Export.ExportLog(_lastLoggedIndex, LoggingRichTextBox);
            }

            _tableDataForm.RefreshPersonList();

            RunSimulationButton.Enabled = true;
            ViewTableButton.Enabled = true;
            ResetDefaultsButton.Enabled = true;
            ImportJSONButton.Enabled = true;
        }

        // Method for resetting the configuration form to the default values and deleting any previously saved data.
        private void ResetConfigDefaults()
        {
            DisposeOpenForms();

            InitialPopulationNumericUpDown.Value = Simulation.GetInitialPopulationDefault();
            TotalGenerationsNumericUpDown.Value = Simulation.GetTotalGenerationsDefault();
            RecombinationRateNumericUpDown.Value = Simulation.GetRecombinationChanceDefault();
            MutationRateNumericUpDown.Value = Simulation.GetMutationChanceDefault();
            GenderRatioNumericUpDown.Value = Simulation.GetGenderRatioDefault();

            EnableInbreedingComboBox.DataSource = null;
            EnableInbreedingComboBox.DataSource = Simulation.GetEnableInbreedingDefault();
            EnableInbreedingComboBox.SelectedIndex = 0;
            EnableCrossRegionBreedingCheckBox.Checked = Simulation.GetCrossRegionBreedingDefault();
            EnableSameGenderBreedingCheckBox.Checked = Simulation.GetSameGenderBreedingDefault();

            MinimumDesirabilityNumericUpDown.Value = Simulation.GetMinimumDesirabilityDefault();
            MaximumDesirabilityNumericUpDown.Value = Simulation.GetMaximumDesirabilityDefault();
            MinimumChildrenNumericUpDown.Value = Simulation.GetMinimumChildrenDefault();
            MaximumChildrenNumericUpDown.Value = Simulation.GetMaximumChildrenDefault();
            MutationVarianceRateNumericUpDown.Value = Simulation.GetMutationVarianceChanceDefault();

            TotalRegionsNumericUpDown.Value = Simulation.GetTotalRegionsDefault();
            EmigrationRateNumericUpDown.Value = Simulation.GetEmigrationChanceDefault();
            BiasVarianceRateNumericUpDown.Value = Simulation.GetBiasVarianceChanceDefault();

            EnableJSONandLogExportCheckBox.Checked = Simulation.GetEnableJSONExportDefault();
            ExportPathTextBox.Text = Simulation.GetJSONExportPathDefault();

            LoggingRichTextBox.Clear();
            GUID.ClearUsedGUIDs();
            Simulation.Population.Clear();
            Simulation.RegionList.Clear();
            Person.PersonCount = 0;
            _tableDataForm.RefreshPersonList();
        }

        private void DisposeOpenForms()
        {
            List<Form> formsToDispose = new List<Form>();
            foreach (Form openForm in Application.OpenForms) if (openForm is ChromosomePainterForm || openForm is TableDataForm) formsToDispose.Add(openForm);
            foreach (Form form in formsToDispose) form.Dispose();
        }

        // Method for appending log messages to the logging rich text box and streaming log data in chunks to log file if export logging is enabled.
        private void AppendLog(string message)
        {
            if (LoggingRichTextBox.InvokeRequired)
            {
                LoggingRichTextBox.Invoke(new Action(() => AppendLog(message)));
                return;
            }
            else
            {
                const int maxLogSize = 100000;
                const int trimSize = 20000;

                LoggingRichTextBox.SuspendLayout();
                LoggingRichTextBox.AppendText(message + Environment.NewLine);
                LoggingRichTextBox.SelectionStart = LoggingRichTextBox.Text.Length;
                LoggingRichTextBox.ScrollToCaret();
                LoggingRichTextBox.ResumeLayout();

                lock (_logLock)
                {
                    if (LoggingRichTextBox.TextLength > maxLogSize)
                    {
                        if (Simulation.EnableJSONExport && Simulation.JSONExportPath != null)
                        {
                            string filePath = GetFilePath("log", ".txt");

                            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                            using (StreamWriter writer = new StreamWriter(fs))
                            {
                                string textToWrite = LoggingRichTextBox.Text.Substring(0, trimSize);
                                writer.Write(textToWrite);
                            }
                        }

                        LoggingRichTextBox.Text = LoggingRichTextBox.Text.Substring(trimSize);
                        _lastLoggedIndex = 0;
                    }
                }
            }
        }

        // Event handler for the View Table button click event. Opens the table data form if it is not already open.
        private void ViewTableButton_Click(object sender, EventArgs e)
        {
            if (_tableDataForm == null || _tableDataForm.IsDisposed) _tableDataForm = new TableDataForm(Simulation.Population);
            if (!_tableDataForm.Visible) _tableDataForm.Show();
        }

        // Event handler for the Reset Defaults button click event. Resets the configuration form to the default values.
        private void ResetDefaultsButton_Click(object sender, EventArgs e)
        {
            ResetConfigDefaults();
        }

        // Event handler for the Import JSON button click event. Opens a file dialog for the user to select a JSON file to import population data from.
        private async void ImportJSONButton_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json";
                openFileDialog.Title = "Select a Population JSON file to import.";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    List<Person> importedPopulation = await Import.ImportData(selectedFilePath);

                    if (importedPopulation.Count > 0)
                    {
                        Simulation.Population = importedPopulation;
                        Simulation.RegionList = Simulation.Population.Select(p => p.Region).Distinct().ToDictionary();
                        _tableDataForm.RefreshPersonList();

                        Simulation.Log($"Population data imported from {selectedFilePath}.");
                        Simulation.Log("Total population: " + Simulation.Population.Count + ".");
                        Simulation.Log("Total generations: " + Simulation.Population.Select(p => p.Generation).Distinct().Count() + ".");
                        Simulation.Log("Total mutations: " + Simulation.Population.SelectMany(p => p.Genome).SelectMany(c => c.MChromatid.Concat(c.FChromatid)).Count(g => g.MutationEvent) + ".");
                        Simulation.Log("Total recombinations: " + Simulation.Population.SelectMany(p => p.Genome).Count(c => c.RecombinationEvent) + ".");
                        Simulation.Log("Total emigrations: " + Simulation.Population.Count(p => p.EmigrationEvent) + ".");
                    }
                    else Simulation.Log($"No population data found in {selectedFilePath}.");
                }
            }
        }

        // Event handler for the Enable JSON Export check box checked changed event. Enables the export path text box if the check box is checked.
        private void EnableJSONExportCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = EnableJSONandLogExportCheckBox.Checked;
            ExportPathTextBox.Enabled = isChecked;
        }

        // Event handler for the Minimum Desirability numeric up down value changed event. Ensures the minimum value is less than the maximum value.
        private void MinimumDesirabilityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MinimumDesirabilityNumericUpDown.Value > MaximumDesirabilityNumericUpDown.Value) MaximumDesirabilityNumericUpDown.Value = MinimumDesirabilityNumericUpDown.Value;
        }

        // Event handler for the Maximum Desirability numeric up down value changed event. Ensures the maximum value is greater than the minimum value.
        private void MaximumDesirabilityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MaximumDesirabilityNumericUpDown.Value < MinimumDesirabilityNumericUpDown.Value) MinimumDesirabilityNumericUpDown.Value = MaximumDesirabilityNumericUpDown.Value;
        }

        // Event handler for the Minimum Children numeric up down value changed event. Ensures the minimum value is less than the maximum value.
        private void MinimumChildrenNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MinimumChildrenNumericUpDown.Value > MaximumChildrenNumericUpDown.Value) MaximumChildrenNumericUpDown.Value = MinimumChildrenNumericUpDown.Value;
        }

        // Event handler for the Maximum Children numeric up down value changed event. Ensures the maximum value is greater than the minimum value.
        private void MaximumChildrenNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MaximumChildrenNumericUpDown.Value < MinimumChildrenNumericUpDown.Value) MinimumChildrenNumericUpDown.Value = MaximumChildrenNumericUpDown.Value;
        }

        //Event handler for when the Configuration Form is closed. Disposes of the form and exits the application.
        private void ConfigurationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Dispose();
            Application.Exit();
        }
    }
}
