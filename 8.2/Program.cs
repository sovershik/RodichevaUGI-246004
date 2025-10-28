using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите координату x:");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите координату y:");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("Результат проверки: " + IsPointInCoo(x, y));
            }
        }

        static bool IsPointInCoo(double xCord, double yCord)
        {
            if ((xCord >= 1) & (yCord <= -1) || (xCord >= 2) & (yCord >= 0)) { return true; } else { return false; }
        }
    }
}
