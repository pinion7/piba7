using System.IO;
using System.Collections.Generic;
using System;

namespace Lab3
{
    public static class RestaurantBillCalculator
    {
        public static double CalculateTotalCost(StreamReader input)
        {
            string[] priceOfFood = new string[5];
            string percentOfTip = "";
            double[] taxOfFood = new double[5];
            double[] tipOfFood = new double[5];
            double totalCost = 0;


            for (int i = 0; i < 5; ++i)
            {
                priceOfFood[i] = input.ReadLine();
            }

            for (int i = 0; i < 5; ++i)
            { 
                if (percentOfTip == "")
                {
                    percentOfTip = input.ReadLine();
                }

                taxOfFood[i] = double.Parse(priceOfFood[i]) * 0.05;
                tipOfFood[i] = (double.Parse(priceOfFood[i]) + taxOfFood[i]) * (double.Parse(percentOfTip) / 100);
                totalCost = totalCost + double.Parse(priceOfFood[i]) + taxOfFood[i] + tipOfFood[i];
            }

            totalCost = Math.Round(totalCost, 2);
            return totalCost;
        }

        public static double CalculateIndividualCost(StreamReader input, double totalCost)
        {
            string numberOfPeople = input.ReadLine();
            double individualCost = Math.Round((totalCost / double.Parse(numberOfPeople)), 2);

            return individualCost;
        }

        public static uint CalculatePayerCount(StreamReader input, double totalCost)
        {
            string dutchPayPrice = input.ReadLine();
            uint payerCount = (uint)Math.Ceiling(totalCost / double.Parse(dutchPayPrice));

            return payerCount;
        }
    }
}
