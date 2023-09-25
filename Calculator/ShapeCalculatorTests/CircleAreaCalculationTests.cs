using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeCalculator;

namespace ShapeCalculatorTests
{
    [TestClass]
    public class CircleAreaCalculationTests
    {
        [TestMethod]
        public void GetArea_RadiusIsGreaterThan1_ReturnCorrect()
        {
            Circle circle = new Circle(10);

            var area = circle.GetArea();

            Assert.AreEqual(314.159265, Math.Round(area, 6));
        }

        [TestMethod]
        public void GetArea_RadiusIsEqual1_ReturnCorrect()
        {
            Circle circle = new Circle(1);

            var area = circle.GetArea();

            Assert.AreEqual(3.141593, Math.Round(area, 6));
        }

        [TestMethod]
        public void GetArea_RadiusIsEqual0_Return0()
        {
            Circle circle = new Circle(0);

            var area = circle.GetArea();

            Assert.AreEqual(0, area);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetArea_RadiusIsNegativeInConstructor_ThrowArgumentException()
        {
            Circle circle = new Circle(-42);
        }
    }
}