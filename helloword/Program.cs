using System;

namespace helloword
{
    class Program
    {
        static void Main(string[] args)
        {
           String myUserName = Environment.UserName;


            Console.WriteLine($"Добрый День { myUserName} сегодня [" + DateTime.Now + "]");
            string name = Console.ReadLine();
        }
    }
}
