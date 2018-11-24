using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_5
{
    // Роман Р

     // 5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
   //б) *Сделать задание, только вывод организовать в центре экрана.
   //в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).

    class Program
    {
       static void Print(ConsoleColor foregroundcolor,string msg, int x, int y)
        {
           
            Console.ForegroundColor = foregroundcolor;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
            

        }

        static void Main(string[] args)
        {
            Console.WriteLine(" Роман, Р, Москва");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine(" Роман, Р, Москва");
          
            
            Print(ConsoleColor.Red,"Роман, Р, Москва", 5, 8);
            Console.ReadKey();
        }
        
    }
}
