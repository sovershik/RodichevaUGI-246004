using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] num = { "1", "2", "3", "4", "5", "6", "7", "8" };
                string[] chars = { "a", "b", "c", "d", "e", "f", "g", "h" };
                Console.WriteLine("");
                string pos1 = Console.ReadLine();
                Console.WriteLine("");
                string pos2 = Console.ReadLine();
                if ((pos1 != pos2) & (num.Contains(pos1.Substring(1))) & (chars.Contains(pos1.Substring(0))) & (num.Contains(pos2.Substring(1))) & (chars.Contains(pos2.Substring(0))))
                { Console.WriteLine("Фигура в нужном диапазоне"); }
                else { Console.WriteLine(""); }
            }
        }
    }
}
