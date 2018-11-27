using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2
{
    //Роман Р
    //Написать метод подсчета количества цифр числа

    class Program
    {
        static int razryad()
        {
            Console.WriteLine("             << razryadnost chisla >>");
            Console.WriteLine("");
            Console.WriteLine("Вычисление разрядности числа");
            Console.WriteLine("");

            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 0;
            while (n != 0)
            {
                r++;
                n = n / 10;

            }
            Console.WriteLine("Разрядность:   " + r);
            return r;
        }

        static void Main(string[] args)
        {
            razryad();
            Console.ReadKey();
        }
    }
}
