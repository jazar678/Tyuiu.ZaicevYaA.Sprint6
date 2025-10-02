using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYaA.Sprint6.Task5.V19.Lib;
using System.IO;

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
            double[] wait = { 5, 3, 7, 2, 8, 1, 4, 6 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}