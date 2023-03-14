using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
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
            if (width > 0 && height > 0) { return true; }
            return false;
        }

        override public double getArea()
        {
            return width * height;
        }

        override public void printShapeInfo()
        {
            Console.WriteLine("这是一个长方形");
            Console.WriteLine($"长为{height}，宽为{width}");
            bool v =this.isValid();
            //有效
            if (v)
            {
                Console.WriteLine("该长方形有效");
                double area = this.getArea();
                Console.WriteLine($"面积为{area}");
            }
            else
            {
                Console.WriteLine("该长方形无效");
            }
        }
    }
    public class Square : Rectangle
    {
        private int side;
        public Square(int side) : base(side, side)
        { this.side = side; }

        public Square()
        {
            side = 1;
        }
        override public void printShapeInfo()
        {
            Console.WriteLine("这是一个正方形");
            Console.WriteLine($"边长为{side}");
            bool v = this.isValid();
            //有效
            if (v)
            {
                Console.WriteLine("该正方形有效");
                double area = this.getArea();
                Console.WriteLine($"面积为{area}");
            }
            else
            {
                Console.WriteLine("该正方形无效");
            }
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
            if (a <= 0 || b <= 0 || c <= 0) return false;
            if (a + b > c && a + c > b && b + c > a) return true;
            return false;
        }

        override public double getArea()
        {
            //用海伦公式求面积
            double p = (double)(a + b + c) / 2;
            double S2 = Math.Round(p * (p - a) * (p - b) * (p - c), 3);
            double S = Math.Round(Math.Sqrt(S2), 3);
            return S;
        }

        override public void printShapeInfo()
        {
            Console.WriteLine("这是一个三角形");
            Console.WriteLine($"边长分别为{a},{b},{c}");
            bool v = this.isValid();
            //有效
            if (v)
            {
                Console.WriteLine("该三角形有效");
                double area = this.getArea();
                Console.WriteLine($"面积为{area}");
            }
            else
            {
                Console.WriteLine("该三角形无效");
            }
        }
    }
}


