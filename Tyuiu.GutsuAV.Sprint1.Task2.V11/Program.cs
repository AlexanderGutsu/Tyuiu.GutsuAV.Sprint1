using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GutsuAV.Sprint1.Task2.V11.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.
//Расчеты: Напишите программу, которая вычисляет площадь треугольника, если известны координаты его углов. Ответ округлите до 3 знаков после запятой.
//Введите координаты углов (числа разделяйте пробелом):
//x1-> - 2
//y1-> 5
//х2-> 1
//у2-> 7
//хЗ-> 5
//уЗ-> - 3
//Площадь треугольника: 19 кв.см

namespace Tyuiu.GutsuAV.Sprint1.Task2.V11
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
            Console.WriteLine("* Задание #3                                                              *");
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
            Console.WriteLine("Введите координаты углов треугольника (числа разделяйте пробелом):         ");
            Console.Write("x1 -> ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("y1 -> ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("x2 -> ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("y2 -> ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("x3 -> ");
            double x3 = double.Parse(Console.ReadLine());

            Console.Write("y3 -> ");
            double y3 = double.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double area = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2);

            Console.WriteLine($"Площадь треугольника: {area} кв. единицы");
            Console.ReadLine();


            

        }
    }
}
