using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Kind_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input: three sides of the triangle
            Console.WriteLine("Enter the length of the first side: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the second side: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the third side: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            // Check if it's a valid triangle
            if ((side1 + side2 > side3) && (side2 + side3 > side1) && (side1 + side3 > side2))
            {
                // Determine the type of triangle
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is equilateral.");
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    Console.WriteLine("The triangle is isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is scalene.");
                }
            }
            else
            {
                Console.WriteLine("The given sides do not form a valid triangle.");
            }
        }
    }
}
