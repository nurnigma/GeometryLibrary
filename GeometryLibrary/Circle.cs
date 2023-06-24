using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary
{
    /// <summary>
    /// Окружность
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// Радиус
        /// </summary>
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
