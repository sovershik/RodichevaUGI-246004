using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            double[] array = new double[n];
            Random rnd = new Random(); //извините, я не поняла, хотят ли тут просто рандомные числа или ввод этих чисел с клавиатуры

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.NextDouble() * 20 - 10;
            }

            PrintArray(array);
        }

        static void PrintArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]:F3} ");
            }
            Console.WriteLine();
        }
    }
}
