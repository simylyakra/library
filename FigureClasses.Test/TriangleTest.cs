using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FigureClasses.Test
{
    public class TriangleTest
    {
        [Fact]
        public void AreaTest()
        {
            var triangle = new Triangle(2, 3, 4);
            Assert.Equal(2.90474, Math.Round(triangle.Area(), 5));
        }
    }
}
