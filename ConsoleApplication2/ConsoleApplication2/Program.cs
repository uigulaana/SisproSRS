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
          
            int i,N;
            Console.Write("Введите число строк матрицы N=");
            N = Convert.ToInt32(Console.ReadLine());
            int[] massiv = new int[N];          
            for (i = 0; i < N; i++) 
                {
                    massiv[i] = Convert.ToInt32(Console.ReadLine());
                }
            Console.WriteLine();
            for (i = massiv.Length - 1; i >= 0; i--)
            {
                Console.Write(" " + massiv[i]);
            }
        }
    }
}
