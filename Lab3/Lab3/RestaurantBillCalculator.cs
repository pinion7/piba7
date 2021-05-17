using System.IO;
using System.Collections.Generic;
using System;

namespace Lab3
{
    public static class RestaurantBillCalculator
    {
        public static double CalculateTotalCost(StreamReader input)
        {
            string priceOfFirstFood = input.ReadLine();
            string priceOfSecondFood = input.ReadLine();
            string priceOfThirdFood = input.ReadLine();
            string priceOfFourthFood = input.ReadLine();
            string priceOfFifthFood = input.ReadLine();

            double taxOfFirstFood = double.Parse(priceOfFirstFood) * 0.05;
            double taxOfSecondFood = double.Parse(priceOfFirstFood) * 0.05;
            double taxOfThirdFood = double.Parse(priceOfFirstFood) * 0.05;
            double taxOfFourthFood = double.Parse(priceOfFirstFood) * 0.05;
            double taxOfFifthFood = double.Parse(priceOfFirstFood) * 0.05;

            var mapCost = new Dictionary<string, string>();

            for (int i = 1; i <= 5; i++)
            { 
                mapCost.Add("cost{0}", i.ToString());
                mapCost["cost{0}" + i] = input.ReadLine()
                mapCost[i] = double.Parse();
            }

            for (int i = 1; i <= 5; i++)
            {
                mapCost["cost" + i] * 0.05 
            
            }
            return 0;
        }

        public static double CalculateIndividualCost(StreamReader input, double totalCost)
        {
            return 0;
        }

        public static uint CalculatePayerCount(StreamReader input, double totalCost)
        {
            return 0;
        }
    }
}
