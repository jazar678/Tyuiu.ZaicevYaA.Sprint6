using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaicevYaA.Sprint6.Task2.V15.Lib
{
    public class DataService : ISprint6Task2V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            for (int i = 0; i < len; i++)
            {
                double x = startValue + i;

                if (3 * x + 1.2 == 0)
                {
                    valueArray[i] = 0;
                }
                else
                {
                    double numerator = 2 * Math.Sin(x);
                    double denominator = 3 * x + 1.2;
                    valueArray[i] = Math.Round(numerator / denominator + Math.Cos(x) - 7 * x * 2, 2);
                }
            }

            return valueArray;
        }
    }
}