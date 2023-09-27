using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevKA.Sprint1.Task6.V18.Lib;

namespace Tyuiu.MedvedevKA.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string value = "122";
            DataService ds = new DataService();
            bool res = ds.CheckNumber(value);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
