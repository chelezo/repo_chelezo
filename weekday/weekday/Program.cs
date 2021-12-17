using System;

namespace weekday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца!");
            int weekday = Convert.ToInt32(Console.ReadLine());
            int maxnum = 13;
            string day = "";
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
            if (weekday >= maxnum)
            {
                Console.WriteLine("неправильный номер");
                Console.ReadLine();
            }
            else {
                                   
                Console.WriteLine($" Месяц { day}");
                Console.ReadLine();
            }
            // Console.WriteLine($" День недели { day}");
        }
    }
}
