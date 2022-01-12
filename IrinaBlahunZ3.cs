using System;

namespace IrinaBlahunZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int size = int.Parse(Console.ReadLine());
            for (int i = 1; i <= size; i++)
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

        }
                    
    }
}