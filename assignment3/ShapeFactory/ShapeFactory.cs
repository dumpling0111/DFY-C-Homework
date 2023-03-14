using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactory
{
    public class ShapeFactory
    {
        public static void Main(string[] args)
        {
            int num = 10;
            double area;
            double totalArea = 0;
            Console.WriteLine("随机生成10个图形：");
            for (int i = 0; i < num; i++)
            {
                Shape shape = createShape();
                shape.printShapeInfo();
                area = shape.getArea();
                Console.WriteLine($"该图形面积为:{area}");
                totalArea += area;
            }
            totalArea = Math.Round(totalArea, 3);
            Console.WriteLine($"总面积为:{totalArea}");
        }

        public static Shape createShape()
        {
            Shape shape = new Square(0);
            //生成随机数，用于随机生成图形
            Random rd1 = new Random();
            int i = rd1.Next(0, 3);
            bool k = !shape.isValid();

            //如果图形无效则重新生成
            do
            {
                //生成随机数，用于随机生成边长
                Random rd2 = new Random();

                switch (i)
                {
                    //长方形
                    case 0:
                        {
                            int width = rd2.Next(1, 5);
                            int length = rd2.Next(1, 5);
                            shape = new Rectangle(width, length);
                            break;
                        }
                    //正方形
                    case 1:
                        {
                            int side = rd2.Next(1, 5);
                            shape = new Square(side);
                            break;
                        }
                    //三角形
                    default:
                        {
                            int a = rd2.Next(1, 5);
                            int b = rd2.Next(1, 5);
                            int c = rd2.Next(1, 5);
                            shape = new Triangle(a, b, c);
                            break;

                        }

                }
                k = shape.isValid();
            } while (!k);
            return shape;

        }
    }

}
