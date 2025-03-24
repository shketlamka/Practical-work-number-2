using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass13
    {
        private double _y13;
        private double _h13;
        private double _e13;

        public MyTaskClass13(double y13, double h13, double e13)
        {
            _y13 = y13;
            _h13 = h13;
            _e13 = e13;
        }
        public void A()
        {
            Console.WriteLine($"A = {(Math.Sin(2 * _y13 + _h13) + Math.Pow(_h13, 2)) / (Math.Pow(_e13, _h13) + _y13)}");


        }
    }
}
