﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass8
    {
        private double _t8;
        private double _y8;

        public MyTaskClass8(double t8, double y8)
        {
            _t8 = t8;
            _y8 = y8;

        }
        
        public void T()
        {
            Console.WriteLine($"T = {(2.37 * Math.Sin(_t8 + 1)) / (Math.Sqrt(4 * Math.Pow(_y8, 2) - 0.1 * _y8 + 5))}");


        }
    }
}
