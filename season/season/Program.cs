using System;

namespace season
{
    class Program
    {
        [Flags]
       
        public  enum Season
        {
            Spring,
            Summer,
            Autum,
            Winter
        }
       

        static void Main(string[] args)
        {
            //int intSpring = (int)Spring.April;
            Season SeasonNaber = Season.Winter | Season.Summer | Season.Autum | Season.Spring;
            Console.WriteLine("Введите время года Spring, Summer, Autumn, Winter"); 
            string EntSeason = Console.ReadLine();
            string trfx = "Spring";
            string trfx2 = "Winter";
            bool seasSpring = (EntSeason == trfx);
            bool seasWinter = (EntSeason == trfx2);

            switch (EntSeason) 
            {
                case Winter:
                    Console.WriteLine("Добрый день");

            }

            //string seas = AllSpringMonth;
            //Console.WriteLine($"Введите время года {SeasonSpring}");
            if (seasSpring)
            {
              Console.WriteLine($"Месяцы {SeasonSpring}");
            }
            else if (seasWinter)
            {
                Console.WriteLine($"Месяцы {seasWinter}");
            }

            Console.ReadLine();
        }
    }
}
