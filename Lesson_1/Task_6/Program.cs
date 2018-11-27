using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_6
{
    // Роман Р

    //Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
    
    class Program
    {
        /// <summary>
        /// Вывод текста с параметрами:цвет,текст,координаты курсора x,y.
        /// </summary>
        /// <param name="foregroundcolor"></param>
        /// <param name="msg"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void Print(ConsoleColor foregroundcolor, string msg, int x, int y)
        {
            Console.ForegroundColor = foregroundcolor;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static void Pause()
        {
            Console.WriteLine(" Нажмите Enter для завершения программы");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
        }
    }
}
