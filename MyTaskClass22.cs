using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass22
    {
        private double _y22;
        private double _t22;




        public MyTaskClass22(double y22, double t22)
        {
            _y22 = y22;
            _t22 = t22;
        }
        public void S()
        {
            Console.WriteLine($"S = {(4.351 * Math.Pow(_y22, 3) + 2 * _t22 * Math.Log10(_t22)) / (Math.Sqrt(Math.Cos(2 * _y22) + 4.351))}");


        }
    }
}
