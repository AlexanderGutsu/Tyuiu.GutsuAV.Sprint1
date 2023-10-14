using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.GutsuAV.Sprint1.Task2.V18.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.
//Расчёты: Известны длины стороны параллелепипеда. Вычислить площадь боковой поверхности параллелепипеда.
//Длина параллелепипеда (целое число), Ширина параллелепипеда (целое число), Высота параллелепипеда (целое число)
//Площадь боковой поверхности параллелепипеда (целое число)

namespace Tyuiu.GutsuAV.Sprint1.Task2.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Гуцу А. В. | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навки работы в C#                                         *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Гуцу Александр ВЛадимирович | ИИПБ-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите длину параллелепипеда:");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ширину параллелепипеда:");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту параллелепипеда:");
            int height = int.Parse(Console.ReadLine());

            DataService perallelepiped = new DataService();

            int parallelepiiped = ds.CalculateSideSquareParallelepiped(length, width, height);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Площадь боковой поверхности параллелепипеда: " + parallelepiiped);

            Console.ReadLine();
        }
    }
}
