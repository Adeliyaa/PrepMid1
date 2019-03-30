using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace elnurTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(Move);
          
            thread.Start();
           
            

        }

        static void Move()
        {
            while(true)
            {
                Console.SetCursorPosition(10, 10);
                Console.WriteLine('#');
                for (int i = 10; i < 21; i++)
                {

                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(i, 10);
                    Console.WriteLine('#');
                    Thread.Sleep(250);
                }

                Console.Clear();

                for (int i = 21; i > 10; i--)
                {

                    Console.Clear();
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(i, 10);
                    Console.WriteLine('#');
                    Thread.Sleep(250);
                }


            }

            
        }

       
    }
}
