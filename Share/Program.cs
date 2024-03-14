using System;
using System.Collections;
using System.Diagnostics;

public static class Share
{
    public static int ReadInteger(string prompt = "")
    {
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result) && result >= 0)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Некорректный ввод! Пожалуйста, введите положительное целое число.");
            }
        } while (true);
    }

    public static string ReadString(string prompt = "")
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    public static double ReadDouble(string prompt = "")
    {
        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out double result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Некорректный ввод! Пожалуйста, введите число.");
            }
        } while (true);
    }

    public static void MenuBuilder(int n)
    {
        Console.WriteLine("====================================");
        Console.WriteLine("Главное меню: ");
        for (int i = 1; i <= n; i++) 
        {
            Console.Write($"{i}) Задача №{i}\n");
        }
        Console.WriteLine($"0) Выход");
        Console.WriteLine("====================================");
    }

    public static void PrintCollection(this IEnumerable collection)
    {
        foreach (var item in collection)
        {
            Console.Write(item.ToString() + " ");
        }
        Console.WriteLine();
    }
}
