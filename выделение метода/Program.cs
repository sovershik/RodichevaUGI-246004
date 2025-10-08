using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace строки_и_символы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(F(3, 5) * F(3, 7) * F(5, 5));
        }
        static double F(double x, double y)
        {
            return (Math.Sin(x) + Math.Sqrt(x)) / (Math.Cos(y) + Math.Sqrt(y));
        }
    }
}
