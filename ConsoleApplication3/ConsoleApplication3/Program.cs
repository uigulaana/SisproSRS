using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, y, Integral;
            double sum = 0;
            double h = 0.000001;
            for (a = -1; a <= 1; a = a + h)
            {
                y = Math.Sqrt(1 - a * a);
                sum = sum + y;
            }
            Integral = h * sum;
            Console.WriteLine(Integral);
        }
    }
}
