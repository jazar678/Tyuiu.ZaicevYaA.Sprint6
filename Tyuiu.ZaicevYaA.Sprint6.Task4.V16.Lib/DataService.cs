using System;
using Tyuiu.ZaicevYA.Sprint6.Task4.V16.Lib;

namespace Tyuiu.ZaicevYA.Sprint6.Task4.V16.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = x - 0.4;

                // Проверка деления на ноль
                if (Math.Abs(denominator) < 0.0001) // Учитываем погрешность вычислений
                {
                    valueArray[count] = 0;
                }
                else
                {
                    valueArray[count] = Math.Round(Math.Cos(x) / denominator + Math.Sin(x) * 8 * x + 2, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}
