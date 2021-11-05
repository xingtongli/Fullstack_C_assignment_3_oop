using System;

namespace oop2
{
    class Color
    {
        private int red;
        private int green;
        private int blue;
        private byte alpha;
        public int Red
        {
            get
            {
                return red;
            }
            set
            {
                red = value;
            }
        }
        public int Green
        {
            get
            {
                return green;
            }
            set
            {
                green = value;
            }
        }
        public int Blue
        {
            get
            {
                return blue;
            }
            set
            {
                blue = value;
            }
        }
        public byte Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = value;
            }
        }
        public Color() { }
        public Color(int red, int green, int blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }
        
        public int grayscale()
        {
            return (this.red + this.green + this.blue) / 3;
        }
    }

    class Ball : Color
    {
        private int size;
        private int count = 0;
        public Ball(int red, int green,int blue,byte alpha,int size, int count)
        {
            this.size = size;
            this.count = count;
        }
        public Ball(int red, int green, int blue, int size, int count)
        {
            this.size = size;
            this.count = count;
        }
        public Ball(int red, int green, int blue, int size)
        {
            this.size = size;
            this.count = 0;
        }
        public int Pop()
        {
            this.size = 0;
            return this.size;
        }
        public void Thrown()
        {
            if (this.size != 0)
            {
                this.count++;
            }
        }
        public int getcount()
        {
            return this.count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ball b1 = new Ball(13, 22, 23, 34);
            Ball b2 = new Ball(42, 23, 23, 23, 23, 0);
            Ball b3 = new Ball(53, 53, 68, 42);
            Ball b4 = new Ball(42, 56, 34, 74);

            for(int i=0; i < 5; i++)
            {
                b1.Thrown();
                b2.Thrown();
                b3.Thrown();
                b4.Thrown();
            }

            b2.Pop();
            b4.Pop();

            b1.Thrown();
            b2.Thrown();
            b3.Thrown();
            b4.Thrown();

            b1.Thrown();
            b2.Thrown();
            Console.WriteLine(b1.getcount());
            Console.WriteLine(b2.getcount());
            Console.WriteLine(b3.getcount());
            Console.WriteLine(b4.getcount());

        }
    }
}
