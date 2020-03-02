using Xunit;
using System;

namespace FigureClasses.Test
{
    public class CircleTests
    {
        [Fact]
        public void AreaTest()
        {
            var circle = new Circle(1);
            Assert.Equal(circle.Area(), Math.PI);
        }
    }
}
