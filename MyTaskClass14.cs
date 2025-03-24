using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass14
    {
        private double _e14;
        private double _y14;
        private double _h14;

        public MyTaskClass14(double e14, double y14, double h14)
        {
            _e14 = e14;
            _y14 = y14;
            _h14 = h14;
        }
        public void P()
        {
            Console.WriteLine($"P = {(Math.Pow(_e14, _y14 + 2.5) + 7.1 * Math.Pow(_h14, 2)) / (Math.Pow(_e14, _h14) + _y14)}");


        }
    }
}
