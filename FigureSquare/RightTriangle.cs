using System;

namespace FigureSquare
{
    public class RightTriangle : IFigureSquare
    {
        public double Cathetus1 { get; private set;}
        public double Cathetus2 { get; private set;}

        public double Hypotenuse
        {
            get { return Math.Sqrt(Cathetus1 * Cathetus1 + Cathetus2 * Cathetus2); }
        }

        public RightTriangle(double cathetus1, double cathetus2)
        {
            Cathetus1 = cathetus1;
            Cathetus2 = cathetus2;
        }

        public double Square()
        {
            if (Cathetus1 < 0 || Cathetus2 < 0)
            {
                throw new Exception("Одна из сторон меньше 0");
            }

            return Cathetus1 * Cathetus2 / 2;
        }
    }
}