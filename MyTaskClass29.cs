using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass29
    {
        private double _h29;
        private double _e29;
        private double _y29;


        public MyTaskClass29(double h29, double e29, double y29)
        {
            _h29 = h29;
            _e29 = e29;
            _y29 = y29;
        }
        public void T29()
        {
            Console.WriteLine($"T = {(0.355 * Math.Pow(_h29, 2) - 4.355) / (Math.Pow(_e22, _y29 + _h29) + Math.Sqrt(2.7 * _y29))}");


        }
    }
}

