using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass17
    {
        private double _y17;
        private double _n17;
      


        public MyTaskClass17(double y17, double n17)
        {
            _y17 = y17;
            _n17 = n17;
        }
        public void H()
        {
            Console.WriteLine($"H = {(Math.Pow(_y17, 2) - 0.8 * _y17 + Math.Sqrt(_y17)) / (23.1 * Math.Pow(_n17, 2) + Math.Cos(_n17))}");


        }
    }
}
