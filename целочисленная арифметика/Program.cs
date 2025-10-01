using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace целочисленная_арифметика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Введите четырехзначное число");
            num = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
            int numb1 = num / 1000;
            int numb2 = (num / 100) % 10;
            int numb3 = (num / 10) % 10;
            int numb4 = num % 10;
            Console.WriteLine(numb4 + "" + numb3 + "" + numb2 + "" + numb1);
        }
    }
}
