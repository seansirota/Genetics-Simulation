namespace Genetics_Simulation
{
    partial class ConfigurationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            GeneralConfigurationGroupBox = new GroupBox();
            GenderRatioNumericUpDown = new NumericUpDown();
            GenderRatioLabel = new Label();
            MutationRateNumericUpDown = new NumericUpDown();
            MutationRateLabel = new Label();
            RecombinationRateNumericUpDown = new NumericUpDown();
            RecombinationRateLabel = new Label();
            TotalGenerationsNumericUpDown = new NumericUpDown();
            TotalGenerationsLabel = new Label();
            InitialPopulationNumericUpDown = new NumericUpDown();
            InitialPopulationLabel = new Label();
            LimitationsConfigurationGroupBox = new GroupBox();
            EnableSameGenderBreedingCheckBox = new CheckBox();
            EnableSameGenderBreedingLabel = new Label();
            EnableCrossRegionBreedingCheckBox = new CheckBox();
            EnableCrossRegionBreedingLabel = new Label();
            EnableInbreedingComboBox = new ComboBox();
            EnableInbreedingLabel = new Label();
            MinimumDesirabilityNumericUpDown = new NumericUpDown();
            MinimumDesirabilityLabel = new Label();
            RegionConfigurationGroupBox = new GroupBox();
            BiasVarianceRateNumericUpDown = new NumericUpDown();
            BiasVarianceRateLabel = new Label();
            EnableRegionalDesirabilityBiasCheckBox = new CheckBox();
            EnableRegionalDesirabilityBiasLabel = new Label();
            EmigrationRateNumericUpDown = new NumericUpDown();
            EmigrationRateLabel = new Label();
            TotalRegionsNumericUpDown = new NumericUpDown();
            TotalRegionsLabel = new Label();
            ExportConfigurationGroupBox = new GroupBox();
            EnableJSONandLogExportCheckBox = new CheckBox();
            EnableJSONandLogExportLabel = new Label();
            ExportPathTextBox = new TextBox();
            ExportPathLabel = new Label();
            RunSimulationButton = new Button();
            ImportJSONButton = new Button();
            ViewTableButton = new Button();
            ResetDefaultsButton = new Button();
            LoggingRichTextBox = new RichTextBox();
            Logging = new GroupBox();
            ThresholdConfigurationGroupBox = new GroupBox();
            MutationVarianceRateNumericUpDown = new NumericUpDown();
            MutationVarianceRate = new Label();
            MaximumChildrenNumericUpDown = new NumericUpDown();
            MaximumChildrenLabel = new Label();
            MinimumChildrenNumericUpDown = new NumericUpDown();
            MinimumChildrenLabel = new Label();
            MaximumDesirabilityNumericUpDown = new NumericUpDown();
            MaximumDesirabilityLabel = new Label();
            GeneralConfigurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GenderRatioNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MutationRateNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecombinationRateNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalGenerationsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InitialPopulationNumericUpDown).BeginInit();
            LimitationsConfigurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MinimumDesirabilityNumericUpDown).BeginInit();
            RegionConfigurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BiasVarianceRateNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmigrationRateNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TotalRegionsNumericUpDown).BeginInit();
            ExportConfigurationGroupBox.SuspendLayout();
            Logging.SuspendLayout();
            ThresholdConfigurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MutationVarianceRateNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaximumChildrenNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimumChildrenNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaximumDesirabilityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // GeneralConfigurationGroupBox
            // 
            GeneralConfigurationGroupBox.Controls.Add(GenderRatioNumericUpDown);
            GeneralConfigurationGroupBox.Controls.Add(GenderRatioLabel);
            GeneralConfigurationGroupBox.Controls.Add(MutationRateNumericUpDown);
            GeneralConfigurationGroupBox.Controls.Add(MutationRateLabel);
            GeneralConfigurationGroupBox.Controls.Add(RecombinationRateNumericUpDown);
            GeneralConfigurationGroupBox.Controls.Add(RecombinationRateLabel);
            GeneralConfigurationGroupBox.Controls.Add(TotalGenerationsNumericUpDown);
            GeneralConfigurationGroupBox.Controls.Add(TotalGenerationsLabel);
            GeneralConfigurationGroupBox.Controls.Add(InitialPopulationNumericUpDown);
            GeneralConfigurationGroupBox.Controls.Add(InitialPopulationLabel);
            GeneralConfigurationGroupBox.Location = new Point(12, 12);
            GeneralConfigurationGroupBox.Name = "GeneralConfigurationGroupBox";
            GeneralConfigurationGroupBox.Size = new Size(231, 165);
            GeneralConfigurationGroupBox.TabIndex = 0;
            GeneralConfigurationGroupBox.TabStop = false;
            GeneralConfigurationGroupBox.Text = "General Configuration";
            // 
            // GenderRatioNumericUpDown
            // 
            GenderRatioNumericUpDown.Location = new Point(150, 133);
            GenderRatioNumericUpDown.Name = "GenderRatioNumericUpDown";
            GenderRatioNumericUpDown.Size = new Size(70, 23);
            GenderRatioNumericUpDown.TabIndex = 9;
            GenderRatioNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // GenderRatioLabel
            // 
            GenderRatioLabel.AutoSize = true;
            GenderRatioLabel.Location = new Point(6, 135);
            GenderRatioLabel.Name = "GenderRatioLabel";
            GenderRatioLabel.Size = new Size(128, 15);
            GenderRatioLabel.TabIndex = 8;
            GenderRatioLabel.Text = "Gender Ratio (% Male):";
            // 
            // MutationRateNumericUpDown
            // 
            MutationRateNumericUpDown.Location = new Point(150, 104);
            MutationRateNumericUpDown.Name = "MutationRateNumericUpDown";
            MutationRateNumericUpDown.Size = new Size(70, 23);
            MutationRateNumericUpDown.TabIndex = 7;
            MutationRateNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // MutationRateLabel
            // 
            MutationRateLabel.AutoSize = true;
            MutationRateLabel.Location = new Point(6, 106);
            MutationRateLabel.Name = "MutationRateLabel";
            MutationRateLabel.Size = new Size(106, 15);
            MutationRateLabel.TabIndex = 6;
            MutationRateLabel.Text = "Mutation Rate (%):";
            // 
            // RecombinationRateNumericUpDown
            // 
            RecombinationRateNumericUpDown.Location = new Point(150, 75);
            RecombinationRateNumericUpDown.Name = "RecombinationRateNumericUpDown";
            RecombinationRateNumericUpDown.Size = new Size(70, 23);
            RecombinationRateNumericUpDown.TabIndex = 5;
            RecombinationRateNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // RecombinationRateLabel
            // 
            RecombinationRateLabel.AutoSize = true;
            RecombinationRateLabel.Location = new Point(6, 77);
            RecombinationRateLabel.Name = "RecombinationRateLabel";
            RecombinationRateLabel.Size = new Size(138, 15);
            RecombinationRateLabel.TabIndex = 4;
            RecombinationRateLabel.Text = "Recombination Rate (%):";
            // 
            // TotalGenerationsNumericUpDown
            // 
            TotalGenerationsNumericUpDown.Location = new Point(150, 46);
            TotalGenerationsNumericUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            TotalGenerationsNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TotalGenerationsNumericUpDown.Name = "TotalGenerationsNumericUpDown";
            TotalGenerationsNumericUpDown.Size = new Size(70, 23);
            TotalGenerationsNumericUpDown.TabIndex = 3;
            TotalGenerationsNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TotalGenerationsLabel
            // 
            TotalGenerationsLabel.AutoSize = true;
            TotalGenerationsLabel.Location = new Point(6, 48);
            TotalGenerationsLabel.Name = "TotalGenerationsLabel";
            TotalGenerationsLabel.Size = new Size(102, 15);
            TotalGenerationsLabel.TabIndex = 2;
            TotalGenerationsLabel.Text = "Total Generations:";
            // 
            // InitialPopulationNumericUpDown
            // 
            InitialPopulationNumericUpDown.Location = new Point(150, 17);
            InitialPopulationNumericUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            InitialPopulationNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            InitialPopulationNumericUpDown.Name = "InitialPopulationNumericUpDown";
            InitialPopulationNumericUpDown.Size = new Size(70, 23);
            InitialPopulationNumericUpDown.TabIndex = 1;
            InitialPopulationNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // InitialPopulationLabel
            // 
            InitialPopulationLabel.AutoSize = true;
            InitialPopulationLabel.Location = new Point(6, 19);
            InitialPopulationLabel.Name = "InitialPopulationLabel";
            InitialPopulationLabel.Size = new Size(100, 15);
            InitialPopulationLabel.TabIndex = 0;
            InitialPopulationLabel.Text = "Initial Population:";
            // 
            // LimitationsConfigurationGroupBox
            // 
            LimitationsConfigurationGroupBox.Controls.Add(EnableSameGenderBreedingCheckBox);
            LimitationsConfigurationGroupBox.Controls.Add(EnableSameGenderBreedingLabel);
            LimitationsConfigurationGroupBox.Controls.Add(EnableCrossRegionBreedingCheckBox);
            LimitationsConfigurationGroupBox.Controls.Add(EnableCrossRegionBreedingLabel);
            LimitationsConfigurationGroupBox.Controls.Add(EnableInbreedingComboBox);
            LimitationsConfigurationGroupBox.Controls.Add(EnableInbreedingLabel);
            LimitationsConfigurationGroupBox.Location = new Point(12, 183);
            LimitationsConfigurationGroupBox.Name = "LimitationsConfigurationGroupBox";
            LimitationsConfigurationGroupBox.Size = new Size(251, 110);
            LimitationsConfigurationGroupBox.TabIndex = 1;
            LimitationsConfigurationGroupBox.TabStop = false;
            LimitationsConfigurationGroupBox.Text = "Limitations Configuration";
            // 
            // EnableSameGenderBreedingCheckBox
            // 
            EnableSameGenderBreedingCheckBox.AutoSize = true;
            EnableSameGenderBreedingCheckBox.Location = new Point(183, 84);
            EnableSameGenderBreedingCheckBox.Name = "EnableSameGenderBreedingCheckBox";
            EnableSameGenderBreedingCheckBox.Size = new Size(15, 14);
            EnableSameGenderBreedingCheckBox.TabIndex = 7;
            EnableSameGenderBreedingCheckBox.UseVisualStyleBackColor = true;
            // 
            // EnableSameGenderBreedingLabel
            // 
            EnableSameGenderBreedingLabel.AutoSize = true;
            EnableSameGenderBreedingLabel.Location = new Point(7, 83);
            EnableSameGenderBreedingLabel.Name = "EnableSameGenderBreedingLabel";
            EnableSameGenderBreedingLabel.Size = new Size(170, 15);
            EnableSameGenderBreedingLabel.TabIndex = 6;
            EnableSameGenderBreedingLabel.Text = "Enable Same Gender Breeding?";
            // 
            // EnableCrossRegionBreedingCheckBox
            // 
            EnableCrossRegionBreedingCheckBox.AutoSize = true;
            EnableCrossRegionBreedingCheckBox.Location = new Point(183, 55);
            EnableCrossRegionBreedingCheckBox.Name = "EnableCrossRegionBreedingCheckBox";
            EnableCrossRegionBreedingCheckBox.Size = new Size(15, 14);
            EnableCrossRegionBreedingCheckBox.TabIndex = 3;
            EnableCrossRegionBreedingCheckBox.UseVisualStyleBackColor = true;
            // 
            // EnableCrossRegionBreedingLabel
            // 
            EnableCrossRegionBreedingLabel.AutoSize = true;
            EnableCrossRegionBreedingLabel.Location = new Point(6, 54);
            EnableCrossRegionBreedingLabel.Name = "EnableCrossRegionBreedingLabel";
            EnableCrossRegionBreedingLabel.Size = new Size(171, 15);
            EnableCrossRegionBreedingLabel.TabIndex = 2;
            EnableCrossRegionBreedingLabel.Text = "Enable Cross-Region Breeding?";
            // 
            // EnableInbreedingComboBox
            // 
            EnableInbreedingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EnableInbreedingComboBox.FormattingEnabled = true;
            EnableInbreedingComboBox.Location = new Point(119, 22);
            EnableInbreedingComboBox.Name = "EnableInbreedingComboBox";
            EnableInbreedingComboBox.Size = new Size(121, 23);
            EnableInbreedingComboBox.TabIndex = 1;
            // 
            // EnableInbreedingLabel
            // 
            EnableInbreedingLabel.AutoSize = true;
            EnableInbreedingLabel.Location = new Point(6, 25);
            EnableInbreedingLabel.Name = "EnableInbreedingLabel";
            EnableInbreedingLabel.Size = new Size(107, 15);
            EnableInbreedingLabel.TabIndex = 0;
            EnableInbreedingLabel.Text = "Enable Inbreeding?";
            // 
            // MinimumDesirabilityNumericUpDown
            // 
            MinimumDesirabilityNumericUpDown.Location = new Point(167, 17);
            MinimumDesirabilityNumericUpDown.Name = "MinimumDesirabilityNumericUpDown";
            MinimumDesirabilityNumericUpDown.Size = new Size(70, 23);
            MinimumDesirabilityNumericUpDown.TabIndex = 15;
            MinimumDesirabilityNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            MinimumDesirabilityNumericUpDown.ValueChanged += MinimumDesirabilityNumericUpDown_ValueChanged;
            // 
            // MinimumDesirabilityLabel
            // 
            MinimumDesirabilityLabel.AutoSize = true;
            MinimumDesirabilityLabel.Location = new Point(7, 19);
            MinimumDesirabilityLabel.Name = "MinimumDesirabilityLabel";
            MinimumDesirabilityLabel.Size = new Size(145, 15);
            MinimumDesirabilityLabel.TabIndex = 15;
            MinimumDesirabilityLabel.Text = "Minimum Desirability (%):";
            // 
            // RegionConfigurationGroupBox
            // 
            RegionConfigurationGroupBox.Controls.Add(BiasVarianceRateNumericUpDown);
            RegionConfigurationGroupBox.Controls.Add(BiasVarianceRateLabel);
            RegionConfigurationGroupBox.Controls.Add(EnableRegionalDesirabilityBiasCheckBox);
            RegionConfigurationGroupBox.Controls.Add(EnableRegionalDesirabilityBiasLabel);
            RegionConfigurationGroupBox.Controls.Add(EmigrationRateNumericUpDown);
            RegionConfigurationGroupBox.Controls.Add(EmigrationRateLabel);
            RegionConfigurationGroupBox.Controls.Add(TotalRegionsNumericUpDown);
            RegionConfigurationGroupBox.Controls.Add(TotalRegionsLabel);
            RegionConfigurationGroupBox.Location = new Point(12, 470);
            RegionConfigurationGroupBox.Name = "RegionConfigurationGroupBox";
            RegionConfigurationGroupBox.Size = new Size(220, 143);
            RegionConfigurationGroupBox.TabIndex = 3;
            RegionConfigurationGroupBox.TabStop = false;
            RegionConfigurationGroupBox.Text = "Region Configuration";
            // 
            // BiasVarianceRateNumericUpDown
            // 
            BiasVarianceRateNumericUpDown.Enabled = false;
            BiasVarianceRateNumericUpDown.Location = new Point(138, 109);
            BiasVarianceRateNumericUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            BiasVarianceRateNumericUpDown.Name = "BiasVarianceRateNumericUpDown";
            BiasVarianceRateNumericUpDown.Size = new Size(70, 23);
            BiasVarianceRateNumericUpDown.TabIndex = 14;
            BiasVarianceRateNumericUpDown.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // BiasVarianceRateLabel
            // 
            BiasVarianceRateLabel.AutoSize = true;
            BiasVarianceRateLabel.Location = new Point(6, 111);
            BiasVarianceRateLabel.Name = "BiasVarianceRateLabel";
            BiasVarianceRateLabel.Size = new Size(125, 15);
            BiasVarianceRateLabel.TabIndex = 13;
            BiasVarianceRateLabel.Text = "Bias Variance Rate (%):";
            // 
            // EnableRegionalDesirabilityBiasCheckBox
            // 
            EnableRegionalDesirabilityBiasCheckBox.AutoSize = true;
            EnableRegionalDesirabilityBiasCheckBox.Location = new Point(193, 83);
            EnableRegionalDesirabilityBiasCheckBox.Name = "EnableRegionalDesirabilityBiasCheckBox";
            EnableRegionalDesirabilityBiasCheckBox.Size = new Size(15, 14);
            EnableRegionalDesirabilityBiasCheckBox.TabIndex = 12;
            EnableRegionalDesirabilityBiasCheckBox.UseVisualStyleBackColor = true;
            EnableRegionalDesirabilityBiasCheckBox.CheckedChanged += EnableRegionalDesirabilityBiasCheckBox_CheckedChanged;
            // 
            // EnableRegionalDesirabilityBiasLabel
            // 
            EnableRegionalDesirabilityBiasLabel.AutoSize = true;
            EnableRegionalDesirabilityBiasLabel.Location = new Point(6, 82);
            EnableRegionalDesirabilityBiasLabel.Name = "EnableRegionalDesirabilityBiasLabel";
            EnableRegionalDesirabilityBiasLabel.Size = new Size(181, 15);
            EnableRegionalDesirabilityBiasLabel.TabIndex = 11;
            EnableRegionalDesirabilityBiasLabel.Text = "Enable Regional Desirability Bias?";
            // 
            // EmigrationRateNumericUpDown
            // 
            EmigrationRateNumericUpDown.Location = new Point(138, 51);
            EmigrationRateNumericUpDown.Name = "EmigrationRateNumericUpDown";
            EmigrationRateNumericUpDown.Size = new Size(70, 23);
            EmigrationRateNumericUpDown.TabIndex = 10;
            EmigrationRateNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // EmigrationRateLabel
            // 
            EmigrationRateLabel.AutoSize = true;
            EmigrationRateLabel.Location = new Point(6, 53);
            EmigrationRateLabel.Name = "EmigrationRateLabel";
            EmigrationRateLabel.Size = new Size(115, 15);
            EmigrationRateLabel.TabIndex = 9;
            EmigrationRateLabel.Text = "Emigration Rate (%):";
            // 
            // TotalRegionsNumericUpDown
            // 
            TotalRegionsNumericUpDown.Location = new Point(138, 22);
            TotalRegionsNumericUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            TotalRegionsNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TotalRegionsNumericUpDown.Name = "TotalRegionsNumericUpDown";
            TotalRegionsNumericUpDown.Size = new Size(70, 23);
            TotalRegionsNumericUpDown.TabIndex = 8;
            TotalRegionsNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TotalRegionsLabel
            // 
            TotalRegionsLabel.AutoSize = true;
            TotalRegionsLabel.Location = new Point(6, 24);
            TotalRegionsLabel.Name = "TotalRegionsLabel";
            TotalRegionsLabel.Size = new Size(81, 15);
            TotalRegionsLabel.TabIndex = 0;
            TotalRegionsLabel.Text = "Total Regions:";
            // 
            // ExportConfigurationGroupBox
            // 
            ExportConfigurationGroupBox.Controls.Add(EnableJSONandLogExportCheckBox);
            ExportConfigurationGroupBox.Controls.Add(EnableJSONandLogExportLabel);
            ExportConfigurationGroupBox.Controls.Add(ExportPathTextBox);
            ExportConfigurationGroupBox.Controls.Add(ExportPathLabel);
            ExportConfigurationGroupBox.Location = new Point(12, 619);
            ExportConfigurationGroupBox.Name = "ExportConfigurationGroupBox";
            ExportConfigurationGroupBox.Size = new Size(275, 79);
            ExportConfigurationGroupBox.TabIndex = 4;
            ExportConfigurationGroupBox.TabStop = false;
            ExportConfigurationGroupBox.Text = "Export Configuration";
            // 
            // EnableJSONandLogExportCheckBox
            // 
            EnableJSONandLogExportCheckBox.AutoSize = true;
            EnableJSONandLogExportCheckBox.Location = new Point(172, 20);
            EnableJSONandLogExportCheckBox.Name = "EnableJSONandLogExportCheckBox";
            EnableJSONandLogExportCheckBox.Size = new Size(15, 14);
            EnableJSONandLogExportCheckBox.TabIndex = 6;
            EnableJSONandLogExportCheckBox.UseVisualStyleBackColor = true;
            EnableJSONandLogExportCheckBox.CheckedChanged += EnableJSONExportCheckBox_CheckedChanged;
            // 
            // EnableJSONandLogExportLabel
            // 
            EnableJSONandLogExportLabel.AutoSize = true;
            EnableJSONandLogExportLabel.Location = new Point(6, 19);
            EnableJSONandLogExportLabel.Name = "EnableJSONandLogExportLabel";
            EnableJSONandLogExportLabel.Size = new Size(160, 15);
            EnableJSONandLogExportLabel.TabIndex = 5;
            EnableJSONandLogExportLabel.Text = "Enable JSON and Log Export?";
            // 
            // ExportPathTextBox
            // 
            ExportPathTextBox.Enabled = false;
            ExportPathTextBox.Location = new Point(82, 45);
            ExportPathTextBox.Name = "ExportPathTextBox";
            ExportPathTextBox.Size = new Size(187, 23);
            ExportPathTextBox.TabIndex = 4;
            ExportPathTextBox.Text = "Test";
            // 
            // ExportPathLabel
            // 
            ExportPathLabel.AutoSize = true;
            ExportPathLabel.Location = new Point(6, 48);
            ExportPathLabel.Name = "ExportPathLabel";
            ExportPathLabel.Size = new Size(70, 15);
            ExportPathLabel.TabIndex = 0;
            ExportPathLabel.Text = "Export Path:";
            // 
            // RunSimulationButton
            // 
            RunSimulationButton.Location = new Point(12, 704);
            RunSimulationButton.Name = "RunSimulationButton";
            RunSimulationButton.Size = new Size(134, 47);
            RunSimulationButton.TabIndex = 5;
            RunSimulationButton.Text = "Run Simulation";
            RunSimulationButton.UseVisualStyleBackColor = true;
            RunSimulationButton.Click += RunSimulationButton_Click;
            // 
            // ImportJSONButton
            // 
            ImportJSONButton.Location = new Point(153, 757);
            ImportJSONButton.Name = "ImportJSONButton";
            ImportJSONButton.Size = new Size(134, 47);
            ImportJSONButton.TabIndex = 8;
            ImportJSONButton.Text = "Import JSON";
            ImportJSONButton.UseVisualStyleBackColor = true;
            ImportJSONButton.Click += ImportJSONButton_Click;
            // 
            // ViewTableButton
            // 
            ViewTableButton.Location = new Point(152, 704);
            ViewTableButton.Name = "ViewTableButton";
            ViewTableButton.Size = new Size(134, 47);
            ViewTableButton.TabIndex = 6;
            ViewTableButton.Text = "View Table";
            ViewTableButton.UseVisualStyleBackColor = true;
            ViewTableButton.Click += ViewTableButton_Click;
            // 
            // ResetDefaultsButton
            // 
            ResetDefaultsButton.Location = new Point(12, 757);
            ResetDefaultsButton.Name = "ResetDefaultsButton";
            ResetDefaultsButton.Size = new Size(134, 47);
            ResetDefaultsButton.TabIndex = 7;
            ResetDefaultsButton.Text = "Reset Defaults";
            ResetDefaultsButton.UseVisualStyleBackColor = true;
            ResetDefaultsButton.Click += ResetDefaultsButton_Click;
            // 
            // LoggingRichTextBox
            // 
            LoggingRichTextBox.Location = new Point(6, 22);
            LoggingRichTextBox.Name = "LoggingRichTextBox";
            LoggingRichTextBox.ReadOnly = true;
            LoggingRichTextBox.Size = new Size(714, 764);
            LoggingRichTextBox.TabIndex = 9;
            LoggingRichTextBox.Text = "";
            // 
            // Logging
            // 
            Logging.Controls.Add(LoggingRichTextBox);
            Logging.Location = new Point(293, 12);
            Logging.Name = "Logging";
            Logging.Size = new Size(726, 792);
            Logging.TabIndex = 9;
            Logging.TabStop = false;
            Logging.Text = "Logging";
            // 
            // ThresholdConfigurationGroupBox
            // 
            ThresholdConfigurationGroupBox.Controls.Add(MutationVarianceRateNumericUpDown);
            ThresholdConfigurationGroupBox.Controls.Add(MutationVarianceRate);
            ThresholdConfigurationGroupBox.Controls.Add(MaximumChildrenNumericUpDown);
            ThresholdConfigurationGroupBox.Controls.Add(MaximumChildrenLabel);
            ThresholdConfigurationGroupBox.Controls.Add(MinimumChildrenNumericUpDown);
            ThresholdConfigurationGroupBox.Controls.Add(MinimumChildrenLabel);
            ThresholdConfigurationGroupBox.Controls.Add(MaximumDesirabilityNumericUpDown);
            ThresholdConfigurationGroupBox.Controls.Add(MaximumDesirabilityLabel);
            ThresholdConfigurationGroupBox.Controls.Add(MinimumDesirabilityNumericUpDown);
            ThresholdConfigurationGroupBox.Controls.Add(MinimumDesirabilityLabel);
            ThresholdConfigurationGroupBox.Location = new Point(12, 299);
            ThresholdConfigurationGroupBox.Name = "ThresholdConfigurationGroupBox";
            ThresholdConfigurationGroupBox.Size = new Size(248, 165);
            ThresholdConfigurationGroupBox.TabIndex = 2;
            ThresholdConfigurationGroupBox.TabStop = false;
            ThresholdConfigurationGroupBox.Text = "Threshold Configuration";
            // 
            // MutationVarianceRateNumericUpDown
            // 
            MutationVarianceRateNumericUpDown.Location = new Point(167, 133);
            MutationVarianceRateNumericUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            MutationVarianceRateNumericUpDown.Name = "MutationVarianceRateNumericUpDown";
            MutationVarianceRateNumericUpDown.Size = new Size(70, 23);
            MutationVarianceRateNumericUpDown.TabIndex = 23;
            MutationVarianceRateNumericUpDown.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // MutationVarianceRate
            // 
            MutationVarianceRate.AutoSize = true;
            MutationVarianceRate.Location = new Point(7, 135);
            MutationVarianceRate.Name = "MutationVarianceRate";
            MutationVarianceRate.Size = new Size(153, 15);
            MutationVarianceRate.TabIndex = 22;
            MutationVarianceRate.Text = "Mutation Variance Rate (%):";
            // 
            // MaximumChildrenNumericUpDown
            // 
            MaximumChildrenNumericUpDown.Location = new Point(167, 104);
            MaximumChildrenNumericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            MaximumChildrenNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MaximumChildrenNumericUpDown.Name = "MaximumChildrenNumericUpDown";
            MaximumChildrenNumericUpDown.Size = new Size(70, 23);
            MaximumChildrenNumericUpDown.TabIndex = 21;
            MaximumChildrenNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            MaximumChildrenNumericUpDown.ValueChanged += MaximumChildrenNumericUpDown_ValueChanged;
            // 
            // MaximumChildrenLabel
            // 
            MaximumChildrenLabel.AutoSize = true;
            MaximumChildrenLabel.Location = new Point(7, 106);
            MaximumChildrenLabel.Name = "MaximumChildrenLabel";
            MaximumChildrenLabel.Size = new Size(112, 15);
            MaximumChildrenLabel.TabIndex = 20;
            MaximumChildrenLabel.Text = "Maximum Children:";
            // 
            // MinimumChildrenNumericUpDown
            // 
            MinimumChildrenNumericUpDown.Location = new Point(167, 75);
            MinimumChildrenNumericUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            MinimumChildrenNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MinimumChildrenNumericUpDown.Name = "MinimumChildrenNumericUpDown";
            MinimumChildrenNumericUpDown.Size = new Size(70, 23);
            MinimumChildrenNumericUpDown.TabIndex = 19;
            MinimumChildrenNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            MinimumChildrenNumericUpDown.ValueChanged += MinimumChildrenNumericUpDown_ValueChanged;
            // 
            // MinimumChildrenLabel
            // 
            MinimumChildrenLabel.AutoSize = true;
            MinimumChildrenLabel.Location = new Point(7, 77);
            MinimumChildrenLabel.Name = "MinimumChildrenLabel";
            MinimumChildrenLabel.Size = new Size(111, 15);
            MinimumChildrenLabel.TabIndex = 18;
            MinimumChildrenLabel.Text = "Minimum Children:";
            // 
            // MaximumDesirabilityNumericUpDown
            // 
            MaximumDesirabilityNumericUpDown.Location = new Point(167, 46);
            MaximumDesirabilityNumericUpDown.Name = "MaximumDesirabilityNumericUpDown";
            MaximumDesirabilityNumericUpDown.Size = new Size(70, 23);
            MaximumDesirabilityNumericUpDown.TabIndex = 17;
            MaximumDesirabilityNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            MaximumDesirabilityNumericUpDown.ValueChanged += MaximumDesirabilityNumericUpDown_ValueChanged;
            // 
            // MaximumDesirabilityLabel
            // 
            MaximumDesirabilityLabel.AutoSize = true;
            MaximumDesirabilityLabel.Location = new Point(7, 48);
            MaximumDesirabilityLabel.Name = "MaximumDesirabilityLabel";
            MaximumDesirabilityLabel.Size = new Size(146, 15);
            MaximumDesirabilityLabel.TabIndex = 16;
            MaximumDesirabilityLabel.Text = "Maximum Desirability (%):";
            // 
            // ConfigurationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 817);
            Controls.Add(ThresholdConfigurationGroupBox);
            Controls.Add(Logging);
            Controls.Add(ResetDefaultsButton);
            Controls.Add(ViewTableButton);
            Controls.Add(ImportJSONButton);
            Controls.Add(RunSimulationButton);
            Controls.Add(ExportConfigurationGroupBox);
            Controls.Add(RegionConfigurationGroupBox);
            Controls.Add(LimitationsConfigurationGroupBox);
            Controls.Add(GeneralConfigurationGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ConfigurationForm";
            Text = "Simulation Settings";
            GeneralConfigurationGroupBox.ResumeLayout(false);
            GeneralConfigurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GenderRatioNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MutationRateNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecombinationRateNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotalGenerationsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)InitialPopulationNumericUpDown).EndInit();
            LimitationsConfigurationGroupBox.ResumeLayout(false);
            LimitationsConfigurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MinimumDesirabilityNumericUpDown).EndInit();
            RegionConfigurationGroupBox.ResumeLayout(false);
            RegionConfigurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BiasVarianceRateNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmigrationRateNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)TotalRegionsNumericUpDown).EndInit();
            ExportConfigurationGroupBox.ResumeLayout(false);
            ExportConfigurationGroupBox.PerformLayout();
            Logging.ResumeLayout(false);
            ThresholdConfigurationGroupBox.ResumeLayout(false);
            ThresholdConfigurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MutationVarianceRateNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaximumChildrenNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimumChildrenNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaximumDesirabilityNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GeneralConfigurationGroupBox;
        private NumericUpDown InitialPopulationNumericUpDown;
        private Label InitialPopulationLabel;
        private Label TotalGenerationsLabel;
        private NumericUpDown TotalGenerationsNumericUpDown;
        private Label RecombinationRateLabel;
        private NumericUpDown MutationRateNumericUpDown;
        private Label MutationRateLabel;
        private NumericUpDown RecombinationRateNumericUpDown;
        private GroupBox LimitationsConfigurationGroupBox;
        private Label EnableInbreedingLabel;
        private ComboBox EnableInbreedingComboBox;
        private CheckBox EnableCrossRegionBreedingCheckBox;
        private Label EnableCrossRegionBreedingLabel;
        private CheckBox EnableSameGenderBreedingCheckBox;
        private Label EnableSameGenderBreedingLabel;
        private GroupBox RegionConfigurationGroupBox;
        private NumericUpDown TotalRegionsNumericUpDown;
        private Label TotalRegionsLabel;
        private Label EnableRegionalDesirabilityBiasLabel;
        private NumericUpDown EmigrationRateNumericUpDown;
        private Label EmigrationRateLabel;
        private NumericUpDown BiasVarianceRateNumericUpDown;
        private Label BiasVarianceRateLabel;
        private CheckBox EnableRegionalDesirabilityBiasCheckBox;
        private GroupBox ExportConfigurationGroupBox;
        private TextBox ExportPathTextBox;
        private Label ExportPathLabel;
        private Label EnableJSONandLogExportLabel;
        private CheckBox EnableJSONandLogExportCheckBox;
        private Button RunSimulationButton;
        private Button ImportJSONButton;
        private Button ViewTableButton;
        private Button ResetDefaultsButton;
        private RichTextBox LoggingRichTextBox;
        private GroupBox Logging;
        private Label GenderRatioLabel;
        private NumericUpDown GenderRatioNumericUpDown;
        private NumericUpDown MinimumDesirabilityNumericUpDown;
        private Label MinimumDesirabilityLabel;
        private GroupBox ThresholdConfigurationGroupBox;
        private NumericUpDown MaximumChildrenNumericUpDown;
        private Label MaximumChildrenLabel;
        private NumericUpDown MinimumChildrenNumericUpDown;
        private Label MinimumChildrenLabel;
        private NumericUpDown MaximumDesirabilityNumericUpDown;
        private Label MaximumDesirabilityLabel;
        private NumericUpDown MutationVarianceRateNumericUpDown;
        private Label MutationVarianceRate;
    }
}