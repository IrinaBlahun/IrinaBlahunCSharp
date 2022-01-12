using System;

namespace IrinaBlahunZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string name = Convert.ToString(Console.ReadLine());

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