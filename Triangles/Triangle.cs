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
        private string _type;

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public string GetTriangleType()
        {
            // Returns whether the triangle is scalene, isosceles or equilateral
            //scalene(ingen ens sider): No sides equal length
            //isosceles(ligebenet): 2/3 sides equal length
            //equilateral (ligesidet): All sides equal length
            if (SideA == SideB && SideA == SideC)
            { // All sides are equal
                return "equilateral";
            }
            else if (SideA == SideB ||SideB == SideC || SideC == SideA)
            { // 2 sides are equal.
                return "isosceles";
            }
            else
            { // No sides are equal
                return "scalene";
            }
        }
    }
}
