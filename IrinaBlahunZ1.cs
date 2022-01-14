using System;


namespace IrinaBlahunZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число N");
                int n = int.Parse(Console.ReadLine());
                if (n > 7)
                {
                    Console.WriteLine("Привет");
                }
                else 
                {
                    Console.WriteLine("Вы не достойны приветсвия)");          
                }           
            }

            catch (FormatException)
            {
                Console.WriteLine("Ошибка формата");
            }
        }

    }
}
