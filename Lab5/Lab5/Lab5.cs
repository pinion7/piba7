using System;

namespace Lab5
{
    public static class Lab5
    {
        public static bool TryFixData(uint[] usersPerDay, double[] revenuePerDay)
        {
            int count = 0;
            for (int i = 0; i < usersPerDay.Length; ++i)
            {
                if (usersPerDay[i] <= 10 && usersPerDay[i] >= 0)
                {
                    if ((double)usersPerDay[i] / 2 != revenuePerDay[i])
                    {
                        revenuePerDay[i] = Math.Round((double)usersPerDay[i] / 2, 2);
                    }
                    else
                    {
                        count++;
                    }
                }
                else if (usersPerDay[i] <= 100 && usersPerDay[i] > 10)
                {
                    if ((16 * (double)usersPerDay[i] / 5 - 27) != revenuePerDay[i])
                    {
                        revenuePerDay[i] = Math.Round(16 * (double)usersPerDay[i] / 5 - 27, 2);
                    }
                    else
                    {
                        count++;
                    }
                }
                else if (usersPerDay[i] <= 1000 && usersPerDay[i] > 100)
                {
                    if ((double)(usersPerDay[i] * usersPerDay[i]) / 4 - 2 * (double)usersPerDay[i] - 2007 != revenuePerDay[i])
                    {
                        revenuePerDay[i] = Math.Round((double)(usersPerDay[i] * usersPerDay[i]) / 4 - 2 * (double)usersPerDay[i] - 2007, 2);
                    }
                    else
                    {
                        count++;
                    }

                }
                else if (usersPerDay[i] > 1000)
                {
                    if ((245743 + (double)usersPerDay[i] / 4) != revenuePerDay[i])
                    {
                        revenuePerDay[i] = Math.Round(245743 + (double)usersPerDay[i] / 4, 2);
                    }
                    else
                    {
                        count++;
                    }
                }               
            }
            if (usersPerDay.Length != revenuePerDay.Length || count == usersPerDay.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int GetInvalidEntryCount(uint[] usersPerDay, double[] revenuePerDay)
        {
            if (usersPerDay.Length != revenuePerDay.Length)
            {
                return -1;
            }

            int count = 0;
            for (int i = 0; i < usersPerDay.Length; ++i)
            {
                if (usersPerDay[i] <= 10 && usersPerDay[i] >= 0)
                {
                    if ((double)usersPerDay[i] / 2 != revenuePerDay[i])
                    {
                        count++;
                    }
                }
                else if (usersPerDay[i] <= 100 && usersPerDay[i] > 10)
                {
                    if (16 * (double)usersPerDay[i] / 5 - 27 != revenuePerDay[i])
                    {
                        count++;
                    }
                }
                else if (usersPerDay[i] <= 1000 && usersPerDay[i] > 100)
                {
                    if ((double)(usersPerDay[i] * usersPerDay[i]) / 4 - 2 * usersPerDay[i] - 2007 != revenuePerDay[i])
                    {
                        count++;
                    }
                }
                else if (usersPerDay[i] > 1000)
                {
                    if (245743 + (double)usersPerDay[i] / 4 != revenuePerDay[i])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static double CalculateTotalRevenue(double[] revenuePerDay, uint start, uint end)
        {
            if (revenuePerDay.Length == 0)
            {
                return -1;
            }

            double totalRevenue = 0;
            for (uint i = start; i <= end; ++i)
            {
                totalRevenue += revenuePerDay[i];
            }
            return totalRevenue;
        }
    }
}
