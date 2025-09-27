using System;
using tyuiu.cources.programming.interfaces.Sprint6;
using Tyuiu.ZaicevYA.Sprint6.Task0.V6.Lib;

namespace Tyuiu.ZaicevYA.Sprint6.Task0.V6.Lib
{
    public class DataService : ISprint6Task0V6
    {
        public double Calculate(int x)
        {
            double denominator = Math.Sqrt(Math.Pow(x, 2) + x);

            if (denominator == 0)
            {
                throw new DivideByZeroException("Знаменатель не может быть равен нулю");
            }

            double result = x / denominator;
            return Math.Round(result, 3);
        }
    }
}