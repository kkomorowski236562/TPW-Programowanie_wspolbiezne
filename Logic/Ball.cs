using System;

namespace Logic
{
    internal class Ball
    {
        private readonly int size;
        private int x;
        private int y;
        private int new_x;
        private int new_y;

        public Ball(int size, int x, int y, int new_x, int new_y)
        {
            this.size = size;
            this.x = x;
            this.y = y;
            this.new_x = new_x;
            this.new_y = new_y;
        }
        public int Size { get => size; }
        public int X { get => x; }
        public int Y { get => y; }

        public void position(int lenght, int width)
        {
            if (x + new_x >= 0 && x + new_x <= lenght - size)
            {
                x += new_x;
            }
            else
            {
                if (new_x > 0)
                {
                    x = lenght - size;
                }
                else
                {
                    x = 0;
                }
                new_x *= -1;
            }

            if (y + new_y >= 0 && y + new_y <= width - size)
            {
                y += new_y;
            }
            else
            {
                if (new_y > 0)
                {
                    y = width - size;
                }
                else
                {
                    y = 0;
                }
                new_y *= -1;
            }
        }
    }
}
