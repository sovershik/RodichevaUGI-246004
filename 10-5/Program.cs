using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите первое натуральное число: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Введите второе натуральное число: ");
                int b = int.Parse(Console.ReadLine());

                while (b != 0)
                {
                    int temp = a % b;
                    a = b;
                    b = temp;
                }
                Console.WriteLine("НОД равен " + a);
            }
        }
    }
}
