using System;


namespace IrinaBlahunZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[42];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(-100, 100);
            {
                foreach (var i in array)
                {
                    if (i % 3 == 0)
                    Console.WriteLine(i);
                }
            }

        }

    }
}
