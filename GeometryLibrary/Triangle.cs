using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{   
        /// <summary>
        /// Треугольник
        /// </summary>
        public class Triangle : IShape
        {
            /// <summary>
            /// Первая сторона
            /// </summary>
            private double side1;

            /// <summary>
            /// Вторая сторона
            /// </summary>
            private double side2;

            /// <summary>
            /// Третья сторона
            /// </summary>
            private double side3;

            public Triangle(double side1, double side2, double side3)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
            /// <summary>
            /// Площадь треугольника через формулу Герона
            /// </summary>
            public double GetArea()
            {
                double s = (side1 + side2 + side3) / 2;
                return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            }

            /// <summary>
            /// Валидация на прямоугольный треугольник по теореме Пифагора
            /// </summary>
            public bool IsRightAngled()
            {
                return (side1 * side1 + side2 * side2 == side3 * side3) ||
                       (side1 * side1 + side3 * side3 == side2 * side2) ||
                       (side2 * side2 + side3 * side3 == side1 * side1);
            }
        }

}
