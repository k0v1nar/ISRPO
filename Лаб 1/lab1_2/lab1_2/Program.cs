using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; // Числовая переменная стороны a
            int b; // Числовая переменная стороны b
            int c; // Числовая переменная стороны c
            Console.WriteLine("Программа проверки треугольника на прямоугольность."); // Вывод информации о программе
            Console.Write("Входные данные:\nВведите сторону a: "); // Подсказки для ввода стороны a
            a = int.Parse(Console.ReadLine()); // Ввод стороны a
            Console.Write("Введите сторону b: "); // Подсказки для ввода стороны b
            b = int.Parse(Console.ReadLine()); // Ввод стороны b
            Console.Write("Введите сторону c: "); // Подсказки для ввода стороны c
            c = int.Parse(Console.ReadLine()); // Ввод стороны c
            if (a > 0 && b > 0 && c > 0) // Проверка сторон на натуральность
            {
                if (a < b + c && b < a + c && c < a + b) // проверка существования треугольника с такмими сторонами
                {
                    Console.WriteLine("Выходные данные:"); // Подсказка
                    if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                    {
                        Console.WriteLine("Треугольник - прямоугольный."); // Вывод результата
                    }
                    else
                    {
                        Console.WriteLine("Треугольник - не прямоугольный."); // Вывод результата
                    }
                    Console.Write("Для завершения программы нажмите Enter..."); // Подсказка для завершения программы
                    Console.ReadLine(); // Ожидание ввода для завершения программы
                }
                else
                {
                    Console.WriteLine("Ошибка!!!"); // Подсказка о ошибке
                    Console.WriteLine("Неверные входные данные (Такого треугольника не существует)."); // Вывод подсказки о неверных входных данных
                    Console.Write("Для завершения программы нажмите Enter..."); // Подсказка для завершения программы
                    Console.ReadLine(); // Ожидание ввода для завершения программы
                }
            }
            else
            {
                Console.WriteLine("Ошибка!!!"); // Подсказка о ошибке
                Console.WriteLine("Неверные входные данные (Стороны должны быть больше 0)."); // Вывод подсказки о неверных входных данных
                Console.Write("Для завершения программы нажмите Enter..."); // Подсказка для завершения программы
                Console.ReadLine(); // Ожидание ввода для завершения программы
            }
        }
    }
}
