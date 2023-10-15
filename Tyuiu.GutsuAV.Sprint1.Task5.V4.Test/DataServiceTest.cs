using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GutsuAV.Sprint1.Task5.V4.Lib;
 
namespace Tyuiu.GutsuAV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int seconds = Convert.ToInt32(Console.ReadLine());
            int hours = ds.SecondsToHours(seconds);

        }
    }
}
