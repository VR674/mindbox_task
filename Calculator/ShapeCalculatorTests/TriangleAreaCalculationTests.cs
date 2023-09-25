using ShapeCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculatorTests
{
    [TestClass]
    public class TriangleAreaCalculationTests
    {
        [TestMethod]
        public void GetArea_AllEdgesArePositive_ReturnCorrect()
        {
            Triangle triangle = new Triangle(2, 3, 4);

            var area = triangle.GetArea();

            Assert.AreEqual(2.904738, Math.Round(area, 6));
        }

        [TestMethod]
        public void GetArea_AllEdgesAreEqual_ReturnCorrect()
        {
            Triangle triangle = new Triangle(1, 1, 1);

            var area = triangle.GetArea();

            Assert.AreEqual(0.433013, Math.Round(area, 6));
        }

        [TestMethod]
        public void GetArea_EdgesMakeDegenerateTriangle_Return0()
        {
            Triangle triangle = new Triangle(1, 2, 3);

            var area = triangle.GetArea();

            Assert.AreEqual(0, area);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Длины сторон не могут иметь отрицательного значения")]
        public void GetArea_EdgeAIsNegative_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(-1, 1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Длины сторон не могут иметь отрицательного значения")]
        public void GetArea_EdgeBIsNegative_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(1, -1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Длины сторон не могут иметь отрицательного значения")]
        public void GetArea_EdgeCIsNegative_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(1, 1, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Треугольника с указанными сторонами не существует")]
        public void GetArea_NonExistingTriangleWithSumOfEdgesCAndBLessThanA_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(10, 1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Треугольника с указанными сторонами не существует")]
        public void GetArea_NonExistingTriangleWithSumOfEdgesCAndALessThanB_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(1, 10, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Треугольника с указанными сторонами не существует")]
        public void GetArea_NonExistingTriangleWithSumOfEdgesBAndALessThanC_ThrowArgumentException()
        {
            Triangle triangle = new Triangle(1, 1, 10);
        }

        [TestMethod]
        public void IsRightTriangle_EdgesMakeRightTriangle_ReturnTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            var isRight = triangle.IsRightTriangle();

            Assert.IsTrue(isRight);
        }

        [TestMethod]
        public void IsRightTriangle_EdgesMakeNotRightTriangle_ReturnTrue()
        {
            Triangle triangle = new Triangle(4, 4, 5);

            var isRight = triangle.IsRightTriangle();

            Assert.IsFalse(isRight);
        }
    }
}
