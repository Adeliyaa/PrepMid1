using System;
using System.Threading;
using System.IO;

namespace Threading8
{
    class Program
    {
        static void Main(string[] args)
        {
            gun();
            Thread thread = new Thread(Move);
            thread.Start();

        }
        static void Move()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.SetCursorPosition(5, 0);
                for (int i = 5; i < 20; i++)
                {
                    //Console.CursorVisible = false;
                    Console.Clear();
                    gun();
                    Console.SetCursorPosition(i, 0);

                    Console.Write("0");
                    Thread.Sleep(100);
                }
            }



        }
        public static void gun()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("#");
            }

            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("#");
            }

            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("#");
            }
        }
    }
}
