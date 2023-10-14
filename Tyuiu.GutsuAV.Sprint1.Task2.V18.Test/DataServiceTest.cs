using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.GutsuAV.Sprint1.Task2.V18.Lib;

namespace Tyuiu.GutsuAV.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int length = 5;
            int width = 3;
            int height = 4;
            var res = 2 * (length * height + width * height);
            int parallelepiiped = ds.CalculateSideSquareParallelepiped(length, width, height);
            Assert.AreEqual(parallelepiiped, res);
        }
    }
}
