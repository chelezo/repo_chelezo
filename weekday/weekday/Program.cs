using System;

namespace weekday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите температуру");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите порядковый номер месяца!");
            int weekday = Convert.ToInt32(Console.ReadLine());          
            int maxnum = 12;
            string day = "";
            string vremyagoda = "";
            switch (weekday)
            {
                case 1:
                    day = "Яанварь";
                    break;
                case 2:
                    day = "Февраль";
                    break;
                case 3:
                    day = "Март";
                    break;
                case 4:
                    day = "Апрель";
                    break;
                case 5:
                    day = "Май";
                    break;
                case 6:
                    day = "Июнь";
                    break;
                case 7:
                    day = "Июль";
                    break;
                case 8:
                    day = "Август";
                    break;
                case 9:
                    day = "Сентябрь";
                    break;
                case 10:
                    day = "Октябрь";
                    break;
                case 11:
                    day = "Ноябрь";
                    break;
                case 12:
                    day = "Декабрь";
                    break;
                

            }
            switch (weekday)
            {
                case 1:
                case 2:
                case 12:
                    vremyagoda = "Зима";
                    break;
                case 3:                   
                case 4:
                case 5:
                    vremyagoda = "Весна";
                    break;
                case 6:
                case 7:
                case 8:
                    vremyagoda = "Лето";
                    break;
                case 9:
                case 10:
                case 11:
                    vremyagoda = "Осень";
                    break;


            }
            if
                (weekday > maxnum)
            {

                Console.WriteLine("неправильный номер");
                Console.ReadLine();
            }
            else if (temp > 0)
            {
                Console.WriteLine($"На улице тепло, время года {vremyagoda}, а месяц { day}");
                Console.ReadLine();
            }
            else if (temp < 0)
            {
                Console.WriteLine($"На улице холодно, время года {vremyagoda}, а месяц { day}");
                Console.ReadLine();
            }   
            
          
        }
    }
}
