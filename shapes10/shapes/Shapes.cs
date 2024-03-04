using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public abstract class Shape
    {
        public string ShapeItem { get; }
        public double Area { get; }
        public double Perimeter { get; }
        public DateTime TimeStamp { get; }

        public Shape( double area, double perimeter, string theShape)
        {
            Area = area;
            Perimeter = perimeter;
            ShapeItem = theShape;
            TimeStamp = DateTime.Now;
        }

        
    }

    class  RightTri : Shape
    {
        public RightTri(double area, double perimeter):base(area,perimeter,"Right Triangle")
        {
        }
    }

    class Square : Shape
    {
        public Square(double area, double perimeter) :base(area,perimeter,"Square")
        {
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(double area, double perimeter) : base(area, perimeter, "Rectangle")
        {
        }
    }

    class Circle : Shape
    {
        public Circle(double area, double perimeter) : base(area, perimeter, "Circle")
        {
        }
    }
}
