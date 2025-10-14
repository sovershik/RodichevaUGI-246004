using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace склейка_строк
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string StartWord = "клавиатура";
            Console.WriteLine(StartWord.Remove(0,6).Remove(1, 3) 
                + StartWord.Remove(0, 4).Remove(1, 5) 
                + StartWord.Remove(0, 5).Remove(1, 2));
            Console.WriteLine(StartWord.Remove(0, 8).Remove(1, 1) 
                + StartWord.Remove(0, 7).Remove(1, 2)
                + StartWord.Remove(1, 8));
        }
    }
}
