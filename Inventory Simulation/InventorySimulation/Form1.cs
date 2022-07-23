using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryModels;
using InventoryTesting;

namespace InventorySimulation
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private SimulationSystem system;

        private void chooseTestCaseButton_Click(object sender, EventArgs e)
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
                this.fillDemandTable();
                this.fillLeadTimeTable();
                this.fillSimulationTable();
                this.fillPerformanceMeasures();
            }

        }
        private void clearData()
        {
            this.OrderUpToTextBox.Text = "";
            this.ReviewPeriodTextBox.Text = "";
            this.StartInventoryQuantityTextBox.Text = "";
            this.StartLeadDaysTextBox.Text = "";
            this.NumberOfDaysTextBox.Text = "";
            this.DemandTable.Rows.Clear();
            this.LeadTimeInDaysTable.Rows.Clear();
            this.SimulationTable.Rows.Clear();
            
        }

        private void fillInputData()
        {
            OrderUpToTextBox.Text = system.OrderUpTo.ToString();
            ReviewPeriodTextBox.Text = system.ReviewPeriod.ToString();
            StartInventoryQuantityTextBox.Text = system.StartInventoryQuantity.ToString();
            StartLeadDaysTextBox.Text = system.StartLeadDays.ToString();
            StartOrderQuantityTextBox.Text = system.StartOrderQuantity.ToString();
            NumberOfDaysTextBox.Text = system.NumberOfDays.ToString();
        }

        private void fillDemandTable()
        {
            foreach (Distribution distribution in system.DemandDistribution)
            {
                DataGridViewRow row = (DataGridViewRow)DemandTable.Rows[0].Clone();
                row.Cells[0].Value = distribution.Value;
                row.Cells[1].Value = distribution.Probability;
                row.Cells[2].Value = distribution.CummProbability;
                row.Cells[3].Value = distribution.MinRange + "-" + distribution.MaxRange;
                DemandTable.Rows.Add(row);
            }
        }
        private void fillLeadTimeTable()
        {
            foreach (Distribution distribution in system.LeadDaysDistribution)
            {
                DataGridViewRow row = (DataGridViewRow)LeadTimeInDaysTable.Rows[0].Clone();
                row.Cells[0].Value = distribution.Value;
                row.Cells[1].Value = distribution.Probability;
                row.Cells[2].Value = distribution.CummProbability;
                row.Cells[3].Value = distribution.MinRange + "-" + distribution.MaxRange;
                LeadTimeInDaysTable.Rows.Add(row);
            }
        }

        private void fillSimulationTable()
        {
            foreach (SimulationCase simulationCase in system.SimulationCases)
            {
                DataGridViewRow row = (DataGridViewRow)SimulationTable.Rows[0].Clone();
                row.Cells[0].Value = simulationCase.Day;
                row.Cells[1].Value = simulationCase.Cycle;
                row.Cells[2].Value = simulationCase.DayWithinCycle;
                row.Cells[3].Value = simulationCase.BeginningInventory;
                row.Cells[4].Value = simulationCase.RandomDemand;
                row.Cells[5].Value = simulationCase.Demand;
                row.Cells[6].Value = simulationCase.EndingInventory;
                row.Cells[7].Value = simulationCase.ShortageQuantity;
                row.Cells[8].Value = simulationCase.OrderQuantity;
                row.Cells[9].Value = simulationCase.RandomLeadDays;
                row.Cells[10].Value = simulationCase.LeadDays;
                row.Cells[11].Value = simulationCase.DaysUntilOrderArrives;
                
                SimulationTable.Rows.Add(row);
            }
        }

        private void fillPerformanceMeasures()
        {
            EndingInventoryAverageTextBox.Text = system.PerformanceMeasures.EndingInventoryAverage.ToString();
            ShortageQuantityAverageTextBox.Text = system.PerformanceMeasures.ShortageQuantityAverage.ToString();
        }


    }
}
