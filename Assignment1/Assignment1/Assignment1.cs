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
            int newDec = int.Parse(dec);

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

        public static double GetSum(double num1, double num2, double num3, double num4, double num5)
        {
            double sum = num1 + num2 + num3 + num4 + num5;
            return sum;

            // 다섯 숫자 합계 구하는 함수
        }


        public static double GetMax(double num1, double num2, double num3, double num4, double num5)
        {
            double max1 = Math.Max(num1, num2);
            double max2 = Math.Max(num3, num4);
            double max3 = num5;

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

        public static double GetMin(double num1, double num2, double num3, double num4, double num5)
        {
            double min1 = Math.Min(num1, num2);
            double min2 = Math.Min(num3, num4);
            double min3 = num5;

            if (min1 < min2 && min1 < min3)
            {
                return min1;
            }
            else if (min2 < min3)
            {
                return min2;
            }
            return min3;

            // 다섯 숫자 중 최ㅅ값 구하는 함수
        }


        public static void PrintIntegers(StreamReader input, StreamWriter output, int width)
        {
            const string OCT = "oct";
            const string DEC = "dec";
            const string HEX = "hex";
            const int NEW_WIDTH = 10;
                     
            Dictionary<string, string> mapDec = new Dictionary<string, string>();
            var mapOct = new Dictionary<string, string>();
            var mapHex = new Dictionary<string, string>();

            for (int i = 1; i <= 5; i++)
            {
                mapDec.Add(string.Format("dec{0}", i.ToString()), i.ToString());
                mapDec["dec" + i] = input.ReadLine();
                mapDec["dec" + i] = mapDec["dec" + i].Trim();

                mapOct.Add(string.Format("oct{0}", i.ToString()), i.ToString());
                mapOct["oct" + i] = ConvertToOct(mapDec["dec" + i]);
                
                mapHex.Add(string.Format("hex{0}", i.ToString()), i.ToString());
                mapHex["hex" + i] = string.Format("{0:X}", int.Parse(mapDec["dec" + i]));
            }

            output.WriteLine($"{OCT,NEW_WIDTH}{DEC,NEW_WIDTH + 1}{HEX,NEW_WIDTH + 1}");

            for (int i = 1; i <= 5; i++)
            {
                output.WriteLine($"{mapOct["oct" + i],NEW_WIDTH}{mapDec["dec" + i],NEW_WIDTH + 1}{mapHex["hex" + i],NEW_WIDTH + 1}");

            }

        }
            
        
        public static void PrintStats(StreamReader input, StreamWriter output)
        {
            const int NEW_WIDTH = 25;

            var mapFpoint = new Dictionary<string, string>();

            for (int i = 1; i <= 5; i++)
            {
                mapFpoint.Add(string.Format("fpoint{0}", i.ToString()), i.ToString());
                mapFpoint["fpoint" + i] = input.ReadLine();
            }
            
            double maxResult = GetMax(double.Parse(mapFpoint["fpoint1"]), double.Parse(mapFpoint["fpoint2"]), double.Parse(mapFpoint["fpoint3"]), double.Parse(mapFpoint["fpoint4"]), double.Parse(mapFpoint["fpoint5"]));
            double minResult = GetMin(double.Parse(mapFpoint["fpoint1"]), double.Parse(mapFpoint["fpoint2"]), double.Parse(mapFpoint["fpoint3"]), double.Parse(mapFpoint["fpoint4"]), double.Parse(mapFpoint["fpoint5"]));
            double sumResult = GetSum(double.Parse(mapFpoint["fpoint1"]), double.Parse(mapFpoint["fpoint2"]), double.Parse(mapFpoint["fpoint3"]), double.Parse(mapFpoint["fpoint4"]), double.Parse(mapFpoint["fpoint5"]));
            double averageResult = sumResult / 5;

            for (int i = 1; i <= 5; i++)
            {
                mapFpoint["fpoint" + i] = string.Format("{0:f3}", double.Parse(mapFpoint["fpoint" + i]));
            }


            for (int i = 1; i <= 5; i++)
            {
                output.WriteLine($"{mapFpoint["fpoint" + i],NEW_WIDTH}");
            }

            output.WriteLine($"{"Min",-3}{string.Format("{0:f3}", minResult),NEW_WIDTH - 3}");
            output.WriteLine($"{"Max",-3}{string.Format("{0:f3}", maxResult),NEW_WIDTH - 3}");        
            output.WriteLine($"{"Sum",-3}{string.Format("{0:f3}", sumResult),NEW_WIDTH - 3}");
            output.WriteLine($"{"Average",-7}{string.Format("{0:f3}", averageResult),NEW_WIDTH - 7}");                 
        }
    }
}
