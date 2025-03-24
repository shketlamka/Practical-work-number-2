using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass12
    {
        private double _t12;
        private double _y12;

        public MyTaskClass12(double t12, double y12)
        {
            _t12 = t12;
            _y12 = y12;
        }

        public void R()
        {
            Console.WriteLine($"R = {(Math.Sin(Math.Pow(2 * _t12 + 1, 2)) + 0.3) / (Math.Log10(_t12 + _y12))}");


        }
    }
}
