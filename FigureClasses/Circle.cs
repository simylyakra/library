using System;

namespace FigureClasses
{
    public class Circle : IFigure
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area() => Math.PI * Radius * Radius;
    }
}
