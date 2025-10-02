using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYaA.Sprint6.Task5.V19.Lib;
using System.IO;
using System.Linq;

namespace Tyuiu.ZaicevYaA.Sprint6.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask5V19.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { -17, 0, 12, -14.32, 5, -7.84, 12.89, -1.57, -3.64, -13.26, -8.91, -17.77, 35, -9, 13.83, 12.76, 8.86, 0, -1.49, -7 };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetOnlyIntegerNumbers()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask5V19.txt";

            double[] allNumbers = ds.LoadFromDataFile(path);
            double[] integerNumbers = allNumbers.Where(x => IsInteger(x)).ToArray();
            double[] expectedIntegers = { -17, 0, 12, 5, 35, -9, 0, -7 };

            CollectionAssert.AreEqual(expectedIntegers, integerNumbers);
        }

        private bool IsInteger(double number)
        {
            return Math.Abs(number % 1) <= 0.0001;
        }
    }
}