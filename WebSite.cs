using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    // Класс описывающий веб-сайт
    internal class WebSite
    {
        public string Name { get; set; }         // Название сайта
        public string Path { get; set; }         // Путь к сайту
        public string Description { get; set; }  // Описание сайта
        public string IpAddress { get; set; }    // ip адрес
        // Конструктор
        public WebSite(string name = "", string path = "", string description = "", string ipAddress = "")
        {
            Name = name;
            Path = path;
            Description = description;
            IpAddress = ipAddress;
        }
        // Метод вывода
        public void Print()
        {
            Console.WriteLine($"Site name - {Name}"); 
            Console.WriteLine($"The path to the site: {Path}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"ip address - {IpAddress}");
        }
    }
}
