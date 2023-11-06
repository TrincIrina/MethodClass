using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    // Класс описывающий журнал
    internal class Journal
    {
        public string Name { get; set; }              // Название журнала
        public int Year { get; set; }                 // Год создания
        public string Description { get; set; }       // Описание
        public string TelephoneNumber { get; set; }   // Контактный номер телефона
        public string Email { get; set;}              // Контактный e-mail
        // Конструктор
        public Journal(string name = "", int year = 0, string description = "", 
            string telephoneNumber = "", string email = "")
        {
            Name = name;
            Year = year;
            Description = description;
            TelephoneNumber = telephoneNumber;
            Email = email;
        }
        // Метод вывода
        public void Print()
        {
            Console.WriteLine($"Name of the magazine - {Name}, year of foundation: {Year}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Contact phone number: {TelephoneNumber}");
            Console.WriteLine($"Contact e-mail: {Email}");
        }
    }
}
