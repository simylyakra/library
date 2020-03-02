using System;

namespace FigureClasses
{
    public class Triangle : Figure
    {
        public double SideOne { get; }
        public double SideSecond { get; }
        public double SideЕThird { get; }

        public bool IsRectangular { get; }

        public Triangle(double side1, double side2, double side3)
        {
            var sides = new double[] { side1, side2, side3 };
            Array.Sort(sides);
            SideOne = sides[0];
            SideSecond = sides[1];
            SideЕThird = sides[2];
            // Pythagorean inverse theorem
            IsRectangular = (SideЕThird * SideЕThird == SideSecond * SideSecond + SideOne * SideOne);
        }
        public override double Area()
        {
            if (IsRectangular)
            {
                return (SideOne * SideSecond) / 2;
            }

            var halfPerimeter = (SideOne + SideSecond + SideЕThird) / 2;
            return Math.Sqrt(
                halfPerimeter * (halfPerimeter - SideOne) * (halfPerimeter - SideSecond) * (halfPerimeter - SideЕThird));
        }
    }
}
