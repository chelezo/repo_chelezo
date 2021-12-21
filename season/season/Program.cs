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
            const Season constseaswinter = Season.Winter;
            Console.WriteLine("Введите время года Spring, Summer, Autumn, Winter");
            string EntSeason = Console.ReadLine();
            string trfx = "Summer";
            string trfx2 = "Winter";
            bool seasSpring = (EntSeason == trfx);
            bool seasWinter = (EntSeason == trfx2);
            PrintMessage(Season.Summer);
            switch (SeasonNaber) 
            {
                case Season.Winter:
                    Console.WriteLine($"Декабрь Январь Февраль");
                    break;
                case Season.Summer:
                    Console.WriteLine($"Июнь Июль Август");
                    break;

            }
            
            //string seas = AllSpringMonth;
            //Console.WriteLine($"Введите время года {SeasonSpring}");
            //  if (seasSpring)
            //{
            //  Console.WriteLine($"Месяцы {seasWinter}");
            // }
            // else if (seasWinter)
            // {
            //     Console.WriteLine($"Месяцы {seasWinter}");
            // }

            Console.ReadLine();
        }
    }
}
