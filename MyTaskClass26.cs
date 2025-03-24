using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass26
    {
        private double _u26;
        private double _y26;


        public MyTaskClass26(double u26, double y26)
        {
            _u26 = u26;
            _y26 = y26;
        }
        public void T26()
        {
            Console.WriteLine($"T = {(Math.Sin(2 * _u26)) / (Math.Log10(2 * _y26 + _u26))}");


        }
    }
}
