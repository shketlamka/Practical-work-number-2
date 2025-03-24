using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass19
    {
        private double _y19;
        private double _q19;



        public MyTaskClass19(double y19, double q19)
        {
            _y19 = y19;
            _q19 = q19;
        }
        public void E()
        {
            Console.WriteLine($"E = {(Math.Log10(0.7 * _y19 + 2 * _q19)) / (Math.Sqrt(3 * Math.Pow(_y19, 2) + 0.5 * _y19 + 4))}");


        }
    }
}
