using System;

namespace helloword
{
    class Program
    {
        static void Main(string[] args)
        {
           String myUserName = Environment.UserName;

            Console.WriteLine($"Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Добрый День { name} ваша учетная запись ПК '{ myUserName}' сегодня  [" + DateTime.Now + "]");
            Console.ReadLine();

        }
    }
}
