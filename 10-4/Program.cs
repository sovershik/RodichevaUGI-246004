using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите натуральное число: ");
                int num = int.Parse(Console.ReadLine());
                int min = 9;
                int max = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                    if (digit < min) min = digit;
                    if (digit > max) max = digit;
                    num /= 10;
                }

                Console.WriteLine("Минимальная цифра: " + min);
                Console.WriteLine("Максимальная цифра: " + max);
            }


        }
        }
    }
