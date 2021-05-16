using System.IO;
using System.Collections.Generic;
using System;

namespace Assignment1
{
    public static class Assignment1
    {
        public static string octstring(string dec)
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
            double Max1 = Math.Max(num1, num2);
            double Max2 = Math.Max(num3, num4);
            double Max3 = num5;

            if (Max1 > Max2 && Max1 > Max3)
            {
                return Max1;
            }
            else if (Max2 > Max3)
            {
                return Max2;
            }
            return Max3;

            // 다섯 숫자 중 최대값 구하는 함수
        }

        public static double GetMin(double num1, double num2, double num3, double num4, double num5)
        {
            double Min1 = Math.Min(num1, num2);
            double Min2 = Math.Min(num3, num4);
            double Min3 = num5;

            if (Min1 < Min2 && Min1 < Min3)
            {
                return Min1;
            }
            else if (Min2 < Min3)
            {
                return Min2;
            }
            return Min3;

            // 다섯 숫자 중 최ㅅ값 구하는 함수
        }


        public static void PrintIntegers(StreamReader input, StreamWriter output, int width)
        {
            const string oct = "oct";
            const string dec = "dec";
            const string hex = "hex";
            const int newWidth = 14;
         
            Dictionary<string, string> mapDec = new Dictionary<string, string>();
            var mapOct = new Dictionary<string, string>();
            var mapHex = new Dictionary<string, string>();

            for (int i = 1; i <= 5; i++)
            {
                mapDec.Add(string.Format("dec{0}", i.ToString()), i.ToString());
                mapDec["dec" + i] = input.ReadLine();
                mapDec["dec" + i] = mapDec["dec" + i].Trim();

                mapOct.Add(string.Format("oct{0}", i.ToString()), i.ToString());
                mapOct["oct" + i] = octstring(mapDec["dec" + i]);
                
                mapHex.Add(string.Format("hex{0}", i.ToString()), i.ToString());
                mapHex["hex" + i] = string.Format("{0:X}", int.Parse(mapDec["dec" + i]));
            }

            output.WriteLine($"{oct,newWidth}{dec,newWidth}{hex,newWidth}");

            for (int i = 1; i <= 5; i++)
            {
                output.WriteLine($"{mapOct["oct" + i],newWidth}{mapDec["dec" + i],newWidth}{mapHex["hex" + i],newWidth}");

            }

        }
            
        
        public static void PrintStats(StreamReader input, StreamWriter output)
        {
            const int newWidth = 28;

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
                output.WriteLine($"{mapFpoint["fpoint" + i],newWidth}");
            }

            output.WriteLine($"{"Min",-newWidth / 2}{string.Format("{0:f3}", maxResult),newWidth / 2}");
            output.WriteLine($"{"Max",-newWidth / 2}{string.Format("{0:f3}", minResult),newWidth / 2}");
            output.WriteLine($"{"Sum",-newWidth / 2}{string.Format("{0:f3}", sumResult),newWidth / 2}");
            output.WriteLine($"{"Average",-newWidth / 2}{string.Format("{0:f3}", averageResult),newWidth / 2}");                 
        }
    }
}
