using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYaA.Sprint6.Task2.V15.Lib;

namespace Tyuiu.ZaicevYaA.Sprint6.Task2.V15.Test
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
            double[] wait = { -66.03, -52.37, -40.25, -29.44, -19.76, -11.06, -3.22, 3.84, 10.18, 15.84, 20.86 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}