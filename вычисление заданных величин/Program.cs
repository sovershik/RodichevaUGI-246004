using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace вычисление_заданных_величин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sqSide;
            Console.WriteLine("Введите сторону квадрата, дробную часть (если есть) через точку");
            sqSide = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine("Площадь квадрата: " + sqSide*sqSide + ", периметр квадрата: " + sqSide*4);
        }
    }
}
