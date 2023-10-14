using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GutsuAV.Sprint1.Task2.V18.Lib
{
    public class DataService : ISprint1Task2V18
    {
        public int CalculateSideSquareParallelepiped(int length, int width, int height)
        {
            return 2 * (length * height + width * height);
        }
    }
}
