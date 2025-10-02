using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            double[] wait = { 42.51, 32.63, 2.8, -20.14, -39.97, 0, 43.97, 22.14, -0.8, -30.63, -40.51 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}