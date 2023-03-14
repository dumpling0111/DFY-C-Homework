using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeFactory
{
    public abstract class Shape
    {
        public abstract double getArea();
        public abstract bool isValid();
        public abstract void printShapeInfo();
    }


}


