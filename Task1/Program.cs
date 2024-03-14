using System;
using System.Collections.Generic;


namespace Task1
{
    public class Task1
    {
        public static void Run()
        {
            int n = Share.ReadInteger("Введите количество человек (N): ");
            Queue <int> queue = new Queue<int>();
            // Заполняем очередь числами от 1 до N
            for (int i = 1; i <= n; i++)
            {
                queue.Enqueue(i);
            }

            int step = 1;
            Console.Write("Изначальная очередь: ");
            queue.PrintCollection();
            while (queue.Count > 1)
            {
                // Удаляем каждый второй элемент
                
                queue.Enqueue(number);

                // Выводим оставшиеся номера на каждом шаге
                Console.Write($"Остались номера на {step} шаге: ");
                queue.PrintCollection();
                step++;
            }

            // Выводим последний оставшийся номер
            Console.WriteLine("Остался номер: " + queue.Dequeue());
        }
    }
}
