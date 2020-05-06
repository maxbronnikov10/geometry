using System;

namespace Geometry
{
    public class Segment
    {
        public readonly Point A, B;

        public Segment(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
    }
}
