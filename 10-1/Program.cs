using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {   while (true)
            {
                Console.Write("Введите дейсвительное число Х: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите натуральное число N: ");
                int n = int.Parse(Console.ReadLine());
                double num = 1;
                for (double i = 1; i <= n; i++)
                {
                    num = num + ((i + 1) / (i + 2)) * Math.Pow(x, i);
                }
                Console.WriteLine(num);
            }
        }
    }
}
