using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_3
{
    //Роман Р

    //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел.

    class Program
    {
        static bool Odd(int a) //метод определения четных или нечетных чисел
        {
            return a % 2 != 0; 
        }
        
        static void Main(string[] args) //точка запуска
        {
            int n = 1;
            int x=0;
            while (n != 0)
            {                
                Console.Write("Введите число: ");
                int m = Convert.ToInt32(Console.ReadLine());
                
                if (Odd(m) && m>0)
                {
                    x=x+m;
 
                }
                  
                        
                n = m;
             
            }
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
