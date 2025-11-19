using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите целое число N: ");
                int n = int.Parse(Console.ReadLine());
                double a = 1;
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Введите действительное число А: ");
                    a *= double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Результат умножения: " + a);
            }
        }
    }
}
