using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ZaicevYaA.Sprint6.Task6.V21.Lib;

namespace Tyuiu.ZaitevYaA.Sprint6.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\TestData\InPutFileTask6V21.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile("g", path);

            string expected = "programming language digital technologies";
            Assert.AreEqual(expected, result);
        }
    }
}