using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass11
    {
        private double _y11;
        private double _n11;

        public MyTaskClass11(double y11, double n11)
        {
            _y11 = y11;
            _n11 = n11;
        }

        public void D11()
        {
            Console.WriteLine($"D = {(Math.Pow(_y11, 2) + 0.5 * _n11 + 4.8) / Math.Sin(_y11)}");


        }
    }
}
