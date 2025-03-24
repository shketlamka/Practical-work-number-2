using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyTaskClass24
    {
        private double _k24;
        private double _e24;
        private double _y24;




        public MyTaskClass24(double k24, double e24, double y24)
        {
            _k24 = k24;
            _e24 = e24;
            _y24 = y24;
        }
        public void U()
        {
            Console.WriteLine($"U = {(Math.Log10(2 * _k24 + 4.3)) / (Math.Pow(_e24, _k24 + _y24) + Math.Sqrt(_y24))}");


        }
    }
}

