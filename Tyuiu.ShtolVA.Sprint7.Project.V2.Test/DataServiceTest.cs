using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShtolVA.Sprint7.Project.V2.Lib;

namespace Tyuiu.ShtolVA.Sprint7.Project.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetDataFromFile()
        {
            string path = @"C:\Users\vikto\source\repos\Tyuiu.ShtolVA.Sprint7\Tyuiu.ShtolVA.Sprint7.Project.V2.Test\bin\Debug\InPutFileProjectV2.csv";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
            
        }
    }
}
