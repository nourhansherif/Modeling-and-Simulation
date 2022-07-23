namespace MultiQueueSimulation
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chooseTestCaseButton = new System.Windows.Forms.Button();
            this.numberOfServersLabel = new System.Windows.Forms.Label();
            this.numberOfServersText = new System.Windows.Forms.TextBox();
            this.InputDataTab = new System.Windows.Forms.TabControl();
            this.InputData = new System.Windows.Forms.TabPage();
            this.InterarrivalTable = new System.Windows.Forms.DataGridView();
            this.InterarrivalTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CumulativeProbabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinRangeColunn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxRangeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectionMethodLabel = new System.Windows.Forms.Label();
            this.stoppingCriteriaLabel = new System.Windows.Forms.Label();
            this.selectionMethodText = new System.Windows.Forms.TextBox();
            this.stoppingCriteriaText = new System.Windows.Forms.TextBox();
            this.numberOfCustomersText = new System.Windows.Forms.TextBox();
            this.numberOfCustomersLabel = new System.Windows.Forms.Label();
            this.ServerData = new System.Windows.Forms.TabPage();
            this.ChooseServerLabel = new System.Windows.Forms.Label();
            this.chooseServerComboBox = new System.Windows.Forms.ComboBox();
            this.serverDataTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simulationTableTab = new System.Windows.Forms.TabPage();
            this.SimulationTable = new System.Windows.Forms.DataGridView();
            this.CustomerNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDigitInterArrivalTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterArrivalTimeColumnTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDigitServiceDurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeServiceBeginsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeServiceEndsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeInQueueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerformanceMeasuresTab = new System.Windows.Forms.TabPage();
            this.WaitingProbabilityText = new System.Windows.Forms.TextBox();
            this.WaitingProbabilityLabel = new System.Windows.Forms.Label();
            this.MaxQueueLengthText = new System.Windows.Forms.TextBox();
            this.MaxQueueLengthLabel = new System.Windows.Forms.Label();
            this.AverageWaitingTimeText = new System.Windows.Forms.TextBox();
            this.AverageWaitingTimeLabel = new System.Windows.Forms.Label();
            this.ServerPerformancePage = new System.Windows.Forms.TabPage();
            this.performanceMeasuresGroupBox = new System.Windows.Forms.GroupBox();
            this.UtilizationText = new System.Windows.Forms.TextBox();
            this.UtilizationLabel = new System.Windows.Forms.Label();
            this.AverageServiceTimeText = new System.Windows.Forms.TextBox();
            this.AverageServiceTimeLabel = new System.Windows.Forms.Label();
            this.IdleProbabilityText = new System.Windows.Forms.TextBox();
            this.IdleProbabilityLabel = new System.Windows.Forms.Label();
            this.chooseServerLabel2 = new System.Windows.Forms.Label();
            this.chooseServerComboBox2 = new System.Windows.Forms.ComboBox();
            this.serverPerformanceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InputDataTab.SuspendLayout();
            this.InputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InterarrivalTable)).BeginInit();
            this.ServerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverDataTable)).BeginInit();
            this.simulationTableTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationTable)).BeginInit();
            this.PerformanceMeasuresTab.SuspendLayout();
            this.ServerPerformancePage.SuspendLayout();
            this.performanceMeasuresGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverPerformanceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseTestCaseButton
            // 
            this.chooseTestCaseButton.Location = new System.Drawing.Point(40, 24);
            this.chooseTestCaseButton.Margin = new System.Windows.Forms.Padding(2);
            this.chooseTestCaseButton.Name = "chooseTestCaseButton";
            this.chooseTestCaseButton.Size = new System.Drawing.Size(134, 32);
            this.chooseTestCaseButton.TabIndex = 0;
            this.chooseTestCaseButton.Text = "Choose A Test Case";
            this.chooseTestCaseButton.UseVisualStyleBackColor = true;
            this.chooseTestCaseButton.Click += new System.EventHandler(this.chooseTestCaseButton_Click);
            // 
            // numberOfServersLabel
            // 
            this.numberOfServersLabel.AutoSize = true;
            this.numberOfServersLabel.Location = new System.Drawing.Point(75, 13);
            this.numberOfServersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfServersLabel.Name = "numberOfServersLabel";
            this.numberOfServersLabel.Size = new System.Drawing.Size(97, 13);
            this.numberOfServersLabel.TabIndex = 1;
            this.numberOfServersLabel.Text = "Number Of Servers";
            // 
            // numberOfServersText
            // 
            this.numberOfServersText.Location = new System.Drawing.Point(34, 29);
            this.numberOfServersText.Margin = new System.Windows.Forms.Padding(2);
            this.numberOfServersText.Name = "numberOfServersText";
            this.numberOfServersText.ReadOnly = true;
            this.numberOfServersText.Size = new System.Drawing.Size(186, 20);
            this.numberOfServersText.TabIndex = 2;
            this.numberOfServersText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputDataTab
            // 
            this.InputDataTab.Controls.Add(this.InputData);
            this.InputDataTab.Controls.Add(this.ServerData);
            this.InputDataTab.Controls.Add(this.simulationTableTab);
            this.InputDataTab.Controls.Add(this.PerformanceMeasuresTab);
            this.InputDataTab.Controls.Add(this.ServerPerformancePage);
            this.InputDataTab.Location = new System.Drawing.Point(18, 80);
            this.InputDataTab.Margin = new System.Windows.Forms.Padding(2);
            this.InputDataTab.Name = "InputDataTab";
            this.InputDataTab.SelectedIndex = 0;
            this.InputDataTab.Size = new System.Drawing.Size(814, 293);
            this.InputDataTab.TabIndex = 3;
            // 
            // InputData
            // 
            this.InputData.Controls.Add(this.InterarrivalTable);
            this.InputData.Controls.Add(this.selectionMethodLabel);
            this.InputData.Controls.Add(this.stoppingCriteriaLabel);
            this.InputData.Controls.Add(this.selectionMethodText);
            this.InputData.Controls.Add(this.stoppingCriteriaText);
            this.InputData.Controls.Add(this.numberOfCustomersText);
            this.InputData.Controls.Add(this.numberOfCustomersLabel);
            this.InputData.Controls.Add(this.numberOfServersLabel);
            this.InputData.Controls.Add(this.numberOfServersText);
            this.InputData.Location = new System.Drawing.Point(4, 22);
            this.InputData.Margin = new System.Windows.Forms.Padding(2);
            this.InputData.Name = "InputData";
            this.InputData.Padding = new System.Windows.Forms.Padding(2);
            this.InputData.Size = new System.Drawing.Size(806, 267);
            this.InputData.TabIndex = 0;
            this.InputData.Text = "Input Data";
            this.InputData.UseVisualStyleBackColor = true;
            // 
            // InterarrivalTable
            // 
            this.InterarrivalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InterarrivalTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InterarrivalTimeColumn,
            this.ProbabilityColumn,
            this.CumulativeProbabilityColumn,
            this.MinRangeColunn,
            this.MaxRangeColumn});
            this.InterarrivalTable.Location = new System.Drawing.Point(244, 21);
            this.InterarrivalTable.Margin = new System.Windows.Forms.Padding(2);
            this.InterarrivalTable.Name = "InterarrivalTable";
            this.InterarrivalTable.ReadOnly = true;
            this.InterarrivalTable.RowTemplate.Height = 24;
            this.InterarrivalTable.Size = new System.Drawing.Size(541, 197);
            this.InterarrivalTable.TabIndex = 9;
            // 
            // InterarrivalTimeColumn
            // 
            this.InterarrivalTimeColumn.HeaderText = "Interarrival Time";
            this.InterarrivalTimeColumn.Name = "InterarrivalTimeColumn";
            this.InterarrivalTimeColumn.ReadOnly = true;
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
            // MinRangeColunn
            // 
            this.MinRangeColunn.HeaderText = "Min Range";
            this.MinRangeColunn.Name = "MinRangeColunn";
            this.MinRangeColunn.ReadOnly = true;
            // 
            // MaxRangeColumn
            // 
            this.MaxRangeColumn.HeaderText = "Max Range";
            this.MaxRangeColumn.Name = "MaxRangeColumn";
            this.MaxRangeColumn.ReadOnly = true;
            // 
            // selectionMethodLabel
            // 
            this.selectionMethodLabel.AutoSize = true;
            this.selectionMethodLabel.Location = new System.Drawing.Point(75, 170);
            this.selectionMethodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectionMethodLabel.Name = "selectionMethodLabel";
            this.selectionMethodLabel.Size = new System.Drawing.Size(90, 13);
            this.selectionMethodLabel.TabIndex = 8;
            this.selectionMethodLabel.Text = "Selection Method";
            // 
            // stoppingCriteriaLabel
            // 
            this.stoppingCriteriaLabel.AutoSize = true;
            this.stoppingCriteriaLabel.Location = new System.Drawing.Point(78, 117);
            this.stoppingCriteriaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stoppingCriteriaLabel.Name = "stoppingCriteriaLabel";
            this.stoppingCriteriaLabel.Size = new System.Drawing.Size(84, 13);
            this.stoppingCriteriaLabel.TabIndex = 7;
            this.stoppingCriteriaLabel.Text = "Stopping Criteria";
            // 
            // selectionMethodText
            // 
            this.selectionMethodText.Location = new System.Drawing.Point(34, 186);
            this.selectionMethodText.Margin = new System.Windows.Forms.Padding(2);
            this.selectionMethodText.Name = "selectionMethodText";
            this.selectionMethodText.ReadOnly = true;
            this.selectionMethodText.Size = new System.Drawing.Size(186, 20);
            this.selectionMethodText.TabIndex = 6;
            this.selectionMethodText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stoppingCriteriaText
            // 
            this.stoppingCriteriaText.Location = new System.Drawing.Point(34, 133);
            this.stoppingCriteriaText.Margin = new System.Windows.Forms.Padding(2);
            this.stoppingCriteriaText.Name = "stoppingCriteriaText";
            this.stoppingCriteriaText.ReadOnly = true;
            this.stoppingCriteriaText.Size = new System.Drawing.Size(186, 20);
            this.stoppingCriteriaText.TabIndex = 5;
            this.stoppingCriteriaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberOfCustomersText
            // 
            this.numberOfCustomersText.Location = new System.Drawing.Point(34, 80);
            this.numberOfCustomersText.Margin = new System.Windows.Forms.Padding(2);
            this.numberOfCustomersText.Name = "numberOfCustomersText";
            this.numberOfCustomersText.ReadOnly = true;
            this.numberOfCustomersText.Size = new System.Drawing.Size(186, 20);
            this.numberOfCustomersText.TabIndex = 4;
            this.numberOfCustomersText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberOfCustomersLabel
            // 
            this.numberOfCustomersLabel.AutoSize = true;
            this.numberOfCustomersLabel.Location = new System.Drawing.Point(68, 64);
            this.numberOfCustomersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfCustomersLabel.Name = "numberOfCustomersLabel";
            this.numberOfCustomersLabel.Size = new System.Drawing.Size(110, 13);
            this.numberOfCustomersLabel.TabIndex = 3;
            this.numberOfCustomersLabel.Text = "Number Of Customers";
            // 
            // ServerData
            // 
            this.ServerData.Controls.Add(this.ChooseServerLabel);
            this.ServerData.Controls.Add(this.chooseServerComboBox);
            this.ServerData.Controls.Add(this.serverDataTable);
            this.ServerData.Location = new System.Drawing.Point(4, 22);
            this.ServerData.Margin = new System.Windows.Forms.Padding(2);
            this.ServerData.Name = "ServerData";
            this.ServerData.Padding = new System.Windows.Forms.Padding(2);
            this.ServerData.Size = new System.Drawing.Size(806, 267);
            this.ServerData.TabIndex = 1;
            this.ServerData.Text = "Server Data";
            this.ServerData.UseVisualStyleBackColor = true;
            // 
            // ChooseServerLabel
            // 
            this.ChooseServerLabel.AutoSize = true;
            this.ChooseServerLabel.Location = new System.Drawing.Point(16, 44);
            this.ChooseServerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseServerLabel.Name = "ChooseServerLabel";
            this.ChooseServerLabel.Size = new System.Drawing.Size(86, 13);
            this.ChooseServerLabel.TabIndex = 12;
            this.ChooseServerLabel.Text = "Choose a Server";
            // 
            // chooseServerComboBox
            // 
            this.chooseServerComboBox.FormattingEnabled = true;
            this.chooseServerComboBox.Location = new System.Drawing.Point(114, 44);
            this.chooseServerComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.chooseServerComboBox.Name = "chooseServerComboBox";
            this.chooseServerComboBox.Size = new System.Drawing.Size(92, 21);
            this.chooseServerComboBox.TabIndex = 11;
            this.chooseServerComboBox.SelectedIndexChanged += new System.EventHandler(this.chooseServerComboBox_SelectedIndexChanged);
            // 
            // serverDataTable
            // 
            this.serverDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serverDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.serverDataTable.Location = new System.Drawing.Point(244, 18);
            this.serverDataTable.Margin = new System.Windows.Forms.Padding(2);
            this.serverDataTable.Name = "serverDataTable";
            this.serverDataTable.ReadOnly = true;
            this.serverDataTable.RowTemplate.Height = 24;
            this.serverDataTable.Size = new System.Drawing.Size(541, 197);
            this.serverDataTable.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Interarrival Time";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn4.HeaderText = "Min Range";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Max Range";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // simulationTableTab
            // 
            this.simulationTableTab.Controls.Add(this.SimulationTable);
            this.simulationTableTab.Location = new System.Drawing.Point(4, 22);
            this.simulationTableTab.Margin = new System.Windows.Forms.Padding(2);
            this.simulationTableTab.Name = "simulationTableTab";
            this.simulationTableTab.Padding = new System.Windows.Forms.Padding(2);
            this.simulationTableTab.Size = new System.Drawing.Size(806, 267);
            this.simulationTableTab.TabIndex = 4;
            this.simulationTableTab.Text = "Simulation Table";
            this.simulationTableTab.UseVisualStyleBackColor = true;
            // 
            // SimulationTable
            // 
            this.SimulationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimulationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerNumberColumn,
            this.RandomDigitInterArrivalTimeColumn,
            this.InterArrivalTimeColumnTable,
            this.ArrivalTime,
            this.RandomDigitServiceDurationColumn,
            this.ServiceDurationColumn,
            this.ServerIDColumn,
            this.TimeServiceBeginsColumn,
            this.TimeServiceEndsColumn,
            this.TimeInQueueColumn});
            this.SimulationTable.Location = new System.Drawing.Point(4, 5);
            this.SimulationTable.Margin = new System.Windows.Forms.Padding(2);
            this.SimulationTable.Name = "SimulationTable";
            this.SimulationTable.RowTemplate.Height = 24;
            this.SimulationTable.Size = new System.Drawing.Size(800, 260);
            this.SimulationTable.TabIndex = 0;
            // 
            // CustomerNumberColumn
            // 
            this.CustomerNumberColumn.HeaderText = "CustomerNumber";
            this.CustomerNumberColumn.Name = "CustomerNumberColumn";
            // 
            // RandomDigitInterArrivalTimeColumn
            // 
            this.RandomDigitInterArrivalTimeColumn.HeaderText = "Random Digits For InterArrival Time";
            this.RandomDigitInterArrivalTimeColumn.Name = "RandomDigitInterArrivalTimeColumn";
            // 
            // InterArrivalTimeColumnTable
            // 
            this.InterArrivalTimeColumnTable.HeaderText = "InterArrival Time";
            this.InterArrivalTimeColumnTable.Name = "InterArrivalTimeColumnTable";
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "Arrival Time";
            this.ArrivalTime.Name = "ArrivalTime";
            // 
            // RandomDigitServiceDurationColumn
            // 
            this.RandomDigitServiceDurationColumn.HeaderText = "Random Digits For Service Duration";
            this.RandomDigitServiceDurationColumn.Name = "RandomDigitServiceDurationColumn";
            // 
            // ServiceDurationColumn
            // 
            this.ServiceDurationColumn.HeaderText = "Service Duration";
            this.ServiceDurationColumn.Name = "ServiceDurationColumn";
            // 
            // ServerIDColumn
            // 
            this.ServerIDColumn.HeaderText = "Server ID";
            this.ServerIDColumn.Name = "ServerIDColumn";
            // 
            // TimeServiceBeginsColumn
            // 
            this.TimeServiceBeginsColumn.HeaderText = "Time Service Begin";
            this.TimeServiceBeginsColumn.Name = "TimeServiceBeginsColumn";
            // 
            // TimeServiceEndsColumn
            // 
            this.TimeServiceEndsColumn.HeaderText = "Time Service End";
            this.TimeServiceEndsColumn.Name = "TimeServiceEndsColumn";
            // 
            // TimeInQueueColumn
            // 
            this.TimeInQueueColumn.HeaderText = "TimeInQueue";
            this.TimeInQueueColumn.Name = "TimeInQueueColumn";
            // 
            // PerformanceMeasuresTab
            // 
            this.PerformanceMeasuresTab.Controls.Add(this.WaitingProbabilityText);
            this.PerformanceMeasuresTab.Controls.Add(this.WaitingProbabilityLabel);
            this.PerformanceMeasuresTab.Controls.Add(this.MaxQueueLengthText);
            this.PerformanceMeasuresTab.Controls.Add(this.MaxQueueLengthLabel);
            this.PerformanceMeasuresTab.Controls.Add(this.AverageWaitingTimeText);
            this.PerformanceMeasuresTab.Controls.Add(this.AverageWaitingTimeLabel);
            this.PerformanceMeasuresTab.Location = new System.Drawing.Point(4, 22);
            this.PerformanceMeasuresTab.Margin = new System.Windows.Forms.Padding(2);
            this.PerformanceMeasuresTab.Name = "PerformanceMeasuresTab";
            this.PerformanceMeasuresTab.Size = new System.Drawing.Size(806, 267);
            this.PerformanceMeasuresTab.TabIndex = 2;
            this.PerformanceMeasuresTab.Text = "Performance Measures";
            this.PerformanceMeasuresTab.UseVisualStyleBackColor = true;
            // 
            // WaitingProbabilityText
            // 
            this.WaitingProbabilityText.Location = new System.Drawing.Point(236, 165);
            this.WaitingProbabilityText.Margin = new System.Windows.Forms.Padding(2);
            this.WaitingProbabilityText.Name = "WaitingProbabilityText";
            this.WaitingProbabilityText.ReadOnly = true;
            this.WaitingProbabilityText.Size = new System.Drawing.Size(281, 20);
            this.WaitingProbabilityText.TabIndex = 25;
            this.WaitingProbabilityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WaitingProbabilityLabel
            // 
            this.WaitingProbabilityLabel.AutoSize = true;
            this.WaitingProbabilityLabel.Location = new System.Drawing.Point(346, 149);
            this.WaitingProbabilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WaitingProbabilityLabel.Name = "WaitingProbabilityLabel";
            this.WaitingProbabilityLabel.Size = new System.Drawing.Size(94, 13);
            this.WaitingProbabilityLabel.TabIndex = 24;
            this.WaitingProbabilityLabel.Text = "Waiting Probability";
            // 
            // MaxQueueLengthText
            // 
            this.MaxQueueLengthText.Location = new System.Drawing.Point(236, 112);
            this.MaxQueueLengthText.Margin = new System.Windows.Forms.Padding(2);
            this.MaxQueueLengthText.Name = "MaxQueueLengthText";
            this.MaxQueueLengthText.ReadOnly = true;
            this.MaxQueueLengthText.Size = new System.Drawing.Size(281, 20);
            this.MaxQueueLengthText.TabIndex = 23;
            this.MaxQueueLengthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaxQueueLengthLabel
            // 
            this.MaxQueueLengthLabel.AutoSize = true;
            this.MaxQueueLengthLabel.Location = new System.Drawing.Point(328, 96);
            this.MaxQueueLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaxQueueLengthLabel.Name = "MaxQueueLengthLabel";
            this.MaxQueueLengthLabel.Size = new System.Drawing.Size(98, 13);
            this.MaxQueueLengthLabel.TabIndex = 22;
            this.MaxQueueLengthLabel.Text = "Max Queue Length";
            // 
            // AverageWaitingTimeText
            // 
            this.AverageWaitingTimeText.Location = new System.Drawing.Point(236, 64);
            this.AverageWaitingTimeText.Margin = new System.Windows.Forms.Padding(2);
            this.AverageWaitingTimeText.Name = "AverageWaitingTimeText";
            this.AverageWaitingTimeText.ReadOnly = true;
            this.AverageWaitingTimeText.Size = new System.Drawing.Size(281, 20);
            this.AverageWaitingTimeText.TabIndex = 21;
            this.AverageWaitingTimeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AverageWaitingTimeLabel
            // 
            this.AverageWaitingTimeLabel.AutoSize = true;
            this.AverageWaitingTimeLabel.Location = new System.Drawing.Point(336, 41);
            this.AverageWaitingTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AverageWaitingTimeLabel.Name = "AverageWaitingTimeLabel";
            this.AverageWaitingTimeLabel.Size = new System.Drawing.Size(112, 13);
            this.AverageWaitingTimeLabel.TabIndex = 20;
            this.AverageWaitingTimeLabel.Text = "Average Waiting Time";
            // 
            // ServerPerformancePage
            // 
            this.ServerPerformancePage.Controls.Add(this.serverPerformanceChart);
            this.ServerPerformancePage.Controls.Add(this.performanceMeasuresGroupBox);
            this.ServerPerformancePage.Controls.Add(this.chooseServerLabel2);
            this.ServerPerformancePage.Controls.Add(this.chooseServerComboBox2);
            this.ServerPerformancePage.Location = new System.Drawing.Point(4, 22);
            this.ServerPerformancePage.Margin = new System.Windows.Forms.Padding(2);
            this.ServerPerformancePage.Name = "ServerPerformancePage";
            this.ServerPerformancePage.Size = new System.Drawing.Size(806, 267);
            this.ServerPerformancePage.TabIndex = 3;
            this.ServerPerformancePage.Text = "Server Performance";
            this.ServerPerformancePage.UseVisualStyleBackColor = true;
            // 
            // performanceMeasuresGroupBox
            // 
            this.performanceMeasuresGroupBox.Controls.Add(this.UtilizationText);
            this.performanceMeasuresGroupBox.Controls.Add(this.UtilizationLabel);
            this.performanceMeasuresGroupBox.Controls.Add(this.AverageServiceTimeText);
            this.performanceMeasuresGroupBox.Controls.Add(this.AverageServiceTimeLabel);
            this.performanceMeasuresGroupBox.Controls.Add(this.IdleProbabilityText);
            this.performanceMeasuresGroupBox.Controls.Add(this.IdleProbabilityLabel);
            this.performanceMeasuresGroupBox.Location = new System.Drawing.Point(12, 57);
            this.performanceMeasuresGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.performanceMeasuresGroupBox.Name = "performanceMeasuresGroupBox";
            this.performanceMeasuresGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.performanceMeasuresGroupBox.Size = new System.Drawing.Size(314, 204);
            this.performanceMeasuresGroupBox.TabIndex = 20;
            this.performanceMeasuresGroupBox.TabStop = false;
            this.performanceMeasuresGroupBox.Text = "Performance Measures";
            // 
            // UtilizationText
            // 
            this.UtilizationText.Location = new System.Drawing.Point(18, 140);
            this.UtilizationText.Margin = new System.Windows.Forms.Padding(2);
            this.UtilizationText.Name = "UtilizationText";
            this.UtilizationText.ReadOnly = true;
            this.UtilizationText.Size = new System.Drawing.Size(281, 20);
            this.UtilizationText.TabIndex = 19;
            this.UtilizationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UtilizationLabel
            // 
            this.UtilizationLabel.AutoSize = true;
            this.UtilizationLabel.Location = new System.Drawing.Point(135, 124);
            this.UtilizationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UtilizationLabel.Name = "UtilizationLabel";
            this.UtilizationLabel.Size = new System.Drawing.Size(52, 13);
            this.UtilizationLabel.TabIndex = 18;
            this.UtilizationLabel.Text = "Utilization";
            // 
            // AverageServiceTimeText
            // 
            this.AverageServiceTimeText.Location = new System.Drawing.Point(18, 87);
            this.AverageServiceTimeText.Margin = new System.Windows.Forms.Padding(2);
            this.AverageServiceTimeText.Name = "AverageServiceTimeText";
            this.AverageServiceTimeText.ReadOnly = true;
            this.AverageServiceTimeText.Size = new System.Drawing.Size(281, 20);
            this.AverageServiceTimeText.TabIndex = 17;
            this.AverageServiceTimeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AverageServiceTimeLabel
            // 
            this.AverageServiceTimeLabel.AutoSize = true;
            this.AverageServiceTimeLabel.Location = new System.Drawing.Point(110, 71);
            this.AverageServiceTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AverageServiceTimeLabel.Name = "AverageServiceTimeLabel";
            this.AverageServiceTimeLabel.Size = new System.Drawing.Size(112, 13);
            this.AverageServiceTimeLabel.TabIndex = 16;
            this.AverageServiceTimeLabel.Text = "Average Service Time";
            // 
            // IdleProbabilityText
            // 
            this.IdleProbabilityText.Location = new System.Drawing.Point(18, 39);
            this.IdleProbabilityText.Margin = new System.Windows.Forms.Padding(2);
            this.IdleProbabilityText.Name = "IdleProbabilityText";
            this.IdleProbabilityText.ReadOnly = true;
            this.IdleProbabilityText.Size = new System.Drawing.Size(281, 20);
            this.IdleProbabilityText.TabIndex = 15;
            this.IdleProbabilityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IdleProbabilityLabel
            // 
            this.IdleProbabilityLabel.AutoSize = true;
            this.IdleProbabilityLabel.Location = new System.Drawing.Point(128, 23);
            this.IdleProbabilityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdleProbabilityLabel.Name = "IdleProbabilityLabel";
            this.IdleProbabilityLabel.Size = new System.Drawing.Size(75, 13);
            this.IdleProbabilityLabel.TabIndex = 14;
            this.IdleProbabilityLabel.Text = "Idle Probability";
            // 
            // chooseServerLabel2
            // 
            this.chooseServerLabel2.AutoSize = true;
            this.chooseServerLabel2.Location = new System.Drawing.Point(16, 30);
            this.chooseServerLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseServerLabel2.Name = "chooseServerLabel2";
            this.chooseServerLabel2.Size = new System.Drawing.Size(86, 13);
            this.chooseServerLabel2.TabIndex = 13;
            this.chooseServerLabel2.Text = "Choose a Server";
            // 
            // chooseServerComboBox2
            // 
            this.chooseServerComboBox2.FormattingEnabled = true;
            this.chooseServerComboBox2.Location = new System.Drawing.Point(124, 28);
            this.chooseServerComboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.chooseServerComboBox2.Name = "chooseServerComboBox2";
            this.chooseServerComboBox2.Size = new System.Drawing.Size(92, 21);
            this.chooseServerComboBox2.TabIndex = 12;
            this.chooseServerComboBox2.SelectedIndexChanged += new System.EventHandler(this.chooseServerComboBox2_SelectedIndexChanged);
            // 
            // serverPerformanceChart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.serverPerformanceChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.serverPerformanceChart.Legends.Add(legend1);
            this.serverPerformanceChart.Location = new System.Drawing.Point(331, 1);
            this.serverPerformanceChart.Name = "serverPerformanceChart";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "PointWidth=1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.serverPerformanceChart.Series.Add(series1);
            this.serverPerformanceChart.Size = new System.Drawing.Size(475, 263);
            this.serverPerformanceChart.TabIndex = 20;
            this.serverPerformanceChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 469);
            this.Controls.Add(this.InputDataTab);
            this.Controls.Add(this.chooseTestCaseButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.InputDataTab.ResumeLayout(false);
            this.InputData.ResumeLayout(false);
            this.InputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InterarrivalTable)).EndInit();
            this.ServerData.ResumeLayout(false);
            this.ServerData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverDataTable)).EndInit();
            this.simulationTableTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SimulationTable)).EndInit();
            this.PerformanceMeasuresTab.ResumeLayout(false);
            this.PerformanceMeasuresTab.PerformLayout();
            this.ServerPerformancePage.ResumeLayout(false);
            this.ServerPerformancePage.PerformLayout();
            this.performanceMeasuresGroupBox.ResumeLayout(false);
            this.performanceMeasuresGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverPerformanceChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chooseTestCaseButton;
        private System.Windows.Forms.Label numberOfServersLabel;
        private System.Windows.Forms.TabControl InputDataTab;
        private System.Windows.Forms.TabPage InputData;
        private System.Windows.Forms.DataGridView InterarrivalTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterarrivalTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CumulativeProbabilityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinRangeColunn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxRangeColumn;
        private System.Windows.Forms.Label selectionMethodLabel;
        private System.Windows.Forms.Label stoppingCriteriaLabel;
        private System.Windows.Forms.TextBox selectionMethodText;
        private System.Windows.Forms.TextBox stoppingCriteriaText;
        private System.Windows.Forms.TextBox numberOfCustomersText;
        private System.Windows.Forms.Label numberOfCustomersLabel;
        private System.Windows.Forms.TabPage ServerData;
        private System.Windows.Forms.TextBox numberOfServersText;
        private System.Windows.Forms.Label ChooseServerLabel;
        private System.Windows.Forms.ComboBox chooseServerComboBox;
        private System.Windows.Forms.DataGridView serverDataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage PerformanceMeasuresTab;
        private System.Windows.Forms.TabPage ServerPerformancePage;
        private System.Windows.Forms.Label chooseServerLabel2;
        private System.Windows.Forms.ComboBox chooseServerComboBox2;
        private System.Windows.Forms.TextBox IdleProbabilityText;
        private System.Windows.Forms.Label IdleProbabilityLabel;
        private System.Windows.Forms.TextBox UtilizationText;
        private System.Windows.Forms.Label UtilizationLabel;
        private System.Windows.Forms.TextBox AverageServiceTimeText;
        private System.Windows.Forms.Label AverageServiceTimeLabel;
        private System.Windows.Forms.GroupBox performanceMeasuresGroupBox;
        private System.Windows.Forms.TextBox WaitingProbabilityText;
        private System.Windows.Forms.Label WaitingProbabilityLabel;
        private System.Windows.Forms.TextBox MaxQueueLengthText;
        private System.Windows.Forms.Label MaxQueueLengthLabel;
        private System.Windows.Forms.TextBox AverageWaitingTimeText;
        private System.Windows.Forms.Label AverageWaitingTimeLabel;
        private System.Windows.Forms.TabPage simulationTableTab;
        private System.Windows.Forms.DataGridView SimulationTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDigitInterArrivalTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterArrivalTimeColumnTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDigitServiceDurationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDurationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeServiceBeginsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeServiceEndsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeInQueueColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart serverPerformanceChart;
    }
}

