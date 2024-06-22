using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShapeClassLibrary.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void CircleAreaTest()
        {
            var circle = new Circle(5);
            Assert.Equal(Math.PI * 25, circle.CalculateArea(), 1e-10); //set the tolerance to be less than 1e-10 to be accepted
        }

        [Fact]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.CalculateArea(), 1e-10);
        }

        [Fact]
        public void RightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void NotRightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.False(triangle.IsRightTriangle());
        }

        [Fact]
        public void ShapeCalculatorTest()
        {
            IShape circle = new Circle(5);
            IShape triangle = new Triangle(3, 4, 5);

            Assert.Equal(Math.PI * 25, CalculateShape.GetArea(circle), 1e-10);
            Assert.Equal(6, CalculateShape.GetArea(triangle), 1e-10);
        }
    }
}
