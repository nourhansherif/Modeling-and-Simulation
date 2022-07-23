namespace NewspaperSellerSimulation
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.InputTab = new System.Windows.Forms.TabPage();
            this.DayTypeTab = new System.Windows.Forms.TabPage();
            this.btn_ChooseTest = new System.Windows.Forms.Button();
            this.SimulationTab = new System.Windows.Forms.TabPage();
            this.PerformanceTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DayTypeGrid = new System.Windows.Forms.DataGridView();
            this.TypeOfNewsDayColoumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SimulationTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Text_Sales = new System.Windows.Forms.TextBox();
            this.Text_WithUnsold = new System.Windows.Forms.TextBox();
            this.Text_Cost = new System.Windows.Forms.TextBox();
            this.Text_WithDemands = new System.Windows.Forms.TextBox();
            this.Text_Scrap = new System.Windows.Forms.TextBox();
            this.Text_NetProfit = new System.Windows.Forms.TextBox();
            this.Text_Lost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.InputTab.SuspendLayout();
            this.DayTypeTab.SuspendLayout();
            this.SimulationTab.SuspendLayout();
            this.PerformanceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayTypeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.InputTab);
            this.tabControl1.Controls.Add(this.DayTypeTab);
            this.tabControl1.Controls.Add(this.SimulationTab);
            this.tabControl1.Controls.Add(this.PerformanceTab);
            this.tabControl1.Location = new System.Drawing.Point(37, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // InputTab
            // 
            this.InputTab.Controls.Add(this.label5);
            this.InputTab.Controls.Add(this.label4);
            this.InputTab.Controls.Add(this.label3);
            this.InputTab.Controls.Add(this.label2);
            this.InputTab.Controls.Add(this.label1);
            this.InputTab.Controls.Add(this.textBox5);
            this.InputTab.Controls.Add(this.textBox4);
            this.InputTab.Controls.Add(this.textBox3);
            this.InputTab.Controls.Add(this.textBox2);
            this.InputTab.Controls.Add(this.textBox1);
            this.InputTab.Location = new System.Drawing.Point(4, 25);
            this.InputTab.Name = "InputTab";
            this.InputTab.Padding = new System.Windows.Forms.Padding(3);
            this.InputTab.Size = new System.Drawing.Size(997, 350);
            this.InputTab.TabIndex = 0;
            this.InputTab.Text = "Input Data";
            this.InputTab.UseVisualStyleBackColor = true;
            this.InputTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // DayTypeTab
            // 
            this.DayTypeTab.Controls.Add(this.DayTypeGrid);
            this.DayTypeTab.Location = new System.Drawing.Point(4, 25);
            this.DayTypeTab.Name = "DayTypeTab";
            this.DayTypeTab.Padding = new System.Windows.Forms.Padding(3);
            this.DayTypeTab.Size = new System.Drawing.Size(997, 350);
            this.DayTypeTab.TabIndex = 1;
            this.DayTypeTab.Text = "Day Type Data";
            this.DayTypeTab.UseVisualStyleBackColor = true;
            this.DayTypeTab.Click += new System.EventHandler(this.DayTypeTab_Click);
            // 
            // btn_ChooseTest
            // 
            this.btn_ChooseTest.Location = new System.Drawing.Point(37, 23);
            this.btn_ChooseTest.Name = "btn_ChooseTest";
            this.btn_ChooseTest.Size = new System.Drawing.Size(221, 38);
            this.btn_ChooseTest.TabIndex = 0;
            this.btn_ChooseTest.Text = "Choose Test Case";
            this.btn_ChooseTest.UseVisualStyleBackColor = true;
            this.btn_ChooseTest.Click += new System.EventHandler(this.btn_ChooseTest_Click);
            // 
            // SimulationTab
            // 
            this.SimulationTab.Controls.Add(this.SimulationTable);
            this.SimulationTab.Location = new System.Drawing.Point(4, 25);
            this.SimulationTab.Name = "SimulationTab";
            this.SimulationTab.Padding = new System.Windows.Forms.Padding(3);
            this.SimulationTab.Size = new System.Drawing.Size(997, 350);
            this.SimulationTab.TabIndex = 3;
            this.SimulationTab.Text = "Simulation Table ";
            this.SimulationTab.UseVisualStyleBackColor = true;
            // 
            // PerformanceTab
            // 
            this.PerformanceTab.Controls.Add(this.label12);
            this.PerformanceTab.Controls.Add(this.label11);
            this.PerformanceTab.Controls.Add(this.label10);
            this.PerformanceTab.Controls.Add(this.label9);
            this.PerformanceTab.Controls.Add(this.label8);
            this.PerformanceTab.Controls.Add(this.label7);
            this.PerformanceTab.Controls.Add(this.label6);
            this.PerformanceTab.Controls.Add(this.Text_Lost);
            this.PerformanceTab.Controls.Add(this.Text_NetProfit);
            this.PerformanceTab.Controls.Add(this.Text_Scrap);
            this.PerformanceTab.Controls.Add(this.Text_WithDemands);
            this.PerformanceTab.Controls.Add(this.Text_Cost);
            this.PerformanceTab.Controls.Add(this.Text_WithUnsold);
            this.PerformanceTab.Controls.Add(this.Text_Sales);
            this.PerformanceTab.Location = new System.Drawing.Point(4, 25);
            this.PerformanceTab.Name = "PerformanceTab";
            this.PerformanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.PerformanceTab.Size = new System.Drawing.Size(997, 350);
            this.PerformanceTab.TabIndex = 4;
            this.PerformanceTab.Text = "Performance Measures";
            this.PerformanceTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(44, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(44, 227);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(44, 292);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 22);
            this.textBox5.TabIndex = 4;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number Of Newspaper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number Of Records";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Purchase Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Scrap Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Selling Price";
            // 
            // DayTypeGrid
            // 
            this.DayTypeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DayTypeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeOfNewsDayColoumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.DayTypeGrid.Location = new System.Drawing.Point(55, 5);
            this.DayTypeGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DayTypeGrid.Name = "DayTypeGrid";
            this.DayTypeGrid.ReadOnly = true;
            this.DayTypeGrid.RowTemplate.Height = 24;
            this.DayTypeGrid.Size = new System.Drawing.Size(900, 295);
            this.DayTypeGrid.TabIndex = 13;
            // 
            // TypeOfNewsDayColoumn
            // 
            this.TypeOfNewsDayColoumn.HeaderText = "Type of News Day";
            this.TypeOfNewsDayColoumn.Name = "TypeOfNewsDayColoumn";
            this.TypeOfNewsDayColoumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Probability";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cumulative Probability";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Min Range";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Max Range";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // SimulationTable
            // 
            this.SimulationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimulationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Demand,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.SimulationTable.Location = new System.Drawing.Point(3, 5);
            this.SimulationTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SimulationTable.Name = "SimulationTable";
            this.SimulationTable.ReadOnly = true;
            this.SimulationTable.RowTemplate.Height = 24;
            this.SimulationTable.Size = new System.Drawing.Size(991, 343);
            this.SimulationTable.TabIndex = 14;
            this.SimulationTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Day Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Random Day Type ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Type of NewsDay";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Random Demand";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.Name = "Demand";
            this.Demand.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sales";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Lost Profit ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Scrap Profit ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Daily Profit";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Text_Sales
            // 
            this.Text_Sales.Location = new System.Drawing.Point(150, 65);
            this.Text_Sales.Name = "Text_Sales";
            this.Text_Sales.Size = new System.Drawing.Size(146, 22);
            this.Text_Sales.TabIndex = 0;
            // 
            // Text_WithUnsold
            // 
            this.Text_WithUnsold.Location = new System.Drawing.Point(644, 130);
            this.Text_WithUnsold.Name = "Text_WithUnsold";
            this.Text_WithUnsold.Size = new System.Drawing.Size(166, 22);
            this.Text_WithUnsold.TabIndex = 1;
            // 
            // Text_Cost
            // 
            this.Text_Cost.Location = new System.Drawing.Point(150, 130);
            this.Text_Cost.Name = "Text_Cost";
            this.Text_Cost.Size = new System.Drawing.Size(146, 22);
            this.Text_Cost.TabIndex = 2;
            // 
            // Text_WithDemands
            // 
            this.Text_WithDemands.Location = new System.Drawing.Point(644, 65);
            this.Text_WithDemands.Name = "Text_WithDemands";
            this.Text_WithDemands.Size = new System.Drawing.Size(166, 22);
            this.Text_WithDemands.TabIndex = 3;
            // 
            // Text_Scrap
            // 
            this.Text_Scrap.Location = new System.Drawing.Point(400, 65);
            this.Text_Scrap.Name = "Text_Scrap";
            this.Text_Scrap.Size = new System.Drawing.Size(134, 22);
            this.Text_Scrap.TabIndex = 4;
            // 
            // Text_NetProfit
            // 
            this.Text_NetProfit.Location = new System.Drawing.Point(400, 130);
            this.Text_NetProfit.Name = "Text_NetProfit";
            this.Text_NetProfit.Size = new System.Drawing.Size(134, 22);
            this.Text_NetProfit.TabIndex = 5;
            // 
            // Text_Lost
            // 
            this.Text_Lost.Location = new System.Drawing.Point(150, 208);
            this.Text_Lost.Name = "Text_Lost";
            this.Text_Lost.Size = new System.Drawing.Size(146, 22);
            this.Text_Lost.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Sales Profit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total Lost Profit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total Scrap Profit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Total Net Profit";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(638, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Days With More Demands";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(641, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Days With Unsold Papers";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 458);
            this.Controls.Add(this.btn_ChooseTest);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.InputTab.ResumeLayout(false);
            this.InputTab.PerformLayout();
            this.DayTypeTab.ResumeLayout(false);
            this.SimulationTab.ResumeLayout(false);
            this.PerformanceTab.ResumeLayout(false);
            this.PerformanceTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DayTypeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage InputTab;
        private System.Windows.Forms.TabPage DayTypeTab;
        private System.Windows.Forms.Button btn_ChooseTest;
        private System.Windows.Forms.TabPage SimulationTab;
        private System.Windows.Forms.TabPage PerformanceTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DayTypeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfNewsDayColoumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView SimulationTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Text_Lost;
        private System.Windows.Forms.TextBox Text_NetProfit;
        private System.Windows.Forms.TextBox Text_Scrap;
        private System.Windows.Forms.TextBox Text_WithDemands;
        private System.Windows.Forms.TextBox Text_Cost;
        private System.Windows.Forms.TextBox Text_WithUnsold;
        private System.Windows.Forms.TextBox Text_Sales;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}