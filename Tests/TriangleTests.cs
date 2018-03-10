using System;
using FigureSquare;
using Xunit;

namespace Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3.0, 4.0, 6.0)]
        [InlineData(2.0, 5.0, 5.0)]
        [InlineData(4.0, 6.0, 12.0)]
        public void CalculateSquare(double cathetus1, double cathetus2, double expectedSquare)
        {
            var triangle = new RightTriangle(cathetus1, cathetus2);

            var square = triangle.Square();

            Assert.Equal(expectedSquare, square);
        }

        [Theory]
        [InlineData(-1.0, 1.0)]
        [InlineData(1.0, -1.0)]
        public void WhenSideIsLessThanZero_ThrowException(double cathetus1, double cathetus2)
        {
            var triangle = new RightTriangle(cathetus1, cathetus2);

            Assert.Throws<Exception>(() => triangle.Square());            
        }
    }
}