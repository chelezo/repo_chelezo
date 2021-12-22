using System;

namespace spravochnik
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arraySpravochnik = new string [3]{ "Петров","Иванов","Киркоров"};
           //Console.WriteLine(arraySpravochnik.Length);

            Console.WriteLine("Введите фамилию (Петров Иванов Киркоров)");
            string enterFamily = Console.ReadLine();
            bool Found = false;

            for (int i=0; i < arraySpravochnik.Length; i++)
                
            {
                //int Spravochnik = (i++);

                if (arraySpravochnik[i] == enterFamily)
                {
                    Console.WriteLine($" Житель  {arraySpravochnik[i]} найден ");
                    switch (i)
                    {
                        case 0:
                            Console.WriteLine("Номер телефона 096553221 Емейл ree@gmail.com");
                            break;
                        case 1:
                            Console.WriteLine("Номер телефона 053213228 Емейл buu@gmail.com");
                            break;
                        case 2:
                            Console.WriteLine("Номер телефона 053563333 Емейл ololo@gmail.com");
                            break;
                    }
                    
                        
                        Found = true;
                                      
                    
                }
                
               
            }
            if (!Found)
            {
                Console.WriteLine("Такой фамилии нет :(");
                return;
            }
        }
    }
}
