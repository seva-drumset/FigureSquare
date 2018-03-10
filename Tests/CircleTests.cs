using System;
using FigureSquare;
using Xunit;

namespace Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(1.0, Math.PI)]
        [InlineData(2.0, 4.0 * Math.PI)]
        [InlineData(3.0, 9.0 * Math.PI)]
        public void CircleSquare(double radius, double expectedSquare)
        {
            var circle = new Circle(radius);

            var square = circle.Square();

            Assert.Equal(expectedSquare, square);
        }
        
        [Fact]
        public void WhenRadiusIsLessThanZero_ThrowException()
        {
            var circle = new Circle(-1.0);

            Assert.Throws<Exception>(() => circle.Square());            
        }
    }
}