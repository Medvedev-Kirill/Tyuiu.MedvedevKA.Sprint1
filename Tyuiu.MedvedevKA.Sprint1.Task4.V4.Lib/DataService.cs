using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MedvedevKA.Sprint1.Task4.V4.Lib
{
    public class DataService : ISprint1Task4V4
    {
        public double Calculate(double x, double y)
        {
            var res =  (1 + x * y)  / Math.Abs(x + 2);
            return res; 
        }
    }
}
