using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Важно! Следует к библиотеке классов подключить файл tyuiu.cources.programming.interfaces.dll
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MedvedevKA.Sprint1.Task0.V14.Lib
{
    public class DataService : ISprint1Task0V14
    {
        public double Calculate()
        {
            return 2 * 3 * 3 + 7;
        }
    }
}
