using System;

namespace Exercise3//Лабораторная работа по Мищенко №5(задание 3)
{
    class Program
    {
        static void Main(string[] args)
        {
            Check();
        }

        public class Vector
        {
            private double x;
            public double X { set => x = value; get => x; }
            private double y;
            public double Y { set => y = value; get => y; }
            public double Length { get => Math.Sqrt(x * x + y * y); }

            public Vector(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }
            public override string ToString()
            {
                return string.Format("({0}, {1}) with length: {2}", X, Y, Length);
            }
        }
        public static void Check()
        {
            Vector vector = new Vector(3, 4);
            Console.WriteLine(vector.ToString());
            vector.X = 0;
            vector.Y = -1;
            Console.WriteLine(vector.ToString());
            vector = new Vector(9, 40);
            Console.WriteLine(vector.ToString());
            Console.WriteLine(new Vector(0, 0).ToString());
        }
    }
}

