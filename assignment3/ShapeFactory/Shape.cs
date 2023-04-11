using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactory
{
    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle()
        {
            width = 2;
            height = 1;
        }
        override public bool isValid()
        {
            return width > 0 && height > 0;
        }

        override public double getArea()
        {
            if (!isValid()) { throw new InvalidOperationException("该形状无效！"); }
            return width * height;
        }

        override public void printShapeInfo()
        {
            Console.WriteLine("生成了一个长方形");
        }
    }
    public class Square : Rectangle
    {
        private int side;
        public Square(int side) : base(side, side)
        { }

        public Square()
        {
            side = 1;
        }
        override public void printShapeInfo()
        {
            Console.WriteLine("生成了一个正方形");
        }
    }
    public class Triangle : Shape
    {
        private int a;
        private int b;
        private int c;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Triangle()
        {
            a = 1;
            b = 1;
            c = 1;
        }
        override public bool isValid()
        {
            return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
        }

        override public double getArea()
        {
            if (!isValid()) { throw new InvalidOperationException("该形状无效！"); }
            //用海伦公式求面积
            double p = (double)(a + b + c) / 2;
            double S2 = Math.Round(p * (p - a) * (p - b) * (p - c), 3);
            double S = Math.Round(Math.Sqrt(S2), 3);
            return S;
        }

        override public void printShapeInfo()
        {
            Console.WriteLine("生成了一个三角形");
        }
    }
}


