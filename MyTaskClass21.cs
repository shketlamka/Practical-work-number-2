using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass21
    {
        private double _k21;
        private double _x21;
        private double _d21;
        private double _p21;



        public MyTaskClass21(double k21, double x21, double d21, double p21)
        {
            _k21 = k21;
            _x21 = 21;
            _d21 = 21;
            _p21 = p21;
        }
        public void Q()
        {
            Console.WriteLine($"Q = {(Math.Sqrt(_k21 + 2.6 * _p21 * Math.Sin(_k21)) / (_x - Math.Pow(_d21, 3)))}");


        }
    }
}
