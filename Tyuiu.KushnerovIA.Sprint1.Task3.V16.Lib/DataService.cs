﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KushnerovIA.Sprint1.Task3.V16.Lib
{
    public class DataService : ISprint1Task3V16
    {
        public double CoeffOfQuadraticEquation(double x1, double x2)
        {
            return Convert.ToDouble(Convert.ToInt32((x1 - x2) * 1000)) / 1000;
        }
    }
}
