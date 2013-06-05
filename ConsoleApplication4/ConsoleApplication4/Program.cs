using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static bool Prostoe(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n;
            int s = 0;
            int i = 0;
            int otvet = 0;
            Console.WriteLine("Введите простое число");
            n = Convert.ToInt16(Console.ReadLine());
            s = n;
            s=s+1;
            for (i = s; i < 10000; i++)
            {
                if (Prostoe(i))
                {
                    otvet = i;
                    break;
                }
            }
            Console.WriteLine(otvet);
         }
    }
}