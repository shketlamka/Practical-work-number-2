using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass27
    {
        private double _p27;
        private double _y27;


        public MyTaskClass27(double p27, double y27)
        {
            _p27 = p27;
            _y27 = y27;
        }
        public void Z27()
        {
            Console.WriteLine($"Z = {(Math.Sin(Math.Pow(_p27 + 0.4, 2))) / (Math.Pow(_y27, 2) + 7.325 * _p27)}");


        }
    }
}
