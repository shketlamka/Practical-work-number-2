using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass7
    {
        private double _m7;
        private double _y7;

        public MyTaskClass7(double m7, double y7)
        {
            _m7 = m7;
            _y7 = y7;

        }

        public void N()
        {
            Console.WriteLine($"N = {(Math.Pow(_m7, 2) + 2.8 * _m7 + 0.355) / (Math.Cos(2 * _y7) + 3.6)}");


        }
    }
}
