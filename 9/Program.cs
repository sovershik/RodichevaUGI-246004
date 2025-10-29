using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Введите число:");
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine("Итог расчета: " + F(num));
            }
        }

        static double F(double x)
        {
            if (Math.Sin(x) < -0.5)
            { return (Math.Sin(x); }
            else if (Math.Sin(x) > 0.5)
            { return 1; }
            else { return 0; }
        }
    }
}
