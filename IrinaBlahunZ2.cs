using System;

namespace IrinaBlahunZ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();

            if (name == "Вячеслав")
            {
                Console.WriteLine($"Привет , {name}");
            }
            else
            {
                Console.WriteLine("Нет такого имени");
            }
        }

    }
}
