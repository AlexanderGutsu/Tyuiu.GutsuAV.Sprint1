using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GutsuAV.Sprint1.Task6.V17.Lib;

namespace Tyuiu.GutsuAV.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string input = Console.ReadLine();

            bool checkPalindrome = ds.CheckPalindrome(input);


        }
    }
}
