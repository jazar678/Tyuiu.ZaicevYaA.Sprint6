using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYA.Sprint6.Task0.V6.Lib;

namespace Tyuiu.ZaicevYA.Sprint6.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 3;
            double wait = 0.866;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}