﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass3
    {
        private double _k3;
        private double _y3;

        public MyTaskClass3(double k3, double y3)
        {
            _k3 = k3;
            _y3 = y3;
        }
        public void U3()
        {
            Console.WriteLine($"U = {(Math.Log(_k3 - _y3) + Math.Pow(_y3, 4)) / (Math.Pow(Math.E, _y3) + 2.355 * Math.Pow(_k3, 2))}");


        }

    }
    
}

