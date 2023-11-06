using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    // Класс описывающий магазин
    internal class Shop
    {
        public string Name { get; set; }              // Название магазина        
        public string Description { get; set; }       // Описание профиля
        public string TelephoneNumber { get; set; }   // Контактный номер телефона
        public string Email { get; set; }              // Контактный e-mail
        // Конструктор
        public Shop(string name = "", string description = "", string telephoneNumber = "", string email = "")
        {
            Name = name;
            Description = description;
            TelephoneNumber = telephoneNumber;
            Email = email;
        }
        // Метод вывода
        public void Print()
        {
            Console.WriteLine($"Name of the shop - {Name}");
            Console.WriteLine($"Description of the store profile: {Description}");
            Console.WriteLine($"Contact phone number: {TelephoneNumber}");
            Console.WriteLine($"Contact e-mail: {Email}");
        }
    }
}
