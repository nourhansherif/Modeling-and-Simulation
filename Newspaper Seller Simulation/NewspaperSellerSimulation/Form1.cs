using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        private SimulationSystem system;


        public Form1()
        {
            InitializeComponent();
        }
        

        private void btn_ChooseTest_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).FullName).FullName,
                Title = "Choose A File",
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.clearData();
                system = Program.runSimulation(openFileDialog.FileName);
                this.fillInputData();
                this.fillSimulationTable();
                this.fillPerformanceMeasures();
                this.fillDayTypeDistribution();

            }
        }

        private void clearData()
        {
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.Text_NetProfit.Text = "";
            this.Text_Lost.Text = "";
            this.Text_Scrap.Text = "";
            this.Text_Sales.Text = "";
            this.Text_WithDemands.Text = "";
            this.Text_WithUnsold.Text = "";
            this.Text_Cost.Text = "";
            this.DayTypeGrid.Rows.Clear();
            this.SimulationTable.Rows.Clear();

        }


        private void fillInputData()
        {
            textBox3.Text = system.NumOfNewspapers.ToString();
            textBox1.Text = system.NumOfRecords.ToString();
            textBox2.Text = system.PurchasePrice.ToString();
            textBox4.Text = system.ScrapPrice.ToString();
            textBox5.Text = system.SellingPrice.ToString();
        }


        private void fillSimulationTable()
        {
            foreach (SimulationCase simulationCase in system.SimulationTable)
            {
                
                DataGridViewRow row = (DataGridViewRow)SimulationTable.Rows[0].Clone();
                row.Cells[0].Value = simulationCase.DayNo;
                row.Cells[1].Value = simulationCase.RandomNewsDayType;
                row.Cells[2].Value = simulationCase.NewsDayType;
                row.Cells[3].Value = simulationCase.RandomDemand;
                row.Cells[4].Value = simulationCase.Demand;
                row.Cells[5].Value = simulationCase.SalesProfit;
                row.Cells[6].Value = simulationCase.LostProfit;
                row.Cells[7].Value = simulationCase.ScrapProfit;
                row.Cells[8].Value = simulationCase.DailyNetProfit;

                SimulationTable.Rows.Add(row);

            }

        }


        private void fillDayTypeDistribution()
        {
            foreach (DayTypeDistribution DayDistribution in system.DayTypeDistributions)
            {
                DataGridViewRow row = (DataGridViewRow)DayTypeGrid.Rows[0].Clone();
                row.Cells[0].Value = DayDistribution.DayType;
                row.Cells[1].Value = DayDistribution.Probability;
                row.Cells[2].Value = DayDistribution.CummProbability;
                row.Cells[3].Value = DayDistribution.MinRange;
                row.Cells[4].Value = DayDistribution.MaxRange;
                DayTypeGrid.Rows.Add(row);
            }
        }


        private void fillPerformanceMeasures()
        {
            Text_Sales.Text = system.PerformanceMeasures.TotalSalesProfit.ToString();
            Text_Cost.Text = system.PerformanceMeasures.TotalCost.ToString();
            Text_Lost.Text = system.PerformanceMeasures.TotalLostProfit.ToString();
            Text_Scrap.Text = system.PerformanceMeasures.TotalScrapProfit.ToString();
            Text_NetProfit.Text = system.PerformanceMeasures.TotalNetProfit.ToString();
            Text_WithDemands.Text = system.PerformanceMeasures.DaysWithMoreDemand.ToString();
            Text_WithUnsold.Text = system.PerformanceMeasures.DaysWithUnsoldPapers.ToString();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void InterarrivalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InterarrivalTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InterarrivalTable_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DayTypeTab_Click(object sender, EventArgs e)
        {

        }
    }
}
