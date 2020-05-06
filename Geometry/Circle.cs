using System;

namespace Geometry
{
    public class Circle : IShape
    {
        public readonly Point O;
        public readonly double R;

        public Circle(Point o, double r)
        {
            O = o;
            R = r;
        }

        public Circle(Point o, Point b) : this(o, new Segment(o, b).GetLength()) { } // Точка b должна находится на окружности

        public double GetSquare()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
