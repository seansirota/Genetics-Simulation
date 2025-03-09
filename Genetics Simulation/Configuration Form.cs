using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genetics_Simulation
{
    public partial class ConfigurationForm : Form
    {
        private TableDataForm _tableDataForm;
        private int _lastLoggedIndex = 0;
        private readonly object _logLock = new object();

        public ConfigurationForm()
        {
            InitializeComponent();
            Simulation.OnLogEvent += AppendLog;
            _tableDataForm = new TableDataForm(Simulation.Population);
            ResetConfigDefaults();
        }

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

        private async void RunSimulationButton_Click(object sender, EventArgs e)
        {
            RunSimulationButton.Enabled = false;

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
        }

        private void ResetConfigDefaults()
        {
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

        private void ViewTableButton_Click(object sender, EventArgs e)
        {
            if (_tableDataForm == null || _tableDataForm.IsDisposed) _tableDataForm = new TableDataForm(Simulation.Population);
            if (!_tableDataForm.Visible) _tableDataForm.Show();
        }

        private void ResetDefaultsButton_Click(object sender, EventArgs e)
        {
            ResetConfigDefaults();
        }

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

        private void EnableJSONExportCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = EnableJSONandLogExportCheckBox.Checked;
            ExportPathTextBox.Enabled = isChecked;
        }

        private void MinimumDesirabilityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MinimumDesirabilityNumericUpDown.Value > MaximumDesirabilityNumericUpDown.Value) MaximumDesirabilityNumericUpDown.Value = MinimumDesirabilityNumericUpDown.Value;
        }

        private void MaximumDesirabilityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MaximumDesirabilityNumericUpDown.Value < MinimumDesirabilityNumericUpDown.Value) MinimumDesirabilityNumericUpDown.Value = MaximumDesirabilityNumericUpDown.Value;
        }

        private void MinimumChildrenNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MinimumChildrenNumericUpDown.Value > MaximumChildrenNumericUpDown.Value) MaximumChildrenNumericUpDown.Value = MinimumChildrenNumericUpDown.Value;
        }

        private void MaximumChildrenNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MaximumChildrenNumericUpDown.Value < MinimumChildrenNumericUpDown.Value) MinimumChildrenNumericUpDown.Value = MaximumChildrenNumericUpDown.Value;
        }

        private void ConfigurationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).Dispose();
            Application.Exit();
        }
    }
}
