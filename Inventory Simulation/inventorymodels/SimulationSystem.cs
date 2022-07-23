using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DemandDistribution = new List<Distribution>();
            LeadDaysDistribution = new List<Distribution>();
            SimulationCases = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }

        ///////////// INPUTS /////////////

        public int OrderUpTo { get; set; }
        public int ReviewPeriod { get; set; }
        public int NumberOfDays { get; set; }
        public int StartInventoryQuantity { get; set; }
        public int StartLeadDays { get; set; }
        public int StartOrderQuantity { get; set; }
        public List<Distribution> DemandDistribution { get; set; }
        public List<Distribution> LeadDaysDistribution { get; set; }

        ///////////// OUTPUTS /////////////

        public List<SimulationCase> SimulationCases { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }


        private void calculateCummulativeProbability(List<Distribution> listToCalculate)
        {
            for (int i = 0; i < listToCalculate.Count; i++)
                if (i == 0)
                    listToCalculate.ElementAt(i).CummProbability
                        = listToCalculate.ElementAt(i).Probability;
                else
                    listToCalculate.ElementAt(i).CummProbability
                        = listToCalculate.ElementAt(i).Probability
                        + listToCalculate.ElementAt(i - 1).CummProbability;

        }

        private void calculateRange(List<Distribution> listToCalculate)
        {
            for (int i = 0; i < listToCalculate.Count; i++)
                if (i == 0)
                {
                    listToCalculate.ElementAt(i).MinRange = 1;
                    listToCalculate.ElementAt(i).MaxRange = (int)(listToCalculate.ElementAt(i).CummProbability * 100);
                }
                else
                {
                    listToCalculate.ElementAt(i).MinRange = (int)listToCalculate.ElementAt(i - 1).MaxRange + 1;
                    listToCalculate.ElementAt(i).MaxRange = (int)(listToCalculate.ElementAt(i).CummProbability * 100);
                }

        }
        

        public int getRange(List<Distribution> listToGetRange, int randomTime)
        {
            foreach (Distribution distribution in listToGetRange)
                if (randomTime >= distribution.MinRange && randomTime <= distribution.MaxRange)
                    return distribution.Value;

            return -1;
        }

        public void completeInputTables()
        {
            this.calculateCummulativeProbability(this.DemandDistribution);
            this.calculateRange(this.DemandDistribution);
            this.calculateCummulativeProbability(this.LeadDaysDistribution);
            this.calculateRange(this.LeadDaysDistribution);
        }

        public void calculatePerformanceMeasures()
        {
            this.PerformanceMeasures.EndingInventoryAverage /= this.NumberOfDays;
            this.PerformanceMeasures.ShortageQuantityAverage /= this.NumberOfDays;

        }
        public void runSimulation()
        {
            Random random = new Random();
            int cyclesCounter = 1;
            int withinCycle = 1;
            int orderToBeRecieved = this.StartOrderQuantity;
            int orderArrivalDay = this.StartLeadDays + 1;
            for (int i = 0; i < this.NumberOfDays; i++)
            {
                SimulationCase simulationCase = new SimulationCase();
                simulationCase.Day = i + 1;
                simulationCase.Cycle = cyclesCounter;
                simulationCase.DayWithinCycle = withinCycle;
                withinCycle++;

                if (i == 0)
                {
                    simulationCase.BeginningInventory = this.StartInventoryQuantity;
                    ////////
                    simulationCase.DaysUntilOrderArrives = this.StartLeadDays <= 1 ? 0 : this.StartLeadDays - 1;
                }
                ///////
                else
                {
                    simulationCase.BeginningInventory = this.SimulationCases.ElementAt(i - 1).EndingInventory;

                    simulationCase.DaysUntilOrderArrives = this.SimulationCases.ElementAt(i - 1).DaysUntilOrderArrives == 0 ?
                            0 : this.SimulationCases.ElementAt(i - 1).DaysUntilOrderArrives - 1;
                }


                simulationCase.RandomDemand = random.Next(1, 101);
                simulationCase.Demand = getRange(this.DemandDistribution, simulationCase.RandomDemand);



                if (simulationCase.Day == orderArrivalDay)
                {
                    simulationCase.BeginningInventory += orderToBeRecieved;
                    if (i - 1 >= 0)
                        simulationCase.EndingInventory = simulationCase.BeginningInventory - simulationCase.Demand
                            - this.SimulationCases.ElementAt(i - 1).ShortageQuantity;
                    else
                        simulationCase.EndingInventory = simulationCase.BeginningInventory - simulationCase.Demand;

                }
                else
                {
                    if (simulationCase.Demand >= simulationCase.BeginningInventory)
                    {
                        simulationCase.EndingInventory = 0;
                        if (i - 1 >= 0)
                            simulationCase.ShortageQuantity = simulationCase.Demand - simulationCase.BeginningInventory
                                + this.SimulationCases.ElementAt(i - 1).ShortageQuantity;
                        else

                            simulationCase.ShortageQuantity = simulationCase.Demand - simulationCase.BeginningInventory;
                    }
                    else
                    {
                        simulationCase.EndingInventory = simulationCase.BeginningInventory - simulationCase.Demand;
                        simulationCase.ShortageQuantity = 0;
                    }
                }

               
                


                if (simulationCase.Day % this.ReviewPeriod == 0)
                {
                    cyclesCounter++;
                    withinCycle = 1;

                    simulationCase.OrderQuantity = this.OrderUpTo - simulationCase.EndingInventory + simulationCase.ShortageQuantity;
                    
                    simulationCase.RandomLeadDays = random.Next(1, 101);
                    simulationCase.LeadDays = getRange(this.LeadDaysDistribution, simulationCase.RandomLeadDays);
                    simulationCase.DaysUntilOrderArrives = simulationCase.LeadDays;
                    orderToBeRecieved = simulationCase.OrderQuantity;
                    orderArrivalDay = simulationCase.LeadDays + 1 + simulationCase.Day;

                }
                else
                {
                    simulationCase.OrderQuantity = 0;
                    simulationCase.RandomLeadDays = 0;
                    simulationCase.LeadDays = 0;

                }
                this.PerformanceMeasures.EndingInventoryAverage += simulationCase.EndingInventory;
                this.PerformanceMeasures.ShortageQuantityAverage += simulationCase.ShortageQuantity;
                SimulationCases.Add(simulationCase);
            }

        }
    }
}
