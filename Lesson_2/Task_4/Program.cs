using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_4
{
    //Роман Р

    //Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
    //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
    //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
    //программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.


    class Program
    {
        static bool Str(int x, int y)
        {
            Console.Write("Введите логин: ");
            string a = Console.ReadLine();
            string b = "root";
            x = 0;
            if (a == b)
            {
                x++;
            }
            Console.Write("Введите пароль: ");
            string c = Console.ReadLine();
            string d = "GeekBrains";
            y = 0;
            if (c == d)
            {
                y++;
            }
            
            return x>0 && y>0;
        }
        static void Main(string[] args)
        {
            int i =0;
            int n = 0;

            do
            {
                if (Str(1, 1))
                {

                    Console.WriteLine("Верно");
                    i = i + 3;
                    n = 0;
                }
                else
                    if (i != 1)
                    {
                        Console.WriteLine("Неверно");
                        i++;
                        n = 1;
                        
                    }
                    else 
                    {
                        Console.WriteLine("Опять неверно! Будьте внимательны.");
                        i++;
                        n = 1;
 
                    }
                Console.WriteLine();

            }
            while (i < 3);

            
            if (n>0)
            {
                Console.WriteLine();
                Console.WriteLine("Ну вот и всё!");
            }
            
                       
           
            Console.ReadKey();
        }
    }
}
