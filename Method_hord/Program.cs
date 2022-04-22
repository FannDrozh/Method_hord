using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_hord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Метод хорд");
            Console.WriteLine();
            Console.WriteLine("Исходный отредок (0.4;0.5)");
            double h = 0.01;
            Console.WriteLine("Шаг разбиения функции: "+ h);
            double x = 0.4;
            double k = 0.0000001;
            Console.WriteLine("Точность корня: " + k);
            double[] d = new double[10];
            int b = 0;// Число, которое изменяет индекс массива "d".
            int a = 0; // Счётчик цикла.
            Console.WriteLine();
            do
            {
                //Исходная функция
                double f = Math.Pow(x, 2) - Math.Cos(Math.PI * x);
                d[b] = f;
                b = b + 1; // Изменяем индекс на +1.
                //вывод в консоль
                Console.WriteLine("| " + x + "\t| " + f);
                x = x + h;
                a = a + 1;
            }
            while (a < 10);
            Console.WriteLine();

            double p1;
            double p2;            
            while (x+h < 0.51)
            {
                if (d[b] < 0 & d[b + 1] > 0 || d[b] > 0 & d[b + 1] > 0)
                {
                    p1 = x;
                    p2 = x+1;
                    Console.WriteLine("Подозрительные на отезке изоляции: " + p1 + "; " + p2);
                }
                x = x + h;
                b = b + 1;
            }

            
            


            Console.ReadKey();
        }
    }
}
