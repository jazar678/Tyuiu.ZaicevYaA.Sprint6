using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ZaicevYaA.Sprint6.Task6.V11.Lib;

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
            string result = ds.CollectTextFromFile("", path);
            string waitResult = "предпоследнее слово";
            Assert.AreEqual(waitResult, result);
        }
    }
}