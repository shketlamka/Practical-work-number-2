using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass23
    {
        private double _y23;
        private double _d23;
        private double _e23;




        public MyTaskClass23(double y23, double d23, double e23)
        {
            _y23 = y23;
            _d23 = d23;
            _e23 = e23;
        }
        public void R23()
        {
            Console.WriteLine($"R = {(Math.Pow(Math.Sin(_y23), 2) + 0.3 * _d23) / (Math.Pow(_e23, _y23) + Math.Log10(_d23))}");


        }
    }
}
