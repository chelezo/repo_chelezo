using System;

namespace minmaxtemp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите минимальную температуру");
            double min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальну температуру");
            double max = Convert.ToInt32(Console.ReadLine());
            double summa = ((min + max) / 2);
            Console.WriteLine($"Средняя температура { summa}");
        }

    }
}
