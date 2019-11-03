using System;
using System.Collections.Generic;
using System.Text;

namespace newVersionCSharp._6._0
{
    public class expressionBodiedMember: TestMain
    {
        private const int X = 12;
        private const int Y = 99;
        private int Height = 34;
        private int Width = 18;
        // old
        //public int Area
        //{
        //    get
        //    {
        //        return Height * Width;
        //    }
        //}

        // new
        public int Area => Height * Width;

        public override void Test()
        {
            base.Test();
            Console.WriteLine(this.Area);

            Console.WriteLine(this.Move(2, 4).ToString());

            this.Print();
        }

        // old
        //public Point Move(int x, int y)
        //{
        //    return new Point(x + X, y + Y);
        //}

        // new
        // define method body as lambda expression
        public Point Move(int x, int y) => new Point(x + X, y + Y);

        public void Print() => Console.WriteLine("void method is also defined with lambda expression");

    }

    public class Point
    {
        private int sum;
        public Point(int a, int b)
        {
            sum = a + b;
        }
        public override string ToString()
        {
            return "sum: " + sum.ToString();
        }
    }
}
