namespace InventorySimulation
{
    partial class InventoryForm
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
            this.chooseTestCaseButton = new System.Windows.Forms.Button();
            this.tabsController = new System.Windows.Forms.TabControl();
            this.inputDataTabPage = new System.Windows.Forms.TabPage();
            this.LeadTimeDistributionLabel = new System.Windows.Forms.Label();
            this.DemandDistributionLabel = new System.Windows.Forms.Label();
            this.NumberOfDaysTextBox = new System.Windows.Forms.TextBox();
            this.StartOrderQuantityTextBox = new System.Windows.Forms.TextBox();
            this.StartLeadDaysTextBox = new System.Windows.Forms.TextBox();
            this.StartInventoryQuantityTextBox = new System.Windows.Forms.TextBox();
            this.ReviewPeriodTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfDaysLabel = new System.Windows.Forms.Label();
            this.StartOrderQuantityLabel = new System.Windows.Forms.Label();
            this.StartLeadDaysLabel = new System.Windows.Forms.Label();
            this.StartInventoryQuantityLabel = new System.Windows.Forms.Label();
            this.ReviewPeriodLabel = new System.Windows.Forms.Label();
            this.LeadTimeInDaysTable = new System.Windows.Forms.DataGridView();
            this.LeadTimeInDaysColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemandTable = new System.Windows.Forms.DataGridView();
            this.DemandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CumulativeProbabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDigitAssignmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderUpToTextBox = new System.Windows.Forms.TextBox();
            this.OrderUpToLabel = new System.Windows.Forms.Label();
            this.SimulationTableTabPage = new System.Windows.Forms.TabPage();
            this.SimulationTable = new System.Windows.Forms.DataGridView();
            this.DayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CycleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayWithinCycleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginningInventoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDigitsForDemandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemandSimulationTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndingInventoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortageQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDigitsForLeadTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeadTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysUntilOrderArrivesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerformanceMeasuresTabPage = new System.Windows.Forms.TabPage();
            this.PerformanceMeasuresGroupBox = new System.Windows.Forms.GroupBox();
            this.ShortageQuantityAverageTextBox = new System.Windows.Forms.TextBox();
            this.ShortageQuantityAverageLabel = new System.Windows.Forms.Label();
            this.EndingInventoryAverageTextBox = new System.Windows.Forms.TextBox();
            this.EndingInventoryAverageLabel = new System.Windows.Forms.Label();
            this.tabsController.SuspendLayout();
            this.inputDataTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeadTimeInDaysTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemandTable)).BeginInit();
            this.SimulationTableTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationTable)).BeginInit();
            this.PerformanceMeasuresTabPage.SuspendLayout();
            this.PerformanceMeasuresGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseTestCaseButton
            // 
            this.chooseTestCaseButton.Location = new System.Drawing.Point(467, 23);
            this.chooseTestCaseButton.Name = "chooseTestCaseButton";
            this.chooseTestCaseButton.Size = new System.Drawing.Size(145, 38);
            this.chooseTestCaseButton.TabIndex = 0;
            this.chooseTestCaseButton.Text = "Choose Test Case";
            this.chooseTestCaseButton.UseVisualStyleBackColor = true;
            this.chooseTestCaseButton.Click += new System.EventHandler(this.chooseTestCaseButton_Click);
            // 
            // tabsController
            // 
            this.tabsController.Controls.Add(this.inputDataTabPage);
            this.tabsController.Controls.Add(this.SimulationTableTabPage);
            this.tabsController.Controls.Add(this.PerformanceMeasuresTabPage);
            this.tabsController.Location = new System.Drawing.Point(25, 67);
            this.tabsController.Name = "tabsController";
            this.tabsController.SelectedIndex = 0;
            this.tabsController.Size = new System.Drawing.Size(994, 467);
            this.tabsController.TabIndex = 1;
            // 
            // inputDataTabPage
            // 
            this.inputDataTabPage.Controls.Add(this.LeadTimeDistributionLabel);
            this.inputDataTabPage.Controls.Add(this.DemandDistributionLabel);
            this.inputDataTabPage.Controls.Add(this.NumberOfDaysTextBox);
            this.inputDataTabPage.Controls.Add(this.StartOrderQuantityTextBox);
            this.inputDataTabPage.Controls.Add(this.StartLeadDaysTextBox);
            this.inputDataTabPage.Controls.Add(this.StartInventoryQuantityTextBox);
            this.inputDataTabPage.Controls.Add(this.ReviewPeriodTextBox);
            this.inputDataTabPage.Controls.Add(this.NumberOfDaysLabel);
            this.inputDataTabPage.Controls.Add(this.StartOrderQuantityLabel);
            this.inputDataTabPage.Controls.Add(this.StartLeadDaysLabel);
            this.inputDataTabPage.Controls.Add(this.StartInventoryQuantityLabel);
            this.inputDataTabPage.Controls.Add(this.ReviewPeriodLabel);
            this.inputDataTabPage.Controls.Add(this.LeadTimeInDaysTable);
            this.inputDataTabPage.Controls.Add(this.DemandTable);
            this.inputDataTabPage.Controls.Add(this.OrderUpToTextBox);
            this.inputDataTabPage.Controls.Add(this.OrderUpToLabel);
            this.inputDataTabPage.Location = new System.Drawing.Point(4, 25);
            this.inputDataTabPage.Name = "inputDataTabPage";
            this.inputDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inputDataTabPage.Size = new System.Drawing.Size(986, 438);
            this.inputDataTabPage.TabIndex = 0;
            this.inputDataTabPage.Text = "Input Data";
            this.inputDataTabPage.UseVisualStyleBackColor = true;
            // 
            // LeadTimeDistributionLabel
            // 
            this.LeadTimeDistributionLabel.AutoSize = true;
            this.LeadTimeDistributionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeadTimeDistributionLabel.Location = new System.Drawing.Point(680, 165);
            this.LeadTimeDistributionLabel.Name = "LeadTimeDistributionLabel";
            this.LeadTimeDistributionLabel.Size = new System.Drawing.Size(141, 31);
            this.LeadTimeDistributionLabel.TabIndex = 19;
            this.LeadTimeDistributionLabel.Text = "Lead Time";
            // 
            // DemandDistributionLabel
            // 
            this.DemandDistributionLabel.AutoSize = true;
            this.DemandDistributionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemandDistributionLabel.Location = new System.Drawing.Point(99, 165);
            this.DemandDistributionLabel.Name = "DemandDistributionLabel";
            this.DemandDistributionLabel.Size = new System.Drawing.Size(260, 31);
            this.DemandDistributionLabel.TabIndex = 18;
            this.DemandDistributionLabel.Text = "Demand Distribution";
            // 
            // NumberOfDaysTextBox
            // 
            this.NumberOfDaysTextBox.Location = new System.Drawing.Point(901, 102);
            this.NumberOfDaysTextBox.Name = "NumberOfDaysTextBox";
            this.NumberOfDaysTextBox.ReadOnly = true;
            this.NumberOfDaysTextBox.Size = new System.Drawing.Size(57, 22);
            this.NumberOfDaysTextBox.TabIndex = 17;
            // 
            // StartOrderQuantityTextBox
            // 
            this.StartOrderQuantityTextBox.Location = new System.Drawing.Point(544, 106);
            this.StartOrderQuantityTextBox.Name = "StartOrderQuantityTextBox";
            this.StartOrderQuantityTextBox.ReadOnly = true;
            this.StartOrderQuantityTextBox.Size = new System.Drawing.Size(57, 22);
            this.StartOrderQuantityTextBox.TabIndex = 16;
            // 
            // StartLeadDaysTextBox
            // 
            this.StartLeadDaysTextBox.Location = new System.Drawing.Point(219, 102);
            this.StartLeadDaysTextBox.Name = "StartLeadDaysTextBox";
            this.StartLeadDaysTextBox.ReadOnly = true;
            this.StartLeadDaysTextBox.Size = new System.Drawing.Size(57, 22);
            this.StartLeadDaysTextBox.TabIndex = 15;
            // 
            // StartInventoryQuantityTextBox
            // 
            this.StartInventoryQuantityTextBox.Location = new System.Drawing.Point(901, 37);
            this.StartInventoryQuantityTextBox.Name = "StartInventoryQuantityTextBox";
            this.StartInventoryQuantityTextBox.ReadOnly = true;
            this.StartInventoryQuantityTextBox.Size = new System.Drawing.Size(57, 22);
            this.StartInventoryQuantityTextBox.TabIndex = 14;
            // 
            // ReviewPeriodTextBox
            // 
            this.ReviewPeriodTextBox.Location = new System.Drawing.Point(544, 36);
            this.ReviewPeriodTextBox.Name = "ReviewPeriodTextBox";
            this.ReviewPeriodTextBox.ReadOnly = true;
            this.ReviewPeriodTextBox.Size = new System.Drawing.Size(57, 22);
            this.ReviewPeriodTextBox.TabIndex = 13;
            // 
            // NumberOfDaysLabel
            // 
            this.NumberOfDaysLabel.AutoSize = true;
            this.NumberOfDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfDaysLabel.Location = new System.Drawing.Point(661, 99);
            this.NumberOfDaysLabel.Name = "NumberOfDaysLabel";
            this.NumberOfDaysLabel.Size = new System.Drawing.Size(157, 25);
            this.NumberOfDaysLabel.TabIndex = 12;
            this.NumberOfDaysLabel.Text = "Number Of Days";
            // 
            // StartOrderQuantityLabel
            // 
            this.StartOrderQuantityLabel.AutoSize = true;
            this.StartOrderQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartOrderQuantityLabel.Location = new System.Drawing.Point(331, 102);
            this.StartOrderQuantityLabel.Name = "StartOrderQuantityLabel";
            this.StartOrderQuantityLabel.Size = new System.Drawing.Size(186, 25);
            this.StartOrderQuantityLabel.TabIndex = 10;
            this.StartOrderQuantityLabel.Text = "Start Order Quantity";
            // 
            // StartLeadDaysLabel
            // 
            this.StartLeadDaysLabel.AutoSize = true;
            this.StartLeadDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLeadDaysLabel.Location = new System.Drawing.Point(35, 99);
            this.StartLeadDaysLabel.Name = "StartLeadDaysLabel";
            this.StartLeadDaysLabel.Size = new System.Drawing.Size(152, 25);
            this.StartLeadDaysLabel.TabIndex = 8;
            this.StartLeadDaysLabel.Text = "Start Lead Days";
            // 
            // StartInventoryQuantityLabel
            // 
            this.StartInventoryQuantityLabel.AutoSize = true;
            this.StartInventoryQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartInventoryQuantityLabel.Location = new System.Drawing.Point(632, 33);
            this.StartInventoryQuantityLabel.Name = "StartInventoryQuantityLabel";
            this.StartInventoryQuantityLabel.Size = new System.Drawing.Size(216, 25);
            this.StartInventoryQuantityLabel.TabIndex = 6;
            this.StartInventoryQuantityLabel.Text = "Start Inventory Quantity";
            // 
            // ReviewPeriodLabel
            // 
            this.ReviewPeriodLabel.AutoSize = true;
            this.ReviewPeriodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewPeriodLabel.Location = new System.Drawing.Point(363, 32);
            this.ReviewPeriodLabel.Name = "ReviewPeriodLabel";
            this.ReviewPeriodLabel.Size = new System.Drawing.Size(136, 25);
            this.ReviewPeriodLabel.TabIndex = 4;
            this.ReviewPeriodLabel.Text = "Review Period";
            // 
            // LeadTimeInDaysTable
            // 
            this.LeadTimeInDaysTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeadTimeInDaysTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeadTimeInDaysColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.LeadTimeInDaysTable.Location = new System.Drawing.Point(529, 222);
            this.LeadTimeInDaysTable.Name = "LeadTimeInDaysTable";
            this.LeadTimeInDaysTable.RowTemplate.Height = 24;
            this.LeadTimeInDaysTable.Size = new System.Drawing.Size(444, 192);
            this.LeadTimeInDaysTable.TabIndex = 3;
            // 
            // LeadTimeInDaysColumn
            // 
            this.LeadTimeInDaysColumn.HeaderText = "Lead Time (Days)";
            this.LeadTimeInDaysColumn.Name = "LeadTimeInDaysColumn";
            this.LeadTimeInDaysColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Probability";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cumulative Probability";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Random Digit Assignment";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // DemandTable
            // 
            this.DemandTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DemandTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DemandColumn,
            this.ProbabilityColumn,
            this.CumulativeProbabilityColumn,
            this.RandomDigitAssignmentColumn});
            this.DemandTable.Location = new System.Drawing.Point(16, 222);
            this.DemandTable.Name = "DemandTable";
            this.DemandTable.RowTemplate.Height = 24;
            this.DemandTable.Size = new System.Drawing.Size(443, 192);
            this.DemandTable.TabIndex = 2;
            // 
            // DemandColumn
            // 
            this.DemandColumn.HeaderText = "Demand";
            this.DemandColumn.Name = "DemandColumn";
            this.DemandColumn.ReadOnly = true;
            // 
            // ProbabilityColumn
            // 
            this.ProbabilityColumn.HeaderText = "Probability";
            this.ProbabilityColumn.Name = "ProbabilityColumn";
            this.ProbabilityColumn.ReadOnly = true;
            // 
            // CumulativeProbabilityColumn
            // 
            this.CumulativeProbabilityColumn.HeaderText = "Cumulative Probability";
            this.CumulativeProbabilityColumn.Name = "CumulativeProbabilityColumn";
            this.CumulativeProbabilityColumn.ReadOnly = true;
            // 
            // RandomDigitAssignmentColumn
            // 
            this.RandomDigitAssignmentColumn.HeaderText = "Random Digit Assignment";
            this.RandomDigitAssignmentColumn.Name = "RandomDigitAssignmentColumn";
            this.RandomDigitAssignmentColumn.ReadOnly = true;
            // 
            // OrderUpToTextBox
            // 
            this.OrderUpToTextBox.Location = new System.Drawing.Point(219, 38);
            this.OrderUpToTextBox.Name = "OrderUpToTextBox";
            this.OrderUpToTextBox.ReadOnly = true;
            this.OrderUpToTextBox.Size = new System.Drawing.Size(57, 22);
            this.OrderUpToTextBox.TabIndex = 1;
            // 
            // OrderUpToLabel
            // 
            this.OrderUpToLabel.AutoSize = true;
            this.OrderUpToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderUpToLabel.Location = new System.Drawing.Point(44, 34);
            this.OrderUpToLabel.Name = "OrderUpToLabel";
            this.OrderUpToLabel.Size = new System.Drawing.Size(121, 25);
            this.OrderUpToLabel.TabIndex = 0;
            this.OrderUpToLabel.Text = "Order Up To";
            // 
            // SimulationTableTabPage
            // 
            this.SimulationTableTabPage.Controls.Add(this.SimulationTable);
            this.SimulationTableTabPage.Location = new System.Drawing.Point(4, 25);
            this.SimulationTableTabPage.Name = "SimulationTableTabPage";
            this.SimulationTableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SimulationTableTabPage.Size = new System.Drawing.Size(986, 438);
            this.SimulationTableTabPage.TabIndex = 1;
            this.SimulationTableTabPage.Text = "Simulation Table";
            this.SimulationTableTabPage.UseVisualStyleBackColor = true;
            // 
            // SimulationTable
            // 
            this.SimulationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimulationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DayColumn,
            this.CycleColumn,
            this.DayWithinCycleColumn,
            this.BeginningInventoryColumn,
            this.RandomDigitsForDemandColumn,
            this.DemandSimulationTableColumn,
            this.EndingInventoryColumn,
            this.ShortageQuantityColumn,
            this.OrderQuantityColumn,
            this.RandomDigitsForLeadTimeColumn,
            this.LeadTimeColumn,
            this.DaysUntilOrderArrivesColumn});
            this.SimulationTable.Location = new System.Drawing.Point(22, 36);
            this.SimulationTable.Name = "SimulationTable";
            this.SimulationTable.RowTemplate.Height = 24;
            this.SimulationTable.Size = new System.Drawing.Size(941, 383);
            this.SimulationTable.TabIndex = 0;
            // 
            // DayColumn
            // 
            this.DayColumn.HeaderText = "Day";
            this.DayColumn.Name = "DayColumn";
            this.DayColumn.ReadOnly = true;
            // 
            // CycleColumn
            // 
            this.CycleColumn.HeaderText = "Cycle";
            this.CycleColumn.Name = "CycleColumn";
            this.CycleColumn.ReadOnly = true;
            // 
            // DayWithinCycleColumn
            // 
            this.DayWithinCycleColumn.HeaderText = "Day Within Cycle";
            this.DayWithinCycleColumn.Name = "DayWithinCycleColumn";
            this.DayWithinCycleColumn.ReadOnly = true;
            // 
            // BeginningInventoryColumn
            // 
            this.BeginningInventoryColumn.HeaderText = "Beginning Inventory";
            this.BeginningInventoryColumn.Name = "BeginningInventoryColumn";
            this.BeginningInventoryColumn.ReadOnly = true;
            // 
            // RandomDigitsForDemandColumn
            // 
            this.RandomDigitsForDemandColumn.HeaderText = "Random Digits For Demand";
            this.RandomDigitsForDemandColumn.Name = "RandomDigitsForDemandColumn";
            this.RandomDigitsForDemandColumn.ReadOnly = true;
            // 
            // DemandSimulationTableColumn
            // 
            this.DemandSimulationTableColumn.HeaderText = "Demand";
            this.DemandSimulationTableColumn.Name = "DemandSimulationTableColumn";
            this.DemandSimulationTableColumn.ReadOnly = true;
            // 
            // EndingInventoryColumn
            // 
            this.EndingInventoryColumn.HeaderText = "Ending Inventory";
            this.EndingInventoryColumn.Name = "EndingInventoryColumn";
            this.EndingInventoryColumn.ReadOnly = true;
            // 
            // ShortageQuantityColumn
            // 
            this.ShortageQuantityColumn.HeaderText = "Shortage Quantity";
            this.ShortageQuantityColumn.Name = "ShortageQuantityColumn";
            this.ShortageQuantityColumn.ReadOnly = true;
            // 
            // OrderQuantityColumn
            // 
            this.OrderQuantityColumn.HeaderText = "Order Quantity";
            this.OrderQuantityColumn.Name = "OrderQuantityColumn";
            this.OrderQuantityColumn.ReadOnly = true;
            // 
            // RandomDigitsForLeadTimeColumn
            // 
            this.RandomDigitsForLeadTimeColumn.HeaderText = "Random Digits For Lead Time";
            this.RandomDigitsForLeadTimeColumn.Name = "RandomDigitsForLeadTimeColumn";
            this.RandomDigitsForLeadTimeColumn.ReadOnly = true;
            // 
            // LeadTimeColumn
            // 
            this.LeadTimeColumn.HeaderText = "Lead Time (Days)";
            this.LeadTimeColumn.Name = "LeadTimeColumn";
            this.LeadTimeColumn.ReadOnly = true;
            // 
            // DaysUntilOrderArrivesColumn
            // 
            this.DaysUntilOrderArrivesColumn.HeaderText = "Days Until Order Arrives";
            this.DaysUntilOrderArrivesColumn.Name = "DaysUntilOrderArrivesColumn";
            this.DaysUntilOrderArrivesColumn.ReadOnly = true;
            // 
            // PerformanceMeasuresTabPage
            // 
            this.PerformanceMeasuresTabPage.Controls.Add(this.PerformanceMeasuresGroupBox);
            this.PerformanceMeasuresTabPage.Location = new System.Drawing.Point(4, 25);
            this.PerformanceMeasuresTabPage.Name = "PerformanceMeasuresTabPage";
            this.PerformanceMeasuresTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PerformanceMeasuresTabPage.Size = new System.Drawing.Size(986, 438);
            this.PerformanceMeasuresTabPage.TabIndex = 2;
            this.PerformanceMeasuresTabPage.Text = "Performance Measures";
            this.PerformanceMeasuresTabPage.UseVisualStyleBackColor = true;
            // 
            // PerformanceMeasuresGroupBox
            // 
            this.PerformanceMeasuresGroupBox.Controls.Add(this.ShortageQuantityAverageTextBox);
            this.PerformanceMeasuresGroupBox.Controls.Add(this.ShortageQuantityAverageLabel);
            this.PerformanceMeasuresGroupBox.Controls.Add(this.EndingInventoryAverageTextBox);
            this.PerformanceMeasuresGroupBox.Controls.Add(this.EndingInventoryAverageLabel);
            this.PerformanceMeasuresGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerformanceMeasuresGroupBox.Location = new System.Drawing.Point(229, 92);
            this.PerformanceMeasuresGroupBox.Name = "PerformanceMeasuresGroupBox";
            this.PerformanceMeasuresGroupBox.Size = new System.Drawing.Size(495, 242);
            this.PerformanceMeasuresGroupBox.TabIndex = 0;
            this.PerformanceMeasuresGroupBox.TabStop = false;
            this.PerformanceMeasuresGroupBox.Text = "Performance Measures";
            // 
            // ShortageQuantityAverageTextBox
            // 
            this.ShortageQuantityAverageTextBox.Location = new System.Drawing.Point(325, 154);
            this.ShortageQuantityAverageTextBox.Name = "ShortageQuantityAverageTextBox";
            this.ShortageQuantityAverageTextBox.ReadOnly = true;
            this.ShortageQuantityAverageTextBox.Size = new System.Drawing.Size(132, 30);
            this.ShortageQuantityAverageTextBox.TabIndex = 5;
            // 
            // ShortageQuantityAverageLabel
            // 
            this.ShortageQuantityAverageLabel.AutoSize = true;
            this.ShortageQuantityAverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortageQuantityAverageLabel.Location = new System.Drawing.Point(48, 151);
            this.ShortageQuantityAverageLabel.Name = "ShortageQuantityAverageLabel";
            this.ShortageQuantityAverageLabel.Size = new System.Drawing.Size(254, 25);
            this.ShortageQuantityAverageLabel.TabIndex = 4;
            this.ShortageQuantityAverageLabel.Text = "Shortage Quantity Average ";
            // 
            // EndingInventoryAverageTextBox
            // 
            this.EndingInventoryAverageTextBox.Location = new System.Drawing.Point(325, 80);
            this.EndingInventoryAverageTextBox.Name = "EndingInventoryAverageTextBox";
            this.EndingInventoryAverageTextBox.ReadOnly = true;
            this.EndingInventoryAverageTextBox.Size = new System.Drawing.Size(132, 30);
            this.EndingInventoryAverageTextBox.TabIndex = 3;
            // 
            // EndingInventoryAverageLabel
            // 
            this.EndingInventoryAverageLabel.AutoSize = true;
            this.EndingInventoryAverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndingInventoryAverageLabel.Location = new System.Drawing.Point(48, 77);
            this.EndingInventoryAverageLabel.Name = "EndingInventoryAverageLabel";
            this.EndingInventoryAverageLabel.Size = new System.Drawing.Size(242, 25);
            this.EndingInventoryAverageLabel.TabIndex = 2;
            this.EndingInventoryAverageLabel.Text = "Ending Inventory Average ";
            // 
            // InventoryForm
            // 
            this.ClientSize = new System.Drawing.Size(1037, 543);
            this.Controls.Add(this.tabsController);
            this.Controls.Add(this.chooseTestCaseButton);
            this.Name = "InventoryForm";
            this.Text = "Inventory";
            this.tabsController.ResumeLayout(false);
            this.inputDataTabPage.ResumeLayout(false);
            this.inputDataTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeadTimeInDaysTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DemandTable)).EndInit();
            this.SimulationTableTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SimulationTable)).EndInit();
            this.PerformanceMeasuresTabPage.ResumeLayout(false);
            this.PerformanceMeasuresGroupBox.ResumeLayout(false);
            this.PerformanceMeasuresGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button chooseTestCaseButton;
        private System.Windows.Forms.TabControl tabsController;
        private System.Windows.Forms.TabPage inputDataTabPage;
        private System.Windows.Forms.TabPage SimulationTableTabPage;
        private System.Windows.Forms.DataGridView DemandTable;
        private System.Windows.Forms.TextBox OrderUpToTextBox;
        private System.Windows.Forms.Label OrderUpToLabel;
        private System.Windows.Forms.Label NumberOfDaysLabel;
        private System.Windows.Forms.Label StartOrderQuantityLabel;
        private System.Windows.Forms.Label StartLeadDaysLabel;
        private System.Windows.Forms.Label StartInventoryQuantityLabel;
        private System.Windows.Forms.Label ReviewPeriodLabel;
        private System.Windows.Forms.DataGridView LeadTimeInDaysTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeadTimeInDaysColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CumulativeProbabilityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDigitAssignmentColumn;
        private System.Windows.Forms.TextBox NumberOfDaysTextBox;
        private System.Windows.Forms.TextBox StartOrderQuantityTextBox;
        private System.Windows.Forms.TextBox StartLeadDaysTextBox;
        private System.Windows.Forms.TextBox StartInventoryQuantityTextBox;
        private System.Windows.Forms.TextBox ReviewPeriodTextBox;
        private System.Windows.Forms.Label LeadTimeDistributionLabel;
        private System.Windows.Forms.Label DemandDistributionLabel;
        private System.Windows.Forms.DataGridView SimulationTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CycleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayWithinCycleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginningInventoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDigitsForDemandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemandSimulationTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndingInventoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortageQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDigitsForLeadTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeadTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysUntilOrderArrivesColumn;
        private System.Windows.Forms.TabPage PerformanceMeasuresTabPage;
        private System.Windows.Forms.GroupBox PerformanceMeasuresGroupBox;
        private System.Windows.Forms.TextBox ShortageQuantityAverageTextBox;
        private System.Windows.Forms.Label ShortageQuantityAverageLabel;
        private System.Windows.Forms.TextBox EndingInventoryAverageTextBox;
        private System.Windows.Forms.Label EndingInventoryAverageLabel;
    }
}

