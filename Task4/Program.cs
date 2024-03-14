using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class StringExtension
    {
        public static bool IsPositiveInteger(this string str)
        {
            foreach (char c in str)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class Task4
    {
        public static void Run()
        {
            string input = Share.ReadString("Введите число: ");

            if (input.IsPositiveInteger())
            {
                Console.WriteLine("Строка является положительным целым числом.");
            }
            else
            {
                Console.WriteLine("Строка не является положительным целым числом.");
            }
        }
    }
}
