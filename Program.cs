using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    internal class Program
    {
        // Метод, рисующий квадрат по заданным параметрам
        static void DrawSquare(int n, char a)
        {
            // Проверка: корректно ли ввели параметры
            if (n < 1)
            {
                Console.WriteLine("Не верно ввели длину стороны квадрата!");
                return;
            }
            // Если n = 1, выводим один символ и выходим из метода
            if (n == 1)                  
            {
                Console.WriteLine(a);
                return;                 
            }
            // Вывод верхней стороны квадрата
            for (int i = 0; i < n; i++)
            {
                Console.Write(a);
            }
            Console.WriteLine();
            // Вывод боковых сторон
            for (int i = 1; i < n - 1; i++)
            {
                Console.Write(a);
                for (int j = 1; j < n - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(a);
            }     
            // Вывод нижней стороны
            for (int i = 0; i < n; i++)
            {
                Console.Write(a);
            }
            Console.WriteLine();
        }
        // Метод, проверяющий является ли переданное число "палиндромом"
        static bool Palindrome(int number)
        {
            bool f = false;
            // Выделяем первую и последнюю цифры в записи числа
            int n1 = number % 10;    
            int n2 = number / 1000;   
            // Сравниваем найденные цифры
            if (n1 == n2)
            {
                // Если равны, выделяем остальные цифры
                n1 = number % 100 / 10;
                n2 = number % 1000 / 100;
                // Снова сравниваем, если равны - возвращяем true
                if (n1 == n2)
                {
                    f = true;
                }               
            }
            // Если на любом из этапов равенство не выполнится, возвращаем false
            return f;
        }
        // Метод, фильтрующий массив на основании переданных параметров
        static int[] ArrayFiltering(int[] arr, int[] mass)
        {
            // Считаем количество совпадений в основном массиве с массивом фильтрации
            int ch = 0;
            for (int j = 0; j < arr.Length; j++)
            {     
                for (int g = 0; g < mass.Length; g++)
                {
                    if (arr[j] == mass[g])
                    {                        
                        ch++;
                    }
                }                
            }
            // Создаём новый массив, длина которого длина основного массива за исключением совпадений
            int[] array=new int[arr.Length - ch];
            // Заполняем новый массив
            for (int j = 0, i = 0; j < arr.Length; j++)
            {
                bool f = true;
                for (int g = 0; g < mass.Length; g++)
                {
                    if (arr[j] == mass[g])
                    {
                        f = false;
                    }
                }
                if (f)
                {
                    array[i] = arr[j];
                    i++;
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1.");
            // Ввод данных пользователем
            Console.Write("Введите длину стороны квадрата: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите символ: ");
            char a = Convert.ToChar(Console.ReadLine());
            // Применение метода -
            // отображение квадрата согласнно введённым данным
            DrawSquare(n, a);
            Console.WriteLine();

            Console.WriteLine("Задача 2.");
            // Ввод числа пользователем
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // Применение метода - проверка:
            // является ли введённое число палиндромом
            if (Palindrome(number))
            {
                // Если true - число палиндром
                Console.WriteLine($"Число {number} - палиндром.");
            }
            else
            {
                // Иначе - не палиндром
                Console.WriteLine($"Число {number} - не является палиндромом.");
            }
            Console.WriteLine();

            Console.WriteLine("Задача 3.");
            int[] arr = new int[15];  // Основной массив
            int[] mass = new int[5];  // Массив фильтрации
            Random r = new Random();
            // Рандомное заполнение основного массива
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 100);                
            }
            // Составление массива фильтрации из элементов основного
            mass[0] = arr[r.Next(0, 15)];
            for (int i = 1; i < mass.Length; i++)
            {
                int x = arr[r.Next(0,15)];
                for(int j = 0; j < i; j++)
                {
                    // Проверка, чтобы не было повторяющихся элементов
                    while ( x == mass[j])
                    {
                        x = arr[r.Next(0, 15)];
                    }
                }
                mass[i] = x;
            }
            // Вывод массивов
            Console.WriteLine("Оригинальный массив:");
            foreach (int item in arr)
            {
                Console.Write(item + "\t");  
            }
            Console.WriteLine();
            Console.WriteLine("Массив с данными для фильтрации:");
            foreach (int item in mass)
            {
                Console.Write(item + "\t");   
            }
            Console.WriteLine();
            // Применение метода
            Console.WriteLine("Результат работы метода фильтрации:");
            int[] array = ArrayFiltering(arr, mass);
            foreach (int item in array)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Задача 4.");
            // Создание объекта
            WebSite site = new WebSite("Компьютерная Академия ТОП", "https://brn.top-academy.ru/", 
                "Крупнейшая международная сеть академий IT-образования", "");
            // Вывод только название сайта
            Console.WriteLine(site.Name);
            // Изменение описания
            site.Description += " с высоким уровнем трудоустройства выпускников";
            // Изменение ip адреса (добавление информации)
            site.IpAddress = "178.187.51.68";
            // Вывод полной информации
            site.Print();
            Console.WriteLine();

            Console.WriteLine("Задача 5.");
            // Создание объекта класса
            Journal journal = new Journal("Квантик", 2011, "О математике и физике, о лингвистике и жизни",
                "+7-495-745-80-31", "kvantik@mccme.ru");
            // Вывод информации
            journal.Print();
            Console.WriteLine();
            // Добавление информации в поле "контактный номер телефона"
            journal.TelephoneNumber += " WhatsApp: +7-919-993-48-21";
            // Изменение информации в поле "контактный e-mail"
            journal.Email = "biblio@mccme.ru";
            // Вывод на экран
            journal.Print();
            Console.WriteLine();

            Console.WriteLine("Задача 6.");
            // Создание объекта
            Shop shop = new Shop();
            // Вывод на экран
            shop.Print();
            // Ввод данных 
            shop.Name = "Пятёрочка";
            shop.Description = "Продовольственный магазин";
            shop.TelephoneNumber = "8-800-555-55-05";
            shop.Email = "-";
            // Вывод полученной информации
            Console.WriteLine($"{shop.Name} - {shop.Description} - {shop.TelephoneNumber}");
        }
    }
}
