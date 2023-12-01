using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShustovTS.Sprint6.Task0.V8.Lib
{
    public class DataService : ISprint6Task0V8
    {
        public double Calculate(int x)
        {
            double res = (((Math.Pow((double)x, 2)) - 1) / (Math.Sqrt(4 * (Math.Pow((double)x, 2)) - 2)));
            return Math.Round(res, 3);
        }
    }
}
