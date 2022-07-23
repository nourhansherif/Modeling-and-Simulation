using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerTesting;
using NewspaperSellerModels;
using System.IO;

namespace NewspaperSellerSimulation
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
            Form1 form = new Form1();
            Application.Run(form);
        }

        static public SimulationSystem runSimulation(string filePath)
        {
            SimulationSystem system = new SimulationSystem();

            readTestCaseFile(filePath, system);
            system.createTable();
            
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

                if (lines[lineNumber].Equals("NumOfNewspapers"))
                {
                    system.NumOfNewspapers = Int32.Parse(lines[lineNumber + 1]);
                    lineNumber++;
                }

                else if (lines[lineNumber].Equals("NumOfRecords"))
                {
                    system.NumOfRecords = Int32.Parse(lines[lineNumber + 1]);
                    lineNumber++;
                }
                else if (lines[lineNumber].Equals("PurchasePrice"))
                {
                    system.PurchasePrice = Decimal.Parse(lines[lineNumber + 1]);
                    lineNumber++;
                }
                else if (lines[lineNumber].Equals("ScrapPrice"))
                {
                    system.ScrapPrice = Decimal.Parse(lines[lineNumber + 1]);
                    lineNumber++;
                }
                else if (lines[lineNumber].Equals("SellingPrice"))
                {
                    system.SellingPrice = Decimal.Parse(lines[lineNumber + 1]);
                    lineNumber++;
                }


                else if (lines[lineNumber].Equals("DayTypeDistributions"))
                {

                    string[] line = lines[lineNumber + 1].Split(new String[] { ", " }, StringSplitOptions.None);

                    DayTypeDistribution DT1 = new DayTypeDistribution();
                    DT1.Probability = Decimal.Parse(line[0]);
                    DT1.DayType = Enums.DayType.Good;
                    system.DayTypeDistributions.Add(DT1);

                    DayTypeDistribution DT2 = new DayTypeDistribution();
                    DT2.Probability = Decimal.Parse(line[1]);
                    DT2.DayType = Enums.DayType.Fair;
                    system.DayTypeDistributions.Add(DT2);

                    DayTypeDistribution DT3 = new DayTypeDistribution();
                    DT3.Probability = Decimal.Parse(line[2]);
                    DT3.DayType = Enums.DayType.Poor;
                    system.DayTypeDistributions.Add(DT3);

                    lineNumber++;

                }

                else if (lines[lineNumber].Equals("DemandDistributions"))
                {
                    while ((lineNumber + 1) < lines.Length && lines[lineNumber + 1] != "")
                    {
                        DemandDistribution DemandDistributions = new DemandDistribution();
                        string[] line = lines[lineNumber + 1].Split(new String[] { ", " }, StringSplitOptions.None);
                        DemandDistributions.Demand = Int32.Parse(line[0]);

                        DayTypeDistribution d = new DayTypeDistribution();
                        d.DayType = Enums.DayType.Good;
                        d.Probability = Decimal.Parse(line[1]);
                        DemandDistributions.DayTypeDistributions.Add(d);

                        DayTypeDistribution d1 = new DayTypeDistribution();
                        d1.DayType = Enums.DayType.Fair;
                        d1.Probability = Decimal.Parse(line[2]);
                        DemandDistributions.DayTypeDistributions.Add(d1);

                        DayTypeDistribution d2 = new DayTypeDistribution();
                        d2.DayType = Enums.DayType.Poor;
                        d2.Probability = Decimal.Parse(line[3]);
                        DemandDistributions.DayTypeDistributions.Add(d2);

                        system.DemandDistributions.Add(DemandDistributions);

                        lineNumber++;

                    }
                }
            }


        }
    }
}
