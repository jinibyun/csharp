using System;
using System.Collections.Generic;
using System.Text;

namespace newVersionCSharp._7._0
{
    public class isPatternMaching : TestMain
    {
        object[] data = { 1, null, 10, new Circle(5), new Person("Lee"), "" };
        List<int> vip = new List<int> { 1, 3, 5, 9 };
        List<int> active = new List<int> { 10, 13, 15, 19 };
        List<int> blacklist = new List<int> { 7, 14, 12, 133 };
        // old
        // is operator is only used to check type of object

        // new
        // is operator is also used to for pattern maching
        // 1. const pattern
        // 2. type pattern
        // 3. var pattern

        public override void Test()
        {
            base.Test();
            constPattern();
            typePattern();

            List<Shape> shapes = new List<Shape>
            {
                null,
                new Circle(2),
                new Rect(3,3),
                new Rect(7,3),
                new Shape()
            };
            patternMatchingWithSwitch(shapes);

            varPattern(1);
            varPattern(15);
            varPattern(12);
            varPattern(11111);
        }

        private void constPattern()
        {
            Console.WriteLine("> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            // old: use ==
            foreach (var item in data)
            {
                if (item is null)   // const pattern
                {
                    Console.WriteLine("null found");
                }
                else if (item is 10)  // const pattern
                {
                    Console.WriteLine("10 found");
                }
            }
        }

        private void typePattern()
        {
            Console.WriteLine("> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            // similar to old. but it also supports that if it is type, then automatic casting will be done.
            foreach (object item in data)
            {
                if (item is Circle circ)  // type pattern
                {
                    Console.WriteLine(circ.Radius);
                }
            }
        }
        
        private void patternMatchingWithSwitch(List<Shape> shapes)
        {
            Console.WriteLine("> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            // old: swith statement can only be used with primitive type
            // new: swith statement can be used with pattern matching (it means "any" type)

            foreach (var shape in shapes)
            {
                switch (shape)
                {
                    // const pattern
                    case null:
                        Console.WriteLine("Skip because it is null");
                        break;

                    // type pattern
                    case Circle c:
                        Console.WriteLine($"circle: {c.Radius * c.Radius * Math.PI}");
                        break;
                    case Rect r when r.Width == r.Height:
                        Console.WriteLine($"square: {r.Width * r.Width}");
                        break;
                    case Rect r2:
                        Console.WriteLine($"rectangle: {r2.Width * r2.Height}");
                        break;
                    default:
                        Console.WriteLine("unknown shape");
                        break;
                }
            }
        }

        // varPattern is same as typePattern
        private void varPattern(int id)
        {
            Console.WriteLine("> " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            switch (id)
            {
                // var actually automaticall casted into _id or whatever name after var keyword
                case var _id when (vip.Contains(_id)):
                    Console.WriteLine("VIP");                    
                    break;
                case var _id when (active.Contains(_id)):
                    Console.WriteLine("Active");
                    break;
                case var _id when (blacklist.Contains(_id)):
                    Console.WriteLine("Black List");
                    break;
                default:
                    Console.WriteLine("Normal");
                    break;
            }
        }        
    }

    public class Shape { }
    public class Circle : Shape
    {
        public double Radius = 7D;
        public Circle(int i)
        {

        }
    }

    public class Rect : Shape
    {
        public Rect(int w, int h)
        {
            this.Width = w;
            this.Height = h;
        }
        public int Width;
        public int Height;
    }

    public class Person
    {
        public Person(string name)
        {

        }
    }
}
