using System;

namespace weekday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день недели!");
            int weekday = Convert.ToInt32(Console.ReadLine());
            int maxnum = 8;
            string day = "";
            switch (weekday)
            {
                case 1:
                    day = "Понедельник";
                    break;
                case 2:
                    day = "Вторник";
                    break;
                case 3:
                    day = "Среда";
                    break;
                case 4:
                    day = "Четверг";
                    break;
                case 5:
                    day = "Тяпница";
                    break;
                case 6:
                    day = "субота";
                    break;
                case 7:
                    day = "Воскресенье и завтра на работу";
                    break;

            }
            if (weekday >= maxnum)
            {
                Console.WriteLine("неправильный день недели");
                Console.ReadLine();
            }
            else {
                                   
                Console.WriteLine($" День недели { day}");
                Console.ReadLine();
            }
            // Console.WriteLine($" День недели { day}");
        }
    }
}
