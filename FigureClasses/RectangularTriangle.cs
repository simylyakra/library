using System;
using System.Collections.Generic;
using System.Text;

namespace FigureClasses
{
    public class RectangularTriangle : ITriangle
    {
        public double SideOne { get; }

        public double SideSecond { get; }

        public double SideThird { get; }

        public double Area() => (SideOne * SideSecond) / 2;

        private RectangularTriangle(double side1, double side2, double side3)
        {
            // cathet
            SideOne = side1;
            // cathet
            SideSecond = side2;
            // hypotenuse
            SideThird = side3;
        }

        public static ITriangle CreateTriangle(double side1, double side2, double side3)
        {
            var sides = new double[] { side1, side2, side3 };
            Array.Sort(sides);
            // Pythagorean inverse theorem
            if (sides[2] * sides[2] != sides[1] * sides[1] + sides[0] * sides[0])
            {
                return null;
            }
            return new RectangularTriangle(sides[0], sides[1], sides[3]);
        }
    }
}
