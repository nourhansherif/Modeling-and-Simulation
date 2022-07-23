using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        private void calculateCummulativeProbabilityOfDayType(List<DayTypeDistribution> listToCalculate)
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

        private void calculateCummulativeProbabilityOfDemand(List<DemandDistribution> CummlistToCalculateOfDemand)
        {
            for (int i = 0; i < CummlistToCalculateOfDemand.Count; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0)
                        CummlistToCalculateOfDemand.ElementAt(i).DayTypeDistributions.ElementAt(j).CummProbability
                            = CummlistToCalculateOfDemand.ElementAt(i).DayTypeDistributions.ElementAt(j).Probability;
                    else
                        CummlistToCalculateOfDemand.ElementAt(i).DayTypeDistributions.ElementAt(j).CummProbability
                            = CummlistToCalculateOfDemand.ElementAt(i).DayTypeDistributions.ElementAt(j).Probability
                            + CummlistToCalculateOfDemand.ElementAt(i - 1).DayTypeDistributions.ElementAt(j).CummProbability;

                }
        }


        private void calculateRangeDayType(List<DayTypeDistribution> DayTypelistToCalculate)
        {
            for (int i = 0; i < DayTypelistToCalculate.Count; i++)
                if (i == 0)
                {
                    DayTypelistToCalculate.ElementAt(i).MinRange = 1;
                    DayTypelistToCalculate.ElementAt(i).MaxRange = (int)(DayTypelistToCalculate.ElementAt(i).CummProbability * 100);
                }
                else
                {
                    DayTypelistToCalculate.ElementAt(i).MinRange = (int)(DayTypelistToCalculate.ElementAt(i - 1).MaxRange + 1);
                    DayTypelistToCalculate.ElementAt(i).MaxRange = (int)(DayTypelistToCalculate.ElementAt(i).CummProbability * 100);
                }
        }

        private void calculateDemandRange(List<DemandDistribution> DemandRangelistToCalculate)
        {

            for (int i = 0; i < DemandRangelistToCalculate.Count; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0)
                    {
                        DemandRangelistToCalculate.ElementAt(i).DayTypeDistributions.ElementAt(j).MinRange = 1;
                        DemandRangelistToCalculate.ElementAt(i).DayTypeDistributions.ElementAt(j).MaxRange = (int)(DemandRangelistToCalculate.ElementAt(i).DayTypeDistributions.ElementAt(j).CummProbability * 100);
                    }

                    else
                    {
                        DemandRangelistToCalculate.ElementAt(i).DayTypeDistributions.ElementAt(j).MinRange = (int)DemandRangelistToCalculate.ElementAt(i - 1).DayTypeDistributions.ElementAt(j).MaxRange + 1;
                        DemandRangelistToCalculate.ElementAt(i).DayTypeDistributions.ElementAt(j).MaxRange = (int)(DemandRangelistToCalculate.ElementAt(i).DayTypeDistributions.ElementAt(j).CummProbability * 100);
                    }
                }
        }

        public int getRangeDaytype(List<DayTypeDistribution> listToGetRangeDayType, int randomDayType)
        {
            foreach (DayTypeDistribution D in listToGetRangeDayType)
                if (randomDayType >= D.MinRange && randomDayType <= D.MaxRange)
                    return (int)D.DayType;
            
            return -1;
        }

        public int getRangeDemand(List<DemandDistribution> listToGetRangeDemand, int randomDemand, int NewsDayType)
        {
            foreach (DemandDistribution d in listToGetRangeDemand)
                if (randomDemand >= d.DayTypeDistributions.ElementAt(NewsDayType).MinRange && randomDemand <= d.DayTypeDistributions.ElementAt(NewsDayType).MaxRange)
                    return d.Demand;
            return -1;
        }

        private void calculateProfit(SimulationCase simulationCase)
        {
            simulationCase.DailyCost = NumOfNewspapers * PurchasePrice;
            PerformanceMeasures.TotalCost += simulationCase.DailyCost;

            if (simulationCase.Demand == NumOfNewspapers)
            {
                simulationCase.SalesProfit = NumOfNewspapers * SellingPrice;
                PerformanceMeasures.TotalSalesProfit += simulationCase.SalesProfit;
                simulationCase.ScrapProfit = 0;
                simulationCase.LostProfit = 0;
            }

            else if (simulationCase.Demand > NumOfNewspapers)
            {
                simulationCase.SalesProfit = NumOfNewspapers * SellingPrice;
                PerformanceMeasures.TotalSalesProfit += simulationCase.SalesProfit;
                simulationCase.LostProfit = (simulationCase.Demand - NumOfNewspapers) * (SellingPrice - PurchasePrice);
                simulationCase.ScrapProfit = 0;
                PerformanceMeasures.DaysWithMoreDemand += 1;
            }

            else
            {
                simulationCase.SalesProfit = simulationCase.Demand * SellingPrice;
                PerformanceMeasures.TotalSalesProfit += simulationCase.SalesProfit;
                simulationCase.ScrapProfit = (NumOfNewspapers - simulationCase.Demand) * ScrapPrice;
                simulationCase.LostProfit = 0;
                PerformanceMeasures.DaysWithUnsoldPapers += 1;

            }



            PerformanceMeasures.TotalLostProfit += simulationCase.LostProfit;
            PerformanceMeasures.TotalScrapProfit += simulationCase.ScrapProfit;

            simulationCase.DailyNetProfit = simulationCase.SalesProfit - simulationCase.DailyCost - simulationCase.LostProfit + simulationCase.ScrapProfit;

        }

        public void createTable()
        {

            this.calculateCummulativeProbabilityOfDayType(this.DayTypeDistributions);
            this.calculateRangeDayType(this.DayTypeDistributions);
            this.calculateCummulativeProbabilityOfDemand(this.DemandDistributions);
            this.calculateDemandRange(this.DemandDistributions);

            Random rd = new Random();

            while (true)
            {

                SimulationCase simulationCase = new SimulationCase();
                simulationCase.DayNo = this.SimulationTable.Count + 1;

                simulationCase.RandomNewsDayType = rd.Next(1, 101);

                simulationCase.NewsDayType = (Enums.DayType)this.getRangeDaytype(this.DayTypeDistributions, simulationCase.RandomNewsDayType);

                simulationCase.RandomDemand = rd.Next(1, 101);
                simulationCase.Demand = this.getRangeDemand(this.DemandDistributions, simulationCase.RandomDemand, (int)simulationCase.NewsDayType);

                calculateProfit(simulationCase);
                PerformanceMeasures.TotalNetProfit += simulationCase.DailyNetProfit;

                this.SimulationTable.Add(simulationCase);

                if (SimulationTable.Count == NumOfRecords)
                {
                    break;
                }
            }

        }

    }
}

