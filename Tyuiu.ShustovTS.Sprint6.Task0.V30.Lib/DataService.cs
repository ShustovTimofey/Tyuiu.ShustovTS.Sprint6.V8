﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShustovTS.Sprint6.Task1.V30.Lib
{
    public class DataService : ISprint6Task1V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                int z = (2 * x - 2);
                if (z == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    y = ((4 - 2 * x) + ((2 + (Math.Cos(x))) / (2 * x - 2)));
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }
            return valueArray;

        }

    }
}
