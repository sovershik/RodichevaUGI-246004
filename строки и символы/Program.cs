using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace строки_и_символы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на русском:");
            string RusTxt = Console.ReadLine();
            Console.WriteLine("Вот перевод вашего тектса: " + RusToTrans(RusTxt));
        }

        static string RusToTrans(string SomeTxt)
        {
            SomeTxt = SomeTxt.ToUpper();
            return SomeTxt.Replace("А", "A")
                .Replace("Б", "B")
                .Replace("В", "V")
                .Replace("Г", "G")
                .Replace("Д", "D")
                .Replace("Е", "E")
                .Replace("Ё", "E")
                .Replace("Ж", "ZH")
                .Replace("З", "Z")
                .Replace("И", "I")
                .Replace("Й", "I")
                .Replace("К", "K")
                .Replace("Л", "L")
                .Replace("М", "M")
                .Replace("Н", "N")
                .Replace("О", "O")
                .Replace("П", "P")
                .Replace("Р", "R")
                .Replace("С", "S")
                .Replace("Т", "T")
                .Replace("У", "U")
                .Replace("Ф", "F")
                .Replace("Х", "KH")
                .Replace("Ц", "TS")
                .Replace("Ч", "CH")
                .Replace("Ш", "SH")
                .Replace("Щ", "SHCH")
                .Replace("Ъ", "IE")
                .Replace("Ы", "Y")
                .Replace("Ь", "")
                .Replace("Э", "E")
                .Replace("Ю", "IU")
                .Replace("Я", "IA")
                ;
        }

    }
}
