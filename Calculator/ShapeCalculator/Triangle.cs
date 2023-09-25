using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Triangle : IShape
    {
        public double EdgeA { get; private set; }
        public double EdgeB { get; private set; }
        public double EdgeC { get; private set; }

        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if (edgeA < 0 || edgeB < 0 || edgeC < 0)
                throw new ArgumentException("Длины сторон не могут иметь отрицательного значения");

            IsExist(edgeA, edgeB, edgeC);

            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;
        }

        public double GetArea()
        {
            // Площадь находится по формуле Герона
            var p = (EdgeA + EdgeB + EdgeC) / 2;
            var area = Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC));
            
            return area;
        }

        public bool IsRightTriangle()
        {
            // Является ли треугольник прямоугольным проверяем по теореме Пифагора
            return Math.Pow(EdgeA, 2) == Math.Pow(EdgeB, 2) + Math.Pow(EdgeC, 2) ||
                    Math.Pow(EdgeB, 2) == Math.Pow(EdgeA, 2) + Math.Pow(EdgeC, 2) ||
                    Math.Pow(EdgeC, 2) == Math.Pow(EdgeA, 2) + Math.Pow(EdgeB, 2);
        }

        private void IsExist(double a, double b, double c)
        {
            // Сумма длин двух любых сторон должна быть больше длины третьей стороны,
            // Также принимаем вырожденные треугольники (с одним углом = 180)
            if (a + b < c || a + c < b || b + c < a)
                throw new ArgumentException("Треугольника с указанными сторонами не существует");
        }
    }
}
