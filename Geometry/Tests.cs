using System;
using NUnit.Framework;

namespace Geometry
{
    [TestFixture]
    public class Tests
    {
      
        [TestCase(4, 5, 8,8,5)]
        [TestCase(0, 0, 10, 0, 10)]
        public void SegmentTest(double a, double b, double c, double d, double expectedResult)
        {
            Assert.AreEqual(expectedResult, new Segment(new Point(a,b), new Point(c, d)).GetLength());
        }

        [Test]
        public void IsRightTest()
        {
            Triangle triangle = new Triangle(new Point(0,0), new Point(0,12), new Point(12.5, 0));
            Assert.AreEqual(true, triangle.IsRight());
        }

        [Test]
        public void TriangleSquareTest()
        {
            Triangle triangle = new Triangle(new Point(0,0), new Point(8,7), new Point(11,0));
            Assert.AreEqual(38.5, triangle.GetSquare());
        }
        [Test]
        public void CircleSquareTest()
        {
            Circle circle = new Circle(new Point(0, 0), 5);
            Assert.AreEqual(78.53, circle.GetSquare(), 0.2);
        }
    }
}
