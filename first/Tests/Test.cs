using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;;

namespace MindBoxLib.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Square12ShouldReturn4524()
        {
            // Arrange
            Circle circle = new Circle("Circle", 67);
            double expected = 14102.6;

            // Act
            double result = circle.CalcSquare();

            // Assert
            Assert.AreEqual(expected, result);
        }
        public void RadiusIsNegativeShouldReturnFalse()
        {
            // Arrange 
            Circle circle = new Circle("Circle", -67);
            
            // Assert
            Assert.Throws<ArgumentException>(() => new Circle(0, 0, -3));
        }
    }

    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void Square5912Return204()
        {
            // Arrange
            Triangle triangle = new Triangle("Triangle", 5, 9, 12);
            double expected = 20.4;

            // Act
            double result = triangle.CalcSquare();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void isRectangleIsFalseReturnFalse()
        {
            // Arrange
            var triangle = new Triangle("Triangle", 5, 7, 8);

            // Act
            var result = triangle.IsRectangular();

            // Assert
            Assert.IsFalse(result);
        }
    }
}
