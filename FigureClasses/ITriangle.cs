using System;
using System.Collections.Generic;
using System.Text;

namespace FigureClasses
{
    public interface ITriangle : IFigure
    {
        public double SideOne { get; }
        public double SideSecond { get; }
        public double SideThird { get; }
    }
}
