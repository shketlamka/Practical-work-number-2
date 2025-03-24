using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass30
    {
        private double _p30;
        private double _e30;
        private double _y30;


        public MyTaskClass30(double p30, double e30, double y30)
        {
            _p30 = p30;
            _e30 = e30;
            _y30 = y30;


        }
        public void N30()
        {
            Console.WriteLine($"N = {(3 * Math.Pow(_y30, 2) + Math.Sqrt(_y30 + 1)) / (Math.Log10(_p30 + _y30) + Math.Pow(_e30, _p30))}");


        }
    }
}
