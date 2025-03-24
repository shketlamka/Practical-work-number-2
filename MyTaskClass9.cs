using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass9
    {
        private double _y9;
        private double _w9;

        public MyTaskClass9(double y9, double w9)
        {
            _y9 = y9;
            _w9 = w9;
        }

        public void V()
        {
            Console.WriteLine($"V = {(Math.Pow(_y9 + 2 * _w9, 3)) / (Math.Log10(_y9 + 0.75))}");


        }
    }
}
