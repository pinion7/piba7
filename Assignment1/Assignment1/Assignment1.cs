using System.IO;
using System.Collections.Generic;
using System;

namespace Assignment1
{
    public static class Assignment1
    {
        public static string ConvertToOct(string dec)
        {
            string result = "";
            long newDec = long.Parse(dec);

            while (true)
            {
                if (newDec / 8 != 0)
                {
                    result = newDec % 8 + result;
                    newDec = newDec / 8;
                }
                else if (newDec / 8 == 0)
                {
                    result = newDec % 8 + result;
                    break;
                }
            }

            return result;

            // 10진수 -> 8진수 변환 함수
            // 8로 나누었을 때 몫이 0이 아니면 나머지를 합산한다
            // 몫을 다시 8로 나누는 것을 반복하며 0이 아닐때마다 계속 나머지를 합산한다(다만 앞에서 부터 붙인다)
            // 8로 나누었을 때 몫이 0이면, 마지막으로 나머지를 합산하고 반복문을 끝낸다
        }                   

        public static void PrintIntegers(StreamReader input, StreamWriter output, int width)
        {
            string[] dec = new string[5];
            string[] oct = new string[5];
            string[] hex = new string[5];
            
            for (int i = 0; i < 5; ++i)
            {
                dec[i] = input.ReadLine().Trim();
                oct[i] = ConvertToOct(dec[i]);
                hex[i] = string.Format("{0:X}", long.Parse(dec[i]));
            }

            if (width <= 10)
            {
                output.WriteLine($"{"oct",10}{"dec",11}{"hex",11}");

                for (int i = 0; i < 5; ++i)
                {
                    output.WriteLine($"{oct[i],10}{dec[i],11}{hex[i],11}");
                }
            }
            else
            {
                output.Write("oct".PadLeft(width));
                output.Write("dec".PadLeft(width + 1));
                output.WriteLine("hex".PadLeft(width + 1));

                for (int i = 0; i < 5; ++i)
                {
                    output.Write(oct[i].PadLeft(width));
                    output.Write(dec[i].PadLeft(width + 1));
                    output.WriteLine(hex[i].PadLeft(width + 1));
                }
            }
            
        }


        public static double GetSum(string num1, string num2, string num3, string num4, string num5)
        {
            double sum = double.Parse(num1) + double.Parse(num2) + double.Parse(num3) + double.Parse(num4) + double.Parse(num5);
            return sum;


            // 다섯 숫자 합계 구하는 함수
        }

        public static double GetMax(string num1, string num2, string num3, string num4, string num5)
        {
            double max1 = Math.Max(double.Parse(num1), double.Parse(num2));
            double max2 = Math.Max(double.Parse(num3), double.Parse(num4));
            double max3 = double.Parse(num5);

            if (max1 > max2 && max1 > max3)
            {
                return max1;
            }
            else if (max2 > max3)
            {
                return max2;
            }
            return max3;

            // 다섯 숫자 중 최대값 구하는 함수
        }

        public static double GetMin(string num1, string num2, string num3, string num4, string num5)
        {
            double min1 = Math.Min(double.Parse(num1), double.Parse(num2));
            double min2 = Math.Min(double.Parse(num3), double.Parse(num4));
            double min3 = double.Parse(num5);

            if (min1 < min2 && min1 < min3)
            {
                return min1;
            }
            else if (min2 < min3)
            {
                return min2;
            }
            return min3;

            // 다섯 숫자 중 최소값 구하는 함수
        }

        public static void PrintStats(StreamReader input, StreamWriter output)
        {
            const int NEW_WIDTH = 25;

            string[] floatPoint = new string[5];

            for (int i = 0; i < 5; ++i)
            {
                floatPoint[i] = input.ReadLine();
            }

            double maxResult = GetMax(floatPoint[0], floatPoint[1], floatPoint[2], floatPoint[3], floatPoint[4]);
            double minResult = GetMin(floatPoint[0], floatPoint[1], floatPoint[2], floatPoint[3], floatPoint[4]);
            double sumResult = GetSum(floatPoint[0], floatPoint[1], floatPoint[2], floatPoint[3], floatPoint[4]);
            double averageResult = sumResult / 5;


            for (int i = 0; i < 5; ++i)
            {
                output.WriteLine($"{string.Format("{0:f3}", double.Parse(floatPoint[i])),NEW_WIDTH}");
            }

            output.WriteLine($"{"Min",-3}{string.Format("{0:f3}", minResult),NEW_WIDTH - 3}");
            output.WriteLine($"{"Max",-3}{string.Format("{0:f3}", maxResult),NEW_WIDTH - 3}");        
            output.WriteLine($"{"Sum",-3}{string.Format("{0:f3}", sumResult),NEW_WIDTH - 3}");
            output.WriteLine($"{"Average",-7}{string.Format("{0:f3}", averageResult),NEW_WIDTH - 7}");                 
        }
    }
}
