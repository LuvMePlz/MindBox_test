using System;
using Xunit;
using task2;
using Xunit.Sdk;

namespace task2.tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestNeagtiveFigureSides()
        {
            Figure fig = null;
            Assert.Throws<ArgumentOutOfRangeException>(() => fig = new Circle(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => fig = new Triangle(-1, -1, -1));
        }

        [Fact]
        public void TestCircleGetArea()
        {
            var radius = 1;
            Circle circle = new Circle(radius);
            var area = circle.GetArea();
            Assert.Equal(Math.PI, area);
        }

        [Fact]
        public void TestTriangleGetArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            var area = triangle.GetArea();
            Assert.Equal(6, area);
        }

        [Fact]
        public void TestTriangleIsRight()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            var isRight = triangle.IsRight();
            Assert.True(isRight);
        }
    }
}
