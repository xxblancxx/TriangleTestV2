using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Test Cases: Successful.
            //Triangle1: SideA: 5 SideB: 5 SideC: 5  Result: equilateral.
            //Triangle2:  SideA: 3 SideB: 10 SideC: 3 Result: isosceles.
            //Triangle3:  SideA: 5 SideB: 6 SideC: 1  Result: scalene.
            //Triangle4:  SideA: 1,5 SideB: 2 SideC: 1  Result: scalene.

            var triangle1 = new Triangle(5,5,5);
            CompareExpectation("equilateral",triangle1.GetTriangleType());

            var triangle2 = new Triangle(3,10,3);
            CompareExpectation("isosceles", triangle2.GetTriangleType());

            var triangle3 = new Triangle(5,6,1);
            CompareExpectation("scalene", triangle3.GetTriangleType());
            var triangle4 = new Triangle(1.5,2,1);
            CompareExpectation("scalene", triangle4.GetTriangleType());

        }

        public static void CompareExpectation(string expected, string result)
        {
            if (expected.Equals(result))
            {
                Console.Write(result + " | " + expected);
                Console.WriteLine("     Match between expectation and result     (success)");
            }
            else
            {
                Console.WriteLine("Failed. expectation: {0}, result: {1}         (fail)", expected,result);
            }
        }
    }
}
