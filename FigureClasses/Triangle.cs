using System;

namespace FigureClasses
{
    public class Triangle : ITriangle
    {
        public double SideOne { get; }

        public double SideSecond { get; }

        public double SideThird { get; }

        private Triangle(double side1, double side2, double side3)
        {
            SideOne = side1;
            SideSecond = side2;
            SideThird = side3;
        }
        public double Area()
        {
            var halfPerimeter = (SideOne + SideSecond + SideThird) / 2;
            return Math.Sqrt(
                halfPerimeter * (halfPerimeter - SideOne) * (halfPerimeter - SideSecond) * (halfPerimeter - SideThird));
        }

        public static ITriangle CreateTriangle(double side1, double side2, double side3)
        {
            var triangle = RectangularTriangle.CreateTriangle(side1, side2, side3) 
                ?? new Triangle(side1, side2, side3);
            return triangle;
        }
    }
}
