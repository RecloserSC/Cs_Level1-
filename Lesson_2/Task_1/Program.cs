using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_1
{
    // Роман Р

    //Написать метод, возвращающий минимальное из трёх чисел.
    class Program
    {
        static int min()
        {
            Console.WriteLine("             << min_number >>");
            Console.WriteLine("");
            Console.WriteLine("Вычисление минимального числа");
            Console.WriteLine("");

            Console.Write("Введите первое число:  ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число:  ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите третье число:  ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            int n;
            if (n1 < n2)

                n = n1;

            else

                n = n2;

            if (n3 < n)

                n = n3;

            Console.WriteLine("");
            Console.Write("Минимальное число: " + n);
            return n1;
        }
        static void Main(string[] args)
        {
            min();
            //Console.WriteLine("мин"+ min());
            Console.ReadKey();

        }
    }
}
