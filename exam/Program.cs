using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (uint oddNum = 9; oddNum > 0; oddNum += 2) // тут начинаем с 9, потому что первое составное нечетное; шаг 2 чтобы не захватывать четные. ПРИМЕЧАНИЕ: если начинать с 9, полный перебор занимает около 20 минут на моем ноутбуке (достаточно мощном). Для отладки можно взять 5701
            {
                bool flag = false; // флаг, который встанет, если гипотеза подтвердится
                if (simpleNum(oddNum) == false) //проверяем, является ли число простым. если сложное, идем дальше
                {
                    foreach (int i in SieveEratosthenes(oddNum)) //проверяем каждое простое число меньше данного
                    {
                        for (int j = 1; 2 * j * j < oddNum; j++) //проверяем каждое число, удвоенный квадрат которого меньше нашего числа
                        {
                            if (i + 2 * j * j == oddNum) { flag = true; } //если находим, что гипотеза удовлетворилась, флаг встает
                        }
                    }
                    if (flag == false) { Console.WriteLine(oddNum); break; } //если флаг не встал, то круто, мы нашли наименьшее число
                }
            }
            Console.WriteLine("Конец");
        }

        static bool simpleNum(uint num) //возвращает тру, если число простое, и фолс, если нет
        {
            for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                { return false; }
            }
            return true;
        }

        static List<uint> SieveEratosthenes(uint n)
        {
            var numbers = new List<uint>();
            for (var i = 2u; i < n; i++)
            {
                numbers.Add(i);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 2u; j < n; j++)
                {
                    numbers.Remove(numbers[i] * j);
                }
            }

            return numbers;
        }

    }
}
