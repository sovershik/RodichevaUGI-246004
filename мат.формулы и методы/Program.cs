using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var y = f("Введите х:");
            Console.WriteLine(y);
        }

        static double f(string message)
        {
            Console.WriteLine(message);
            var x = double.Parse(Console.ReadLine());
            return (2*Math.Cos(1/(x*x + 2))) / (x*x*x + 1);
        }
    }
}
