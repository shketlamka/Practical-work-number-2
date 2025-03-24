using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass15
    {
        private double _y15;
        private double _j15;
       
        public MyTaskClass15(double y15, double j15)
        {
            _y15 = y15;
            _j15 = j15;
        }
        public void F()
        {
            Console.WriteLine($"F = {(2 * Math.Sin(0.354 * _y15 + 1)) / (Math.Log10(_y15 + 2 * _j15))}");


        }
    }
}
