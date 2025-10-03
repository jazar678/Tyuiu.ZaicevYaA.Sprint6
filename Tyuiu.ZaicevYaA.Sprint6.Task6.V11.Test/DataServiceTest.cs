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
            string path = @"C:\test\InPutFileTask6V11.txt";
            DataService ds = new DataService();
            string result = ds.CollectTextFromFile("", path);
            string expected = "предпоследнее слово";
            Assert.AreEqual(expected, result);
        }
    }
}