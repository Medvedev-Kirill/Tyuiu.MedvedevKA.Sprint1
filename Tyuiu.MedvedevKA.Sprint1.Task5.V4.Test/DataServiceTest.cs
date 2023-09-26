using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MedvedevKA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.MedvedevKA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int time = 10800;
            DataService ds = new DataService();
            int hours = ds.SecondsToHours(time);

            int result = Convert.ToInt32(hours);

            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}
