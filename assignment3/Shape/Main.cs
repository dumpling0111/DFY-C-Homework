using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class main
    {
        public static void Main(string[] args)
        {
            Shape r1 = new Rectangle(2, 3);
            Shape r2 = new Rectangle(-2, 3);
            Shape s1 = new Square(2);
            Shape s2 = new Square(-2);
            Shape t1 = new Triangle(2, 2, 3);
            Shape t2 = new Triangle(1, 2, 3);
            r1.printShapeInfo();
            r2.printShapeInfo();
            s1.printShapeInfo();
            s2.printShapeInfo();
            t1.printShapeInfo();
            t2.printShapeInfo();
        }
    }
}
