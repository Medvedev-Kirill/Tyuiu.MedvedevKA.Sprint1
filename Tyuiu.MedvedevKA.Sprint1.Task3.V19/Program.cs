using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MedvedevKA.Sprint1.Task3.V19.Lib;

//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.
//Расчёты:
//Написать программу, которая печатает true или false в зависимости от того,
//может ли шахматная фигура «Слон» с одного заданного поля шахматной доски перейти за один ход на другое.
//Пользователь задаёт координаты двух ячеек шахматной доски (x1 и y1, x2 и y2, каждое в диапазоне от 1 до 8).

namespace Tyuiu.MedvedevKA.Sprint1.Task3.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Медведев К. А. | ACОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема:Операторы составного присваивания                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Введите y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Введите x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Введите y2: ");
            double y2 = double.Parse(Console.ReadLine());

            ds.ElephCanMove(x1, x2, y1, y2);
            
            if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.ReadLine();
        }
    }
}
