using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GutsuAV.Sprint1.Task4.V9.Lib;

namespace Tyuiu.GutsuAV.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();

            double expected = -3.29480340902166;
            double actual = ds.Calculate(3, 4);

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
