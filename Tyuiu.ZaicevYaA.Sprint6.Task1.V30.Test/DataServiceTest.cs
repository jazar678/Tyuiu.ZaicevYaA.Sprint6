using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYaA.Sprint6.Task1.V30.Lib;

namespace Tyuiu.ZaicevYaA.Sprint6.Task1.V30.Test
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

            double[] wait = {
                4.96, 4.88, 5.14, 6.91, 10.84, 0, -7.16, -7.09, -6.14, -4.88, -3.96
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}