using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ElnurTask2222
{
    public class Snake
    {
        public int x, y;
        enum Direction
        {
            LEFT,
            RIGHT
        }
        Direction direction;

        public Snake(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            if (keyInfo.Key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
        }

        public void Draw()
        {
            if (direction == Direction.LEFT)
                x--;
            if (x == 0)
                x++;
            if (direction == Direction.RIGHT)
                x++;
            if (x == 17)
                x--;

            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }
    }
    class Program
    {
        static Snake snake;

        static void Main(string[] args)
        {
            snake = new Snake(10, 10);
            Thread thread = new Thread(Move);
            thread.Start();

            while(true)
            {
                snake.Draw();
                Thread.Sleep(200);
            }
        }

        static void Move()
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                snake.Move(keyInfo);
            }
        }
    }
}
