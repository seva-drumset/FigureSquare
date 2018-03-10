using System;

namespace FigureSquare
{
    public class Circle : IFigureSquare
    {
        private double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Square()
        {
            if (Radius < 0)
            {
                throw new Exception("Радиус меньше 0");
            }
            
            return Radius * Radius * Math.PI;
        }
    }
}