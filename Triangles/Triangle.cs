using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                // Check whether any of the lines aren't possible for a triangle.
                throw new ArgumentOutOfRangeException("Geometric line length cannot be 0 or negative.");
            }

            SideA = a;
            SideB = b;
            SideC = c;
        }

        public string GetTriangleType()
        {
            // Returns whether the triangle is scalene, isosceles or equilateral.
            // Scalene(ingen ens sider): No sides equal length.
            // Isosceles(ligebenet): 2/3 sides equal length.
            // Equilateral (ligesidet): All sides equal length.

            if (SideA == SideB && SideA == SideC)
            { // All sides are equal.
                return "equilateral";
            }
            else if (SideA == SideB ||SideB == SideC || SideC == SideA)
            { // 2 sides are equal.
                return "isosceles";
            }
            else
            { // No sides are equal.
                return "scalene";
            }
        }
    }
}
