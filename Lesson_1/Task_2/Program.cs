using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                            << IMT >>");
            Console.WriteLine("");
            Console.WriteLine("Введите данные для рассчета индекса массы тела");
            Console.WriteLine("");
            Console.Write("Рост, см: ");
            string growth = Console.ReadLine();
            float x = Convert.ToSingle(growth);
            float h = x / 100;
            Console.Write("Вес, кг:  ");
            string weight = Console.ReadLine();
            float m = Convert.ToSingle(weight);
            float I = m / (h * h);
            Console.WriteLine("");
            Console.WriteLine("Индекс массы тела = " + I);

            Console.ReadKey();
        }
    }
}
