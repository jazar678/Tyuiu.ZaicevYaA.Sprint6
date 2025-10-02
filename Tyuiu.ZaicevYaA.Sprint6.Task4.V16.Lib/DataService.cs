using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.ZaicevYA.Sprint6.Task4.V16.Lib;

namespace Tyuiu.ZaicevYA.Sprint6.Task4.V16.Lib
{
    public class DataService : ISprint6Task4V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x - 0.4 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(Math.Cos(x) / (x - 0.4) + Math.Sin(x) * 8 * x + 2, 2);
                }
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }

        public string SaveToFile(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V16.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            double[] valueArray = GetMassFunction(startValue, stopValue);

            if (fileExists)
            {
                File.Delete(path);
            }

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine("Вариант 16");
                writer.WriteLine("Функция: F(x) = cos(x)/(x - 0.4) + sin(x)*8*x + 2");
                writer.WriteLine($"Диапазон: [{startValue}; {stopValue}]");
                writer.WriteLine("Результаты табулирования:");
                writer.WriteLine("---------------------------");

                for (int i = 0; i < valueArray.Length; i++)
                {
                    writer.WriteLine($"F({startValue + i}) = {valueArray[i]:F2}");
                }

                writer.WriteLine("---------------------------");
            }

            return path;
        }
    }
}