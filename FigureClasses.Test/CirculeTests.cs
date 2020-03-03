using NUnit.Framework;
using System;

namespace FigureClasses.Test
{
    [TestFixture]
    public class CirculeTests
    {
        [Test]
        public void AreaTeat()
        {
            var circle = new Circle(1);
            Assert.That(circle.Area(), Is.EqualTo(Math.PI), "Circle.Area");
        }

        [Test]
        public void RadiusTeat()
        {
            var circle = new Circle(1);
            Assert.That(circle.Radius, Is.EqualTo(1), "Circle.Radius");
        }
    }
}