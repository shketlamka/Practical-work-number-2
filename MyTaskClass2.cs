using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass2
    {
        private double _d2;
        private double _y2;

        public MyTaskClass2(double d2, double y2)
        {
            _d2 = d2;
            _y2 = y2;

        }
        public void F2()
        {
            Console.WriteLine($"F = {Math.Log(_d2) + (3.5*Math.Pow(_d2, 2)+1) / (Math.Cos(2 * _y2))}");
        }
    }
}
