using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZaicevYaA.Sprint6.Task1.V30.Lib
{
    public class DataService : ISprint6Task1V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) - 2 * x;

                if (Math.Abs(denominator) < 0.0001)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    valueArray[count] = Math.Round((2 * x - 3) / denominator + 5 * x - 6, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}