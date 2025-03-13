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
            EmigrationRateNumericUpDown = new NumericUpDown();
            EmigrationRateLabel = new Label();
            TotalRegionsNumericUpDown = new NumericUpDown();
            TotalRegionsLabel = new Label();
            ExportConfigurationGroupBox = new GroupBox();
            EnableLogExportCheckBox = new CheckBox();
            EnableLogExportLabel = new Label();
            EnableJSONExportCheckBox = new CheckBox();
            EnableJSONExportLabel = new Label();
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
            groupBox1 = new GroupBox();
            LogGenerationsCheckBox = new CheckBox();
            LogGenerationsLabel = new Label();
            LogPersonsCheckBox = new CheckBox();
            LogPersonsLabel = new Label();
            LogEventsCheckBox = new CheckBox();
            LogEventsLabel = new Label();
            EnableLoggingCheckBox = new CheckBox();
            EnableLoggingLabel = new Label();
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
            groupBox1.SuspendLayout();
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
            MutationRateNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            MutationRateNumericUpDown.Name = "MutationRateNumericUpDown";
            MutationRateNumericUpDown.Size = new Size(70, 23);
            MutationRateNumericUpDown.TabIndex = 7;
            MutationRateNumericUpDown.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // MutationRateLabel
            // 
            MutationRateLabel.AutoSize = true;
            MutationRateLabel.Location = new Point(6, 106);
            MutationRateLabel.Name = "MutationRateLabel";
            MutationRateLabel.Size = new Size(115, 15);
            MutationRateLabel.TabIndex = 6;
            MutationRateLabel.Text = "Mutation Rate (‱):";
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
            EnableSameGenderBreedingCheckBox.Location = new Point(191, 84);
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
            EnableCrossRegionBreedingCheckBox.Location = new Point(191, 55);
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
            RegionConfigurationGroupBox.Controls.Add(EmigrationRateNumericUpDown);
            RegionConfigurationGroupBox.Controls.Add(EmigrationRateLabel);
            RegionConfigurationGroupBox.Controls.Add(TotalRegionsNumericUpDown);
            RegionConfigurationGroupBox.Controls.Add(TotalRegionsLabel);
            RegionConfigurationGroupBox.Location = new Point(12, 470);
            RegionConfigurationGroupBox.Name = "RegionConfigurationGroupBox";
            RegionConfigurationGroupBox.Size = new Size(220, 112);
            RegionConfigurationGroupBox.TabIndex = 3;
            RegionConfigurationGroupBox.TabStop = false;
            RegionConfigurationGroupBox.Text = "Region Configuration";
            // 
            // BiasVarianceRateNumericUpDown
            // 
            BiasVarianceRateNumericUpDown.Location = new Point(138, 80);
            BiasVarianceRateNumericUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            BiasVarianceRateNumericUpDown.Name = "BiasVarianceRateNumericUpDown";
            BiasVarianceRateNumericUpDown.Size = new Size(70, 23);
            BiasVarianceRateNumericUpDown.TabIndex = 14;
            BiasVarianceRateNumericUpDown.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // BiasVarianceRateLabel
            // 
            BiasVarianceRateLabel.AutoSize = true;
            BiasVarianceRateLabel.Location = new Point(6, 82);
            BiasVarianceRateLabel.Name = "BiasVarianceRateLabel";
            BiasVarianceRateLabel.Size = new Size(125, 15);
            BiasVarianceRateLabel.TabIndex = 13;
            BiasVarianceRateLabel.Text = "Bias Variance Rate (%):";
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
            ExportConfigurationGroupBox.Controls.Add(EnableLogExportCheckBox);
            ExportConfigurationGroupBox.Controls.Add(EnableLogExportLabel);
            ExportConfigurationGroupBox.Controls.Add(EnableJSONExportCheckBox);
            ExportConfigurationGroupBox.Controls.Add(EnableJSONExportLabel);
            ExportConfigurationGroupBox.Controls.Add(ExportPathTextBox);
            ExportConfigurationGroupBox.Controls.Add(ExportPathLabel);
            ExportConfigurationGroupBox.Location = new Point(12, 667);
            ExportConfigurationGroupBox.Name = "ExportConfigurationGroupBox";
            ExportConfigurationGroupBox.Size = new Size(275, 107);
            ExportConfigurationGroupBox.TabIndex = 5;
            ExportConfigurationGroupBox.TabStop = false;
            ExportConfigurationGroupBox.Text = "Export Configuration";
            // 
            // EnableLogExportCheckBox
            // 
            EnableLogExportCheckBox.AutoSize = true;
            EnableLogExportCheckBox.Location = new Point(134, 49);
            EnableLogExportCheckBox.Name = "EnableLogExportCheckBox";
            EnableLogExportCheckBox.Size = new Size(15, 14);
            EnableLogExportCheckBox.TabIndex = 8;
            EnableLogExportCheckBox.UseVisualStyleBackColor = true;
            EnableLogExportCheckBox.CheckedChanged += EnableJSONandLogExportCheckBox_CheckedChanged;
            // 
            // EnableLogExportLabel
            // 
            EnableLogExportLabel.AutoSize = true;
            EnableLogExportLabel.Location = new Point(6, 48);
            EnableLogExportLabel.Name = "EnableLogExportLabel";
            EnableLogExportLabel.Size = new Size(106, 15);
            EnableLogExportLabel.TabIndex = 7;
            EnableLogExportLabel.Text = "Enable Log Export?";
            // 
            // EnableJSONExportCheckBox
            // 
            EnableJSONExportCheckBox.AutoSize = true;
            EnableJSONExportCheckBox.Location = new Point(134, 20);
            EnableJSONExportCheckBox.Name = "EnableJSONExportCheckBox";
            EnableJSONExportCheckBox.Size = new Size(15, 14);
            EnableJSONExportCheckBox.TabIndex = 6;
            EnableJSONExportCheckBox.UseVisualStyleBackColor = true;
            EnableJSONExportCheckBox.CheckedChanged += EnableJSONandLogExportCheckBox_CheckedChanged;
            // 
            // EnableJSONExportLabel
            // 
            EnableJSONExportLabel.AutoSize = true;
            EnableJSONExportLabel.Location = new Point(6, 19);
            EnableJSONExportLabel.Name = "EnableJSONExportLabel";
            EnableJSONExportLabel.Size = new Size(114, 15);
            EnableJSONExportLabel.TabIndex = 5;
            EnableJSONExportLabel.Text = "Enable JSON Export?";
            // 
            // ExportPathTextBox
            // 
            ExportPathTextBox.Enabled = false;
            ExportPathTextBox.Location = new Point(82, 74);
            ExportPathTextBox.Name = "ExportPathTextBox";
            ExportPathTextBox.Size = new Size(187, 23);
            ExportPathTextBox.TabIndex = 4;
            ExportPathTextBox.Text = "Test";
            // 
            // ExportPathLabel
            // 
            ExportPathLabel.AutoSize = true;
            ExportPathLabel.Location = new Point(6, 77);
            ExportPathLabel.Name = "ExportPathLabel";
            ExportPathLabel.Size = new Size(70, 15);
            ExportPathLabel.TabIndex = 0;
            ExportPathLabel.Text = "Export Path:";
            // 
            // RunSimulationButton
            // 
            RunSimulationButton.Location = new Point(12, 780);
            RunSimulationButton.Name = "RunSimulationButton";
            RunSimulationButton.Size = new Size(134, 47);
            RunSimulationButton.TabIndex = 6;
            RunSimulationButton.Text = "Run Simulation";
            RunSimulationButton.UseVisualStyleBackColor = true;
            RunSimulationButton.Click += RunSimulationButton_Click;
            // 
            // ImportJSONButton
            // 
            ImportJSONButton.Location = new Point(153, 833);
            ImportJSONButton.Name = "ImportJSONButton";
            ImportJSONButton.Size = new Size(134, 47);
            ImportJSONButton.TabIndex = 9;
            ImportJSONButton.Text = "Import JSON";
            ImportJSONButton.UseVisualStyleBackColor = true;
            ImportJSONButton.Click += ImportJSONButton_Click;
            // 
            // ViewTableButton
            // 
            ViewTableButton.Location = new Point(152, 780);
            ViewTableButton.Name = "ViewTableButton";
            ViewTableButton.Size = new Size(134, 47);
            ViewTableButton.TabIndex = 7;
            ViewTableButton.Text = "View Table";
            ViewTableButton.UseVisualStyleBackColor = true;
            ViewTableButton.Click += ViewTableButton_Click;
            // 
            // ResetDefaultsButton
            // 
            ResetDefaultsButton.Location = new Point(12, 833);
            ResetDefaultsButton.Name = "ResetDefaultsButton";
            ResetDefaultsButton.Size = new Size(134, 47);
            ResetDefaultsButton.TabIndex = 8;
            ResetDefaultsButton.Text = "Reset Defaults";
            ResetDefaultsButton.UseVisualStyleBackColor = true;
            ResetDefaultsButton.Click += ResetDefaultsButton_Click;
            // 
            // LoggingRichTextBox
            // 
            LoggingRichTextBox.Location = new Point(6, 22);
            LoggingRichTextBox.Name = "LoggingRichTextBox";
            LoggingRichTextBox.ReadOnly = true;
            LoggingRichTextBox.Size = new Size(743, 840);
            LoggingRichTextBox.TabIndex = 9;
            LoggingRichTextBox.Text = "";
            // 
            // Logging
            // 
            Logging.Controls.Add(LoggingRichTextBox);
            Logging.Location = new Point(293, 12);
            Logging.Name = "Logging";
            Logging.Size = new Size(755, 868);
            Logging.TabIndex = 10;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(LogGenerationsCheckBox);
            groupBox1.Controls.Add(LogGenerationsLabel);
            groupBox1.Controls.Add(LogPersonsCheckBox);
            groupBox1.Controls.Add(LogPersonsLabel);
            groupBox1.Controls.Add(LogEventsCheckBox);
            groupBox1.Controls.Add(LogEventsLabel);
            groupBox1.Controls.Add(EnableLoggingCheckBox);
            groupBox1.Controls.Add(EnableLoggingLabel);
            groupBox1.Location = new Point(12, 588);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 73);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Log Configuration";
            // 
            // LogGenerationsCheckBox
            // 
            LogGenerationsCheckBox.AutoSize = true;
            LogGenerationsCheckBox.Location = new Point(118, 49);
            LogGenerationsCheckBox.Name = "LogGenerationsCheckBox";
            LogGenerationsCheckBox.Size = new Size(15, 14);
            LogGenerationsCheckBox.TabIndex = 11;
            LogGenerationsCheckBox.UseVisualStyleBackColor = true;
            // 
            // LogGenerationsLabel
            // 
            LogGenerationsLabel.AutoSize = true;
            LogGenerationsLabel.Location = new Point(6, 48);
            LogGenerationsLabel.Name = "LogGenerationsLabel";
            LogGenerationsLabel.Size = new Size(98, 15);
            LogGenerationsLabel.TabIndex = 14;
            LogGenerationsLabel.Text = "Log Generations?";
            // 
            // LogPersonsCheckBox
            // 
            LogPersonsCheckBox.AutoSize = true;
            LogPersonsCheckBox.Location = new Point(245, 20);
            LogPersonsCheckBox.Name = "LogPersonsCheckBox";
            LogPersonsCheckBox.Size = new Size(15, 14);
            LogPersonsCheckBox.TabIndex = 10;
            LogPersonsCheckBox.UseVisualStyleBackColor = true;
            // 
            // LogPersonsLabel
            // 
            LogPersonsLabel.AutoSize = true;
            LogPersonsLabel.Location = new Point(155, 19);
            LogPersonsLabel.Name = "LogPersonsLabel";
            LogPersonsLabel.Size = new Size(76, 15);
            LogPersonsLabel.TabIndex = 12;
            LogPersonsLabel.Text = "Log Persons?";
            // 
            // LogEventsCheckBox
            // 
            LogEventsCheckBox.AutoSize = true;
            LogEventsCheckBox.Location = new Point(245, 49);
            LogEventsCheckBox.Name = "LogEventsCheckBox";
            LogEventsCheckBox.Size = new Size(15, 14);
            LogEventsCheckBox.TabIndex = 12;
            LogEventsCheckBox.UseVisualStyleBackColor = true;
            // 
            // LogEventsLabel
            // 
            LogEventsLabel.AutoSize = true;
            LogEventsLabel.Location = new Point(155, 48);
            LogEventsLabel.Name = "LogEventsLabel";
            LogEventsLabel.Size = new Size(69, 15);
            LogEventsLabel.TabIndex = 10;
            LogEventsLabel.Text = "Log Events?";
            // 
            // EnableLoggingCheckBox
            // 
            EnableLoggingCheckBox.AutoSize = true;
            EnableLoggingCheckBox.Location = new Point(118, 20);
            EnableLoggingCheckBox.Name = "EnableLoggingCheckBox";
            EnableLoggingCheckBox.Size = new Size(15, 14);
            EnableLoggingCheckBox.TabIndex = 9;
            EnableLoggingCheckBox.UseVisualStyleBackColor = true;
            EnableLoggingCheckBox.CheckedChanged += EnableLoggingCheckBox_CheckedChanged;
            // 
            // EnableLoggingLabel
            // 
            EnableLoggingLabel.AutoSize = true;
            EnableLoggingLabel.Location = new Point(6, 19);
            EnableLoggingLabel.Name = "EnableLoggingLabel";
            EnableLoggingLabel.Size = new Size(94, 15);
            EnableLoggingLabel.TabIndex = 9;
            EnableLoggingLabel.Text = "Enable Logging?";
            // 
            // ConfigurationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 892);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private NumericUpDown EmigrationRateNumericUpDown;
        private Label EmigrationRateLabel;
        private NumericUpDown BiasVarianceRateNumericUpDown;
        private Label BiasVarianceRateLabel;
        private GroupBox ExportConfigurationGroupBox;
        private TextBox ExportPathTextBox;
        private Label ExportPathLabel;
        private Label EnableJSONExportLabel;
        private CheckBox EnableJSONExportCheckBox;
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
        private GroupBox groupBox1;
        private CheckBox EnableLogExportCheckBox;
        private Label EnableLogExportLabel;
        private Label EnableLoggingLabel;
        private Label LogGenerationsLabel;
        private CheckBox LogPersonsCheckBox;
        private Label LogPersonsLabel;
        private CheckBox LogEventsCheckBox;
        private Label LogEventsLabel;
        private CheckBox EnableLoggingCheckBox;
        private CheckBox LogGenerationsCheckBox;
    }
}