using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MytaskClass25
    {
        private double _c25;
        private double _t25;
        

        public MytaskClass25(double c25, double t25)
        {

            _c25 = c25;
            _t25 = t25;
        }
        public void L25()
        {
            Console.WriteLine($"L = {(Math.Pow(Math.Cos(_c25), 2) + (3 * Math.Pow(_t25, 2) + 4)) / (Math.Sqrt(_c25 + _t25))}");


        }
    }
}
