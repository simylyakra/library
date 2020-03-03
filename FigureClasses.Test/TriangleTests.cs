using NUnit.Framework;
using System;

namespace FigureClasses.Test
{
    [TestFixture]
    public class TriangleTests
    {
        private ITriangle _triangle;
        private RectangularTriangle _rectTriangle;

        [SetUp]
        public void Init()
        {
            _triangle = Triangle.CreateTriangle(4, 2, 3);
            //_rectTriangle = (RectangularTriangle)RectangularTriangle.CreateTriangle(15, 12, 9);
        }

        [Test]
        public void TriangleCreatedCorrect()
        {
            Assert.That(_triangle, Is.Not.Null, "Tringle created");
            Assert.That(_triangle.GetType(), Is.EqualTo(typeof(Triangle)), "Tringle created");
            Assert.That(_triangle.SideOne, Is.EqualTo(4), "Triangle.SideOne");
            Assert.That(_triangle.SideSecond, Is.EqualTo(2), "Triangle.SideSecond");
            Assert.That(_triangle.SideThird, Is.EqualTo(2), "Triangle.SideThird");
        }

        [Test]
        public void AreaTest()
        {
            Assert.That(Math.Round(_triangle.Area(), 5), Is.EqualTo(2.90474), "Triangle.Area");
        }
    }
}
