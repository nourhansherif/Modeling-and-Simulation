using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;
using System.Reflection;

namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
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
                this.fillServerInfo();
                this.fillInterArrivalTable();
                this.fillSimulationTable();
                this.fillPerformanceMeasures();
            }
        }
        private void clearData()
        {
            this.numberOfServersText.Text = "";
            this.numberOfCustomersText.Text = "";
            this.stoppingCriteriaText.Text = "";
            this.selectionMethodText.Text = "";
            this.InterarrivalTable.Rows.Clear();
            this.serverDataTable.Rows.Clear();
            this.SimulationTable.Rows.Clear();
            this.chooseServerComboBox.Items.Clear();
            this.chooseServerComboBox.Text = "";
            this.chooseServerComboBox2.Text = "";
            this.chooseServerComboBox2.Items.Clear();
            this.AverageWaitingTimeText.Text = "";
            this.MaxQueueLengthText.Text = "";
            this.WaitingProbabilityText.Text = "";
            this.IdleProbabilityText.Text = "";
            this.AverageServiceTimeText.Text = "";
            this.UtilizationText.Text = "";
            this.serverPerformanceChart.Series["Series1"].Points.Clear();
        }
        private void fillInputData()
        {
            numberOfServersText.Text = system.NumberOfServers.ToString();
            numberOfCustomersText.Text = system.SimulationTable.Count.ToString();
            stoppingCriteriaText.Text = system.StoppingCriteria.ToString();
            selectionMethodText.Text = system.SelectionMethod.ToString();
        }
        private void fillSimulationTable()
        {
            foreach (SimulationCase simulationCase in system.SimulationTable)
            {
                DataGridViewRow row = (DataGridViewRow)SimulationTable.Rows[0].Clone();
                row.Cells[0].Value = simulationCase.CustomerNumber;
                row.Cells[1].Value = simulationCase.RandomInterArrival;
                row.Cells[2].Value = simulationCase.InterArrival;
                row.Cells[3].Value = simulationCase.ArrivalTime;
                row.Cells[4].Value = simulationCase.RandomService;
                row.Cells[5].Value = simulationCase.ServiceTime;
                row.Cells[6].Value = simulationCase.AssignedServer.ID;
                row.Cells[7].Value = simulationCase.StartTime;
                row.Cells[8].Value = simulationCase.EndTime;
                row.Cells[9].Value = simulationCase.TimeInQueue;

                SimulationTable.Rows.Add(row);
            }
        }
        private void fillPerformanceMeasures()
        {
            AverageWaitingTimeText.Text = system.PerformanceMeasures.AverageWaitingTime.ToString();
            MaxQueueLengthText.Text = system.PerformanceMeasures.MaxQueueLength.ToString();
            WaitingProbabilityText.Text = system.PerformanceMeasures.WaitingProbability.ToString();
        }
        private void fillInterArrivalTable()
        {  
            foreach (TimeDistribution timeDistribution in system.InterarrivalDistribution)
            {
                DataGridViewRow row = (DataGridViewRow)InterarrivalTable.Rows[0].Clone();
                row.Cells[0].Value = timeDistribution.Time;
                row.Cells[1].Value = timeDistribution.Probability;
                row.Cells[2].Value = timeDistribution.CummProbability;
                row.Cells[3].Value = timeDistribution.MinRange;
                row.Cells[4].Value = timeDistribution.MaxRange;
                InterarrivalTable.Rows.Add(row);
            }
        }
        private void fillServerInfo()
        {
            foreach (Server server in system.Servers)
            {
                chooseServerComboBox.Items.Add("Server " + server.ID);
                chooseServerComboBox2.Items.Add("Server " + server.ID);
            }
        }
        private void plotGraph(int serverID)
        {
            this.serverPerformanceChart.Series["Series1"].Points.Clear();
            this.serverPerformanceChart.Series["Series1"].Points.AddXY(0, 0);
            this.serverPerformanceChart.ChartAreas[0].AxisX.Minimum = 0;
            this.serverPerformanceChart.ChartAreas[0].AxisX.Maximum = this.system.totalSimulationTime;
            
            if (this.system.totalSimulationTime >= 100)
                this.serverPerformanceChart.ChartAreas[0].AxisX.Interval = (int)this.system.totalSimulationTime / 10;
            else
                this.serverPerformanceChart.ChartAreas[0].AxisX.Interval = 1;

            foreach (SimulationCase simCase in this.system.SimulationTable)
            {
                if(simCase.AssignedServer.ID == serverID)
                {
                    for (int i = simCase.StartTime; i <= simCase.EndTime; i++)
                    {
                        this.serverPerformanceChart.Series["Series1"].Points.AddXY(i, 1);
                    }
                }
            }
        }
        private void chooseServerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serverDataTable.Rows.Clear();
            List<TimeDistribution> t = system.Servers.ElementAt(Int32.Parse(chooseServerComboBox.SelectedItem.ToString().Split(' ')[1])-1).TimeDistribution;
            foreach (TimeDistribution timeDistribution in t)
            {
                DataGridViewRow row = (DataGridViewRow)serverDataTable.Rows[0].Clone();
                row.Cells[0].Value = timeDistribution.Time;
                row.Cells[1].Value = timeDistribution.Probability;
                row.Cells[2].Value = timeDistribution.CummProbability;
                row.Cells[3].Value = timeDistribution.MinRange;
                row.Cells[4].Value = timeDistribution.MaxRange;
                serverDataTable.Rows.Add(row);
            }
        }
        private void chooseServerComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Server server = system.Servers.ElementAt(Int32.Parse(chooseServerComboBox2.SelectedItem.ToString().Split(' ')[1]) - 1);
            IdleProbabilityText.Text = server.IdleProbability.ToString();
            AverageServiceTimeText.Text = server.AverageServiceTime.ToString();
            UtilizationText.Text = server.Utilization.ToString();
            plotGraph(server.ID);
        }
    }
}