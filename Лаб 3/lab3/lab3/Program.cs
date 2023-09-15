using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        enum Specialization // Перечисление специализация
        {
            Lecture = 1,
            IT,
            Offical,
            Special
        }
        struct LectureRoom // Структура аудитория в университете
        {
            public int number; // Номер аудитории
            public int floor; // Номер этажа
            public int countPlaces; // Количество мест
            public int size; // Площадь
            public Specialization specialization; // Специализация
        }
        static bool checkNumber(int number) // Функция проверки правильности номера аудитории
        {
            if ((number >= 100 && number <= 599) || (number >= -299 && number <= -100))
                return true;
            else
                return false;
        }
        static bool checkFloor(int floor) // Функция проверки правильности номера этажа
        {
            if (floor >= -2 && floor!=0 && floor <= 5)
                return true;
            else
                return false;
        }
        static bool checkCountPlaces(int countPlaces) // Функция проверки правильности количества мест аудитории
        {
            if (countPlaces >= 10 && countPlaces <= 200)
                return true;
            else
                return false;
        }
        static bool checkSize(int size) // Функция проверки правильности площади аудитории
        {
            if (size >= 10 && size <= 250)
                return true;
            else
                return false;
        }
        static bool checkSpecialization(int specialization) // Функция проверки правильности специализации аудитории
        {
            if (specialization >= 1 && specialization <= 4)
                return true;
            else
                return false;
        }
        static List<LectureRoom> university = new List<LectureRoom>(); // Список аудиторий университета
        static bool Add_New_Room() // Функция добавления аудитории в университет
        {
            Console.WriteLine("\n--------------Добавление новой аудитории--------------");
            LectureRoom new_room = new LectureRoom(); // Создание новой аудитории
            Console.Write("Введите номер аудитории(от -299 до 599, без 0xx и -0xx): ");
            new_room.number = int.Parse(Console.ReadLine()); // Ввод номера аудитории
            if (!checkNumber(new_room.number)) // Проверка номера аудитории
                return false;
            Console.Write("Введите этаж аудитории(от -2 до 5): ");
            new_room.floor = int.Parse(Console.ReadLine()); // Ввод номера этажа
            if (!checkFloor(new_room.floor)) // Проверка номера этажа
                return false;
            Console.Write("Введите количество мест в аудитории(от 10 до 200): ");
            new_room.countPlaces = int.Parse(Console.ReadLine()); // Ввод количества мест аудитории
            if (!checkCountPlaces(new_room.countPlaces)) // Проверка количества мест аудитории
                return false;
            Console.Write("Введите площадь аудитории(от 10 до 250): ");
            new_room.size = int.Parse(Console.ReadLine()); // Ввод площади аудитории
            if (!checkSize(new_room.size)) // Проверка площади аудитории
                return false;
            Console.Write("Введите специализацию аудитории(1 - обычная, 2 - технологическая, 3 - официальная, 4 - специальная): ");
            int spec = int.Parse(Console.ReadLine()); // Ввод специализации аудитории
            if (checkSpecialization(spec)) // Проверка специализация аудитории
                new_room.specialization = (Specialization)spec;
            else
                return false;
            Console.WriteLine("--------------Добавление новой аудитории--------------\n");
            university.Add(new_room); // Добавление новой аудитории в список
            return true;
        }
        static void Show_all() // Функция вывода всех аудиторий
        {
            Console.WriteLine("\n--------------Вывод всех аудитории--------------");
            foreach (var room in university) // Цикл для вывода всех аудиторий
            {
                Console.WriteLine($"Аудитория {room.number}:");
                Console.WriteLine($"\tЭтаж: {room.floor}");
                Console.WriteLine($"\tКоличество мест: {room.countPlaces} чел.");
                Console.WriteLine($"\tПлощадь: {room.size} кв.м.");
                Console.WriteLine($"\tСпециализация: {room.specialization}");
            }
            Console.WriteLine("--------------Вывод всех аудитории--------------\n");
        }
        static bool Change_Room(int number) // Функция изменения аудитории по номеру
        {
            for (int i = 0;i<university.Count;i++) // Цикл поиска изменяемой аудитории
            {
                if (university[i].number == number) // Сравнение номера аудитории
                {
                    Console.WriteLine($"\n--------------Изменение данных аудитории: {number}--------------");
                    Console.Write("Введите номер аудитории(от -299 до 599, без 0xx и -0xx): ");
                    LectureRoom change_room = new LectureRoom();
                    change_room.number = int.Parse(Console.ReadLine());
                    if (!checkNumber(change_room.number))
                        return false;
                    Console.Write("Введите этаж аудитории(от -2 до 5): ");
                    change_room.floor = int.Parse(Console.ReadLine());
                    if (!checkFloor(change_room.floor))
                        return false;
                    Console.Write("Введите количество мест в аудитории(от 10 до 200): ");
                    change_room.countPlaces = int.Parse(Console.ReadLine());
                    if (!checkCountPlaces(change_room.countPlaces))
                        return false;
                    Console.Write("Введите площадь аудитории(от 10 до 250): ");
                    change_room.size = int.Parse(Console.ReadLine());
                    if (!checkSize(change_room.size))
                        return false;
                    Console.Write("Введите специализацию аудитории(1 - обычная, 2 - технологическая, 3 - официальная, 4 - специальная): ");
                    int spec = int.Parse(Console.ReadLine());
                    if (checkSpecialization(spec))
                        change_room.specialization = (Specialization)spec;
                    else
                        return false;
                    university[i] = change_room;
                    Console.WriteLine($"--------------Изменение данных аудитории: {number}--------------\n");
                    return true;
                }
            }
            return false;
        }
        static void find_floor(int floor) // Фукнция поиска аудитории по этажу
        {
            Console.WriteLine($"\n--------------Вывод всех аудитории {floor} этажа--------------");
            foreach (var room in university) // Цикл для поиска аудитории
            {
                if (room.floor == floor) // Сравнение номера этажа
                {
                    Console.WriteLine($"Аудитория {room.number}:");
                    Console.WriteLine($"\tКоличество мест: {room.countPlaces} чел.");
                    Console.WriteLine($"\tПлощадь: {room.size} кв.м.");
                    Console.WriteLine($"\tСпециализация: {room.specialization}");
                }
            }
            Console.WriteLine($"--------------Вывод всех аудитории {floor} этажа--------------\n");
        }
        static void find_countPlaces(int countPlaces) // Функция поиска аудитории по количеству мест
        {
            Console.WriteLine($"\n--------------Вывод всех аудитории c {countPlaces} количеством мест--------------");
            foreach (var room in university) // Цикл для поиска аудитории
            {
                if (room.countPlaces == countPlaces) // Сравнение количества мест
                {
                    Console.WriteLine($"Аудитория {room.number}:");
                    Console.WriteLine($"\tЭтаж: {room.floor}");
                    Console.WriteLine($"\tПлощадь: {room.size} кв.м.");
                    Console.WriteLine($"\tСпециализация: {room.specialization}");
                }
            }
            Console.WriteLine($"--------------Вывод всех аудитории c {countPlaces} количеством мест--------------\n");
        }
        static void find_size(int size) // Функция поиска аудитории по площади
        {
            Console.WriteLine($"\n--------------Вывод всех аудитории c площадью {size} кв.м.--------------");
            foreach (var room in university) // Цикл для поиска аудитории
            {
                if (room.size == size) // Сравнение площади
                {
                    Console.WriteLine($"Аудитория {room.number}:");
                    Console.WriteLine($"\tЭтаж: {room.floor}");
                    Console.WriteLine($"\tКоличество мест: {room.countPlaces} чел.");
                    Console.WriteLine($"\tСпециализация: {room.specialization}");
                }
            }
            Console.WriteLine($"--------------Вывод всех аудитории c площадью {size} кв.м.--------------\n");
        }
        static void find_max_size() // Функция дл поиска аудитории максимальной площади
        {
            int size = 0; // Максимальная площадь
            foreach (var room in university) // Цикл для поиска максимальной площади
            {
                if (size < room.size) // Сравнение площадей
                {
                    size = room.size; // Присваение новой максимальной площади
                }
            }
            Console.WriteLine($"\n--------------Вывод аудитории c максимальной площадью--------------");
            foreach (var room in university) // Цикл для поиска аудитории
            {
                if (room.size == size) // Сравнение площадей
                {
                    Console.WriteLine($"Аудитория {room.number}:");
                    Console.WriteLine($"\tЭтаж: {room.floor}");
                    Console.WriteLine($"\tКоличество мест: {room.countPlaces} чел.");
                    Console.WriteLine($"\tПлощадь: {room.size} кв.м.");
                    Console.WriteLine($"\tСпециализация: {room.specialization}");
                }
            }
            Console.WriteLine($"--------------Вывод аудитории c максимальной площадью--------------\n");
        }
        static void find_spec(Specialization specialization) // Функция для поиска аудитории по специализации
        {
            Console.WriteLine($"\n--------------Вывод всех аудитории c специализацией {specialization}--------------");
            foreach (var room in university) // Цикл для поиска аудитории
            {
                if (room.specialization == specialization) // Сравнение специализации
                {
                    Console.WriteLine($"Аудитория {room.number}:");
                    Console.WriteLine($"\tЭтаж: {room.floor}");
                    Console.WriteLine($"\tКоличество мест: {room.countPlaces} чел.");
                    Console.WriteLine($"\tПлощадь: {room.size} кв.м.");
                }
            }
            Console.WriteLine($"--------------Вывод всех аудитории c специализацией {specialization}--------------\n");
        }
        static void mesErr(string why) // Функции для вывода сообщения об ошибке
        {
            Console.WriteLine($"\nОшибка!!! {why}\n");
        }
        static void mesSuc() // Функция для вывода сообщения об успехе
        {
            Console.WriteLine("Успех!!!\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа \"База данных аудиторий университета\".\n");
            int command=0; // Переменная для ввода команды
            do // Бесконечный цикл для ввода команд
            {
                Console.Write("Введите команду(0 - список комманд): ");
                command = int.Parse(Console.ReadLine()); // Ввод команды
                switch (command) // Оператор switch для выбора действии
                {
                    case -1: // Выход
                        break;
                    case 0: // Список команд
                        Console.WriteLine();
                        Console.WriteLine("Список команд: ");
                        Console.WriteLine("\t-1: выход из программы");
                        Console.WriteLine("\t1: вывод всех аудиторий");
                        Console.WriteLine("\t2: добавление новой аудитории");
                        Console.WriteLine("\t3: изменение аудитории");
                        Console.WriteLine("\t4: вывод всех аудиторий с определнного этажа");
                        Console.WriteLine("\t5: вывод всех аудиторий с определнным количеством мест");
                        Console.WriteLine("\t6: вывод всех аудиторий с определнной площадью");
                        Console.WriteLine("\t7: вывод всех аудиторий с максимальной площадью");
                        Console.WriteLine("\t8: вывод всех аудиторий с определенной специализацией");
                        Console.WriteLine("\t9: информация о программе\n");
                        break;
                    case 1: // Вывод всех аудиторий
                        Show_all();
                        break;
                    case 2: // Добавление аудитории
                        if (Add_New_Room())
                        {
                            mesSuc();
                        }
                        else mesErr("Неудалось добавить новую аудиторию!!!");
                        break;
                    case 3: // Изменение аудитории
                        Console.Write("\nНомер меняемой аудитории: ");
                        int num = int.Parse(Console.ReadLine());
                        if (checkNumber(num))
                        {
                            if (Change_Room(num))
                            {
                                mesSuc();
                            }
                            else mesErr("Неудалось найти или изменить аудиторию!!!");
                        }
                        else mesErr("Неверный номер аудитории!!!");
                        break;
                    case 4: // Вывод аудиторий с определенным этажом
                        Console.Write("\nНомер этажа: ");
                        int floor = int.Parse(Console.ReadLine());
                        if (checkFloor(floor))
                        {
                            find_floor(floor);
                        }
                        else mesErr("Неверный номер этажа!!!");
                        break;
                    case 5: // Вывод аудиторий с определенным количеством мест
                        Console.Write("\nКоличество мест: ");
                        int countPlaces = int.Parse(Console.ReadLine());
                        if (checkCountPlaces(countPlaces))
                        {
                            find_countPlaces(countPlaces);
                        }
                        else mesErr("Неверное количество мест!!!");
                        break;
                    case 6: // Вывод аудиторий с определенной площадью
                        Console.Write("\nПлощадь: ");
                        int size = int.Parse(Console.ReadLine());
                        if (checkSize(size))
                        {
                            find_size(size);
                        }
                        else mesErr("Неверная площадь!!!");
                        break;
                    case 7: // Вывод аудиторий с максимальнйо площадью
                        find_max_size();
                        break;
                    case 8:  // Вывод аудиторий с определенной специализацией
                        Console.Write("\nСпециализация: ");
                        int spec = int.Parse(Console.ReadLine());
                        if (checkSpecialization(spec))
                        {
                            find_spec((Specialization)spec);
                        }
                        else mesErr("Неверный номер специализации!!!");
                        break;
                    case 9:
                        Console.WriteLine("\n--------------О программе--------------");
                        Console.WriteLine("Версия: 1.0");
                        Console.WriteLine("Название: \"База данных аудиторий университета\".");
                        Console.WriteLine("Производитель: Костин.К.Д.");
                        Console.WriteLine("--------------О программе--------------\n");
                        break;
                    default: // Незвестная команда
                        mesErr("Неизвестная комманда!!!");
                        break;
                }
            } while (command != -1); // Бесконечный цикл для ввода команд
        }
    }
}
