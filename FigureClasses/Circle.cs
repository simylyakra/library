using System;

namespace FigureClasses
{
    public class Circle : Figure
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area() => Math.PI * Radius * Radius;
    }
}
