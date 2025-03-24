using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass4
    {
        private double _w4;
        private double _y4;

        public MyTaskClass4(double w4, double y4)
        {
            _w4 = w4;
            _y4 = y4;
        }
        public void G14()
        {
            Console.WriteLine($"G = {(9.33 * Math.Pow(_w4, 2) + Math.Sqrt(_w4)) / (Math.Log10(_y4 + 3.5) + Math.Sqrt(_y4))}");


        }
    }
}
