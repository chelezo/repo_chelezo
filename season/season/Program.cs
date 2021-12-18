using System;

namespace season
{
    class Program
    {
        [Flags]
        public enum season 
            {
            
        }
        public  enum Spring
        {
            March,
            April,
            May
        }
        public enum Summer
        {
            June,
            July,
            August
        }
        public enum Autumn
        {
            September,
            October,
            November
        }
        public enum Winter
        {
            December,
            January,
            February
        }

        static void Main(string[] args)
        {
            
            Spring  SeasonSpring = (Spring.April | Spring.March | Spring.May) ;
           Spring AllSpringMonth = (Spring)0b000111;
            
            Console.WriteLine("Введите время года Spring, Summer, Autumn, Winter");
             string EntSeason = Console.ReadLine();
            string trfx = "Spring";
             bool seasSpring = (EntSeason == trfx);

            //string seas = AllSpringMonth;
           // Console.WriteLine($"Введите время года {SeasonSpring}");
         if (seasSpring)
            {
              Console.WriteLine($"Введите время года {AllSpringMonth}");
            }
            else
           {
             Console.WriteLine("Введите время года lheujt");
            }
            
            
        }
    }
}
