using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MedvedevKA.Sprint1.Task7.V12.Lib;

//Написать программу, которая вычисляет математическое выражение
//по исходным значениям данных, вводимых пользователем. 
//          x
//   ( x+1 )       2
//z= (-----) + 18xy
//   ( x-1 )

namespace Tyuiu.MedvedevKA.Sprint1.Task7.V12
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
            Console.WriteLine("* Тема:Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Медведев Кирилл Андриянович | ACOиУБ-23-3                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*          x                                                              *");
            Console.WriteLine("*   ( x+1 )       2                                                       *");
            Console.WriteLine("*z= (-----) + 18xy                                                        *");
            Console.WriteLine("*   ( x-1 )                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение X:                                                        ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:                                                        ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
