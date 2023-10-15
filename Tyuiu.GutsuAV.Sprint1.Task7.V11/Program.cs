using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GutsuAV.Sprint1.Task7.V11.Lib;

//Написать программу, которая вычисляет математическое выражение по исходным значениям данных, вводимых пользователем. Ответ округлите до 3 знаков после запятой.
//Формула: z = (ln sin x)^x / ln(1+x^2) + (y - √|x|)

namespace Tyuiu.GutsuAV.Sprint1.Task7.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Гуцу А. В. | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил:Гуцу Александр Владимирович | ИИПБ-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение x:");

            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение y:");

            double y = double.Parse(Console.ReadLine());

            double z = (Math.Log(Math.Sin(x)) * x) / Math.Log(1 + Math.Pow(x, 2)) + (y - Math.Sqrt(Math.Abs(x)));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("{0:0.000}", z);

            Console.ReadLine();
        }
    }
}
