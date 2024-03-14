using System;
using System.Collections.Generic;


namespace Menu
{
    public class Program
    {
        static void Main()
        {
            int choice;

            while (true)
            {
                Share.MenuBuilder(5);
                choice = Share.ReadInteger("Выберите пункт Меню: ");
                switch (choice)
                {
                    case 1:
                        Task1.Task1.Run();
                        break;
                    case 2:
                        Task2.Task2.Run();
                        break;
                    case 3:
                        Task3.Task3.Run();
                        break;
                    case 4:
                        Task4.Task4.Run();
                        break;
                    case 5:
                        Task5.Task5.Run();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Выбран пункт отсутствующий в меню!");
                        break;
                }
            }
        }
    }
}
