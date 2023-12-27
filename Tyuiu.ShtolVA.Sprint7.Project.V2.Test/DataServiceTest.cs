using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtolVA.Sprint7.Project.V2.Lib;
using System.IO;


namespace Tyuiu.ShtolVA.Sprint7.Project.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\vikto\source\Kompanii.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
