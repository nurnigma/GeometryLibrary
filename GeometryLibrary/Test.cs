using NUnit.Framework;
using GeometryLibrary;
using System;

namespace GeometryLibrary.Tests
{
    [TestFixture]
    public class GeometryLibraryTests
    {
        [Test]
        public void Circle_GetArea_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);

            // Act
            double area = circle.GetArea();

            // Assert
            Assert.AreEqual(Math.PI * radius * radius, area);
        }

        [Test]
        public void Triangle_GetArea_ReturnsCorrectArea()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            double area = triangle.GetArea();

            // Assert
            Assert.AreEqual(6, area);
        }

        [Test]
        public void Triangle_IsRightAngled_ReturnsTrueForRightAngledTriangle()
        {
            // Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsTrue(isRightAngled);
        }

        [Test]
        public void Triangle_IsRightAngled_ReturnsFalseForNonRightAngledTriangle()
        {
            // Arrange
            double side1 = 2;
            double side2 = 3;
            double side3 = 4;
            Triangle triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsFalse(isRightAngled);
        }
    }
}
