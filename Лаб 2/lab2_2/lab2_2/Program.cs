using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // Переменная генератора
            int size_i; // Целая переменная количества строк
            int size_j; // Целая переменная количества столбцов
            Console.WriteLine("Программа работы с двумерным массивом."); // Вывод информации о программе
            Console.Write("Входные данные:\nВведите количество строк: "); // Подсказки для ввода количества строк
            size_i = int.Parse(Console.ReadLine()); // Ввод количества строк
            Console.Write("Введите количество столбцов: "); // Подсказки для ввода количества столбцов
            size_j = int.Parse(Console.ReadLine()); // Ввод количества столбцов
            if (size_i > 1 && size_j > 1) // Проверка правильности введеных данных
            {
                int[,] mass = new int[size_i, size_j]; // Создание и выделение памяти для двумерного массива
                for (int i = 0; i < size_i; i++) // Двойной цикл для заполнения двумерного массива случайными числами
                {
                    for (int j = 0; j < size_j; j++)
                    {
                        mass[i, j] = rnd.Next(-100, 100); // Заполнение элемента массива
                    }
                }
                bool firstNum = false; // Булевая переменна для нахождения первого положительного элемента строки
                Console.WriteLine("Выходные данные:"); // Вывод данных
                Console.WriteLine($"Сгенерированный массив с количеством строк {size_i} и количеством столбцов {size_j}: "); // Подсказки
                for (int i = 0; i < size_i; i++) // Двойной цикл для вывода двумерного массива
                {
                    for (int j = 0; j < size_j; j++)
                    {
                        if (!firstNum && mass[i, j] > 0) // Проверка положительности элемента и нахождения первого элемента 
                        {
                            Console.ForegroundColor = ConsoleColor.Red; // Смена цвета консоли
                            Console.Write($"{mass[i, j]}\t"); // Вывод элемента
                            Console.ResetColor(); // Сброс цвета консоли
                            firstNum = true; // Нахождение первого положительного элемента
                            continue; // Продолжение цикла
                        }
                        Console.Write($"{mass[i, j]}\t"); // Вывод элемента
                    }
                    Console.WriteLine(); // Перевод строки
                    firstNum = false; // Сброс переменной нахождения первого положительного элемента строки
                }
            }
            else
            {
                Console.WriteLine("Ошибка!!!"); // Подсказка о ошибке
                Console.WriteLine("Неверные входные данные (Количество строк и количество столбцов должно быть больше 1)."); // Вывод подсказки о неверных входных данных
            }
            Console.Write("Для завершения программы нажмите Enter..."); // Подсказка для завершения программы
            Console.ReadLine(); // Ожидание ввода для завершения программы
        }
    }
}

















