using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass16
    {
        private double _t16;
        private double _r16;
        private double _e16;
        private double _y16;


        public MyTaskClass16(double t16, double r16, double e16, double y16)
        {
            _t16 = t16;
            _r16 = r16;
            _e16 = e16;
            _y16 = y16;
        }
        public void W()
        {
            Console.WriteLine($"W = {(4 * Math.Pow(_t16, 3) + Math.Log10(_r16)) / (Math.Pow(_e16, _y16 +_r16) + 7.2 * Math.Sin(_r16))}");


        }
    }
}
