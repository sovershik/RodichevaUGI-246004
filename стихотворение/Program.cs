using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace стихотворение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("А. Ахматова");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("'Нет, царевич, я не та...'");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Нет, царевич, я не та,\r\nКем меня ты видеть хочешь,\r\nИ давно мои уста\r\nНе целуют, а пророчат.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Не подумай, что в бреду\r\nИ замучена тоскою\r\nГромко кличу я беду:\r\nРемесло мое такое.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("А умею научить,\r\nЧтоб нежданное случилось,\r\nКак навеки приручить\r\nТу, что мельком полюбилась.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Славы хочешь? — у меня\r\nПопроси тогда совета,\r\nТолько это — западня,\r\nГде ни радости, ни света.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Ну, теперь иди домой\r\nДа забудь про нашу встречу,\r\nА за грех твой, милый мой,\r\nЯ пред Господом отвечу.");
            Console.ResetColor();
        }
    }
}
