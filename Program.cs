// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2.1 узнать имя пользователя");
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");
            Console.ReadKey();

            Console.WriteLine("Упражнение 2.2 (деление чисел)");
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("ошибка, делить на ноль нельзя");
            }
            else
            {
                Console.WriteLine($" Результат деления чисел равен {(double)a / b}");
            }
            Console.ReadLine();

            Console.WriteLine("ДЗ 2.1 Вывести следующую букву");
            Console.Write("Введите букву: ");
            char bkv = Console.ReadKey().KeyChar;
            char nextBkv;
            if (bkv == 'z')
            {
                nextBkv = 'a';
            }
            else
            {
                nextBkv = (char)(((int)bkv) + 1);
                Console.WriteLine($"Следующая буква:" + nextBkv);
            }
            Console.ReadLine();

            Console.WriteLine("ДЗ 2.2 найти корни квадратного уравнения");
            Console.Write("Введите значение A1:");
            int A1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение B1:");
            int B1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение C1:");
            int C1 = Convert.ToInt32(Console.ReadLine());
            double D = B1 * B1 - 4 * A1 * C1; //дискриминант
            double Dd = Math.Sqrt(D); // вычисление корня из дискриминанта
            double k1 = (-B1 + Dd) / (2 * A1); //первый корень
            double k2 = (-B1 - Dd) / (2 * A1); // второй корень
            if (D < 0)
            {
                Console.WriteLine("Корней нет");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"первый корень равен " + k1);
                Console.WriteLine($"второй корень равен " + k2);
            }
            Console.ReadLine();
        }
    }
}