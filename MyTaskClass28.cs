using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass28
    {
        private double _v28;
        private double _e28;
        private double _y28;


        public MyTaskClass28(double v28, double e28, double y28)
        {
            _v28 = v28;
            _e28 = e28;
            _y28 = y28;
        }
        public void W28()
        {
            Console.WriteLine($"W = {(0.004 * _v28 + Math.Pow(_e28, 2 * _y28)) / (Math.Pow(_e28, _y28 / 2))}");


        }
    }
}

