using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат проверки: " + IsOnlyOneIs(m,n));

        }

        static bool IsOnlyOneIs(int num1, int num2)
        {
            if ((num1 % 2 == 0) & (num2 % 2 != 0) || (num1 % 2 != 0) & (num2 % 2 == 0)) { return true; } else { return false; }
        }
    }
}
