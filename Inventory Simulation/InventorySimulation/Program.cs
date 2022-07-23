using InventoryModels;
using InventoryTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySimulation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InventoryForm());
        }
        static public SimulationSystem runSimulation(string filePath)
        {
            SimulationSystem system = new SimulationSystem();

            readTestCaseFile(filePath, system);
            
            system.completeInputTables();

            system.runSimulation();

            system.calculatePerformanceMeasures();


            String[] filePathSplitted = filePath.Split('\\');
            String fileName = filePathSplitted[filePathSplitted.Length - 1];
            string result = TestingManager.Test(system, fileName);

            MessageBox.Show(result);

            return system;
        }

        static private void readTestCaseFile(string path, SimulationSystem system)
        {
            string text = File.ReadAllText(path);
            String[] lines = text.Split(new String[] { "\r\n" }, StringSplitOptions.None);
            for (int lineNumber = 0; lineNumber < lines.Length; lineNumber++)
            {
                if (lines[lineNumber].Equals(""))
                    continue;

                if (lines[lineNumber].Equals("OrderUpTo"))
                {
                    system.OrderUpTo = Int32.Parse(lines[lineNumber + 1]);
                    lineNumber++;
                }

                else if (lines[lineNumber].Equals("ReviewPeriod"))
                {
                    system.ReviewPeriod = Int32.Parse(lines[lineNumber + 1]);
                    lineNumber++;
                }
                else if (lines[lineNumber].Equals("StartInventoryQuantity"))
                {
                    system.StartInventoryQuantity = Int32.Parse(lines[lineNumber + 1]);
                    lineNumber++;
                }

                else if (lines[lineNumber].Equals("StartLeadDays"))
                {
                    system.StartLeadDays = Int32.Parse(lines[lineNumber + 1]);
                    lineNumber++;
                }

                else if (lines[lineNumber].Equals("StartOrderQuantity"))
                {
                    system.StartOrderQuantity = Int32.Parse(lines[lineNumber + 1]);
                    lineNumber++;
                }

                else if (lines[lineNumber].Equals("NumberOfDays"))
                {
                    system.NumberOfDays = Int32.Parse(lines[lineNumber + 1]);
                    lineNumber++;
                }
                else if (lines[lineNumber].StartsWith("DemandDistribution"))
                {
                    while ((lineNumber + 1) < lines.Length && lines[lineNumber + 1] != "")
                    {
                        Distribution distribution = new Distribution();
                        string[] line = lines[lineNumber + 1].Split(new String[] { ", " }, StringSplitOptions.None);
                        distribution.Value = Int32.Parse(line[0]);
                        distribution.Probability = Decimal.Parse(line[1]);
                        system.DemandDistribution.Add(distribution);
                        lineNumber++;
                    }
                }
                else if (lines[lineNumber].StartsWith("LeadDaysDistribution"))
                {
                    while ((lineNumber + 1) < lines.Length && lines[lineNumber + 1] != "")
                    {
                        Distribution distribution = new Distribution();
                        string[] line = lines[lineNumber + 1].Split(new String[] { ", " }, StringSplitOptions.None);
                        distribution.Value = Int32.Parse(line[0]);
                        distribution.Probability = Decimal.Parse(line[1]);
                        system.LeadDaysDistribution.Add(distribution);
                        lineNumber++;
                    }
                }
            }
        }
    }
}
