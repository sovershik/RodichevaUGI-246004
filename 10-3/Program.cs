using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите переменную А, 1 < А < 1,5: ");
                double a = double.Parse(Console.ReadLine());
                if ((a > 1) && (a < 1.5))
                {
                    double num = 10;
                    for (double i = 2; num >= a; i++)
                    {
                        num = 1 + (1 / i);
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("Значение а не находится в заданном диапазоне.");
                }

            }
        }
    }
}
