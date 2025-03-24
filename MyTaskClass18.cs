using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass18
    {
        private double _y18;
        private double _k18;



        public MyTaskClass18(double y18, double k18)
        {
            _y18 = y18;
            _k18 = k18;
        }
        public void R18()
        {
            Console.WriteLine($"R = {(Math.Sqrt(Math.Pow(Math.Sin(_y18), 2) + 6.835) / (Math.Log10(_y18 + _k18)) + 3 * Math.Pow(_y18, 2))}");


        }
    }
}
