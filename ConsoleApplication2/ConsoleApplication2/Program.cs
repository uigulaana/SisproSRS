using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] massiv = { 1, 2, 3, 4, 5, 6, 7 };
            for (i = massiv.Length - 1; i >= 0; i--)
            {
                Console.Write(" " + massiv[i]);
            }
            Console.ReadLine();
        }
    }
}
