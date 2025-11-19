using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите целое число, количество работников: ");
                int n = int.Parse(Console.ReadLine());
                double MaxZp1 = 0;
                int WorkerWithMaxZp1 = 0;
                double MaxZp2 = 0;
                int WorkerWithMaxZp2 = 0;
                double MaxZp3 = 0;
                int WorkerWithMaxZp3 = 0;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Введите три числа, зарплаты за первый, второй и третий месяцы: ");
                    double m1 = double.Parse(Console.ReadLine());
                    double m2 = double.Parse(Console.ReadLine());
                    double m3 = double.Parse(Console.ReadLine());
                    if (m1 == Math.Max(Math.Max(m1, m2), m3))
                    { Console.WriteLine("Наибольшая зарплата работника " + i + " была в первом месяце"); }
                    else if (m2 == Math.Max(Math.Max(m1, m2), m3))
                    { Console.WriteLine("Наибольшая зарплата работника " + i + " была во втором месяце"); }
                    else
                    { Console.WriteLine("Наибольшая зарплата работника " + i + " была в третьем месяце"); }
                    if (m1 > MaxZp1)
                    { 
                        MaxZp1 = m1;
                        WorkerWithMaxZp1 = i;
                    }
                    if (m2 > MaxZp2)
                    { 
                        MaxZp2 = m2;
                        WorkerWithMaxZp2 = i;
                    }
                    if (m3 > MaxZp3)
                    {
                        MaxZp3 = m3;
                        WorkerWithMaxZp3 = i;
                    }
                }
                Console.WriteLine("В первом месяце наибольшую зарплату получил работник " + WorkerWithMaxZp1);
                Console.WriteLine("Во втором месяце наибольшую зарплату получил работник " + WorkerWithMaxZp2);
                Console.WriteLine("В третьем месяце наибольшую зарплату получил работник " + WorkerWithMaxZp3);

            }
        }
    }
}
