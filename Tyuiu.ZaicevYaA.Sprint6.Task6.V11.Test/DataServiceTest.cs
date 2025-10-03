using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZaicevYaA.Sprint6.Task6.V11.Lib;
using System.IO;

namespace Tyuiu.ZaicevYaA.Sprint6.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V11.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);
            string waitResult = "предпоследние слова строк";
            Assert.AreEqual(waitResult, result);
        }
    }
}