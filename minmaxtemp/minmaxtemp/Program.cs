using System;

namespace minmaxtemp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите минимальную температуру");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальну температуру");
            int max = Convert.ToInt32(Console.ReadLine());
            int summa = ((min + max) / 2);
            Console.WriteLine($"Средняя температура { summa}");
        }

    }
}
