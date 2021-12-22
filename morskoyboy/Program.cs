using System;

namespace morskoyboy
{
    class Program
    {
        static void Main(string[] args)
        {
            char [,] arrayMB = { { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' }, 
                                 { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                 { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                 { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                 { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                 { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                 { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                 { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                 { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' },
                                 { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' },
            };
            //char at= Convert.ToChar(arrayMB[4, 2]);
           //arrayMB[4, 2] = "X";
           // arrayMB[4, 3] = Convert.ToChar('U+0058');
            //arrayMB[0, 1] = Convert.ToChar('X');
            arrayMB[0, 2] = 'X';
            arrayMB[0, 3] = 'X';
            arrayMB[0, 4] = 'X';
            arrayMB[0, 5] = 'X';
            arrayMB[4, 6] = 'X';
            arrayMB[4, 5] = 'X';

            //switch (arrayMB)
            //{
            //    case at:
            //            break;

            //}
           for (int a = 0; a < arrayMB.GetLength(0); a++)
           {
              for (int b = 0; b < arrayMB.GetLength(1); b++)
           //int MB = arrayMB[a]; 
              {
                    Console.Write($"{arrayMB[a,b]} ");
            }
                Console.WriteLine();
            }

            //Console.WriteLine();
            //Console.WriteLine("Hello World!");

        }
    }
}
