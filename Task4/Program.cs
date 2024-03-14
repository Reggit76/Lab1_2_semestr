using System;
using System.Collections.Generic;
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

            int number = 0;
            while (true)
            {
                if (number.ToString() == str)
                {
                    return number > 0;
                }
                number++;
            }
        }
    }

    public class Task4
    {
        public static void Run()
        {
            string input = "-12345";

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
