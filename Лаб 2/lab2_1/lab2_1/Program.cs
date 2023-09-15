using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // Переменная генератора
            int size; // Целая переменная размера массива
            Console.WriteLine("Программа работы с массивом."); // Вывод информации о программе
            Console.Write("Входные данные:\nВведите размер массива: "); // Подсказки для ввода радиуса
            size = int.Parse(Console.ReadLine()); // Ввод размера массива
            if (size > 1) // Проверка введеного размера
            {
                int[] mass = new int[size]; // Создание и выделение памяти под массив
                int findFirst = -1; // Целая переменная для хранения позиции первого положительного числа
                int findLast = -1; // Целая переменная для хранения позиции последней положительного числа
                for (int i = 0; i < size; i++) // Цикл генерации массива 
                {
                    mass[i] = rnd.Next(-100, 100); // генерация элемента с помощью random
                    if (mass[i] > 0) // Проверка элемента больше 0
                    {
                        if (findFirst == -1) // Проверка нахождения позиции первого положительного элемента
                        {
                            findFirst = i; // Присваивание первой позиции
                            continue;
                        }
                        findLast = i; // Присваивание последней позиции
                    }
                }
                Console.WriteLine("Выходные данные:"); // Вывод данных
                Console.WriteLine($"Сгенерированный массив с длинной {size}: "); // Подсказки
                for (int i = 0; i < size; i++) // Цикл вывода массива
                {
                    if (i > findFirst && i < findLast) // Проверка нахождения текущего элемента между первым и последним положительным элемнтом 
                    {
                        Console.ForegroundColor = ConsoleColor.Blue; // Смена цвета текста на синий
                        Console.WriteLine($"mass[{i}] = {mass[i]}"); // Вывод элемента с его индексом
                    }
                    else
                    {
                        Console.ResetColor(); // Сброс цвет на стандартный (белый)
                        Console.WriteLine($"mass[{i}] = {mass[i]}"); // Вывод элемента с его индексом 
                    }
                }
            }
            else
            {
                Console.WriteLine("Ошибка!!!"); // Подсказка о ошибке
                Console.WriteLine("Неверные входные данные (Размер массива должен быть больше 1)."); // Вывод подсказки о неверных входных данных
            }
            Console.Write("Для завершения программы нажмите Enter..."); // Подсказка для завершения программы
            Console.ReadLine(); // Ожидание ввода для завершения программы
        }
    }
}
