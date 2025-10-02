using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 5, 4, 3, 2, 1, 0, -1, -2, -3, -4, -5 };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void FileExistsTest()
        {
            string path = @"C:\DataSprint6\InPutFileTask5V19.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);
        }
    }
}