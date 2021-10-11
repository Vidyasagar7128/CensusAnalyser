using Microsoft.VisualStudio.TestTools.UnitTesting;
using CensusAnalyser;
using System;

namespace CensusTest
{
    [TestClass]
    public class UnitTest1
    {
        string csvFile = @"C:\Users\vidya\Desktop\DotNet\DummyFiles\census.csv";
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                if (!csvFile.Contains("census.csv"))
                    throw new CustomException("File Not Found");
            }
            catch (Exception e)
            {
                Assert.AreEqual("File Not Found", e.Message);
            }
        }
    }
}
