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

            // Создаем тестовый файл с данными
            string[] testData = { "-17.0", "0.0", "12.0", "5.0", "35.0", "-9.0", "0.0", "-7.0" };
            File.WriteAllLines(path, testData);

            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { -17, 0, 12, 5, 35, -9, 0, -7 };
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