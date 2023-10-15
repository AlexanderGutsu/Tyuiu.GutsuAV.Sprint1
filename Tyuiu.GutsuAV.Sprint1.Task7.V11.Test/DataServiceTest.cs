using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GutsuAV.Sprint1.Task7.V11.Lib;

namespace Tyuiu.GutsuAV.Sprint1.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;

            double y = 3;

            double expected = -0.567;

            double actual = ds.Calculate(x, y);

            Assert.AreEqual(expected, actual, 3);
        }
    }
}
