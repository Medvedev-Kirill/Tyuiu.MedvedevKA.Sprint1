using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MedvedevKA.Sprint1.Task2.V4.Lib
{
    public class DataService : ISprint1Task2V4
    {
        public int CalculateSquare(int value)
        {
            return value * value;
        }
    }
}
