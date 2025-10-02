using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZaicevYA.Sprint6.Task4.V16.Lib;

namespace Tyuiu.ZaicevYA.Sprint6.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { 41.71, 33.01, 24.96, 17.74, 11.53, 6.5, 2.82, 0.67, 0.0, 1.06, 3.87 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}