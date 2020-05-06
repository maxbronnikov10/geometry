using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Triangle : IShape
    {
        public readonly Point A,B,C;
        private readonly Segment AB, AC, BC;

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
            AB = new Segment(a, b);
            AC = new Segment(a, c);
            BC = new Segment(b, c);
        }

        public double GetSquare()
        {
            return GetSquareByGeron(AB.GetLength(), AC.GetLength(), BC.GetLength());
        }

        private double GetSquareByGeron(double ab, double ac, double bc) // Вычисление площади через формулу Герона 
        {
            double p = (ab + ac + bc) / 2;
            return Math.Sqrt(p * (p - ab) * (p - ac) * (p - bc));
        }

        public bool IsRight()
        {
            // Вычисление квадратов отрезков
            double abSquare = Math.Pow(AB.GetLength(),2);
            double acSquare = Math.Pow(AC.GetLength(), 2);
            double bcSquare = Math.Pow(BC.GetLength(), 2);

            return (abSquare.ApproximateCompareTo(acSquare + bcSquare,0.2)) || (acSquare.ApproximateCompareTo(abSquare + bcSquare, 0.2)) || (bcSquare.ApproximateCompareTo(acSquare + abSquare, 0.2));
        }
        
    }
}
