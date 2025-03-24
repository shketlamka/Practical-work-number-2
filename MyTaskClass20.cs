using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass20
    {
        private double _t20;
        private double _l20;
        private double _y20;
        private double _e20;



        public MyTaskClass20(double t20, double l20, double y20, double e20)
        {
            _t20 = t20;
            _l20 = l20; 
            _y20 = y20;     
            _e20 = 20;
        }
        public void K()
        {
            Console.WriteLine($"K = {(2 * Math.Pow(_t20, 2) + 3 * _l20 + 7.2) / (Math.Log10(_y20 + Math.Pow(_e20, 2 * _l20)))}");


        }
    }
}
