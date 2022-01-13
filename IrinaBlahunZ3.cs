using System;


namespace IrinaBlahunZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[42];
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            { 
                mas[i] = rand.Next(-100, 100);
            }
           NumFind(mas);
        }
        static void NumFind(int[] mas)
        {
            foreach (var i in mas)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
