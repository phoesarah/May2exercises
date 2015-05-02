using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalc
{
    class Program
    { //2) Write a program that prompts the user for what shape they wish to calculate values on. Based on their input, 
        //calculate the area of the shape based on input of the values. Provide options for triangles, circles, squares, and rectangles. 
        static void Main(string[] args)
        {
            Console.WriteLine("I will calculate the area for you.  Please let me know what you would like me to calculuate, press:");
            Console.WriteLine("T for triangle;");
            Console.WriteLine("C for circle;");
            Console.WriteLine("S for square;");
            Console.WriteLine("or R for rectangle;");
            string input = Console.ReadLine();
            if (input == "T")
            {
                Console.Write("Thank you, Please enter the base of the triangle: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Thank you, Please enter the height of the triangle: ");
                double h = Convert.ToDouble(Console.ReadLine());
                double Area = getTriangleArea(b, h);
                Console.WriteLine("Thank you, the Area of the triangle is: " + Convert.ToString(Area));
                Console.ReadLine();
            }
            else if (input == "C")
            {
                Console.Write("Thank you, Please enter the radius of the circle: ");
                double r = Convert.ToDouble(Console.ReadLine());
                double Area = getCircleArea(r);
                Console.WriteLine("Thank you, the Area of the circle is: " + Convert.ToString(Area));
                Console.ReadLine();
            }
            else if (input == "S")
            {
                Console.Write("Thank you, A square has the same length on each side, if you have more than one length, you probably have a rectangle, please start over; otherwise, please enter the length of one side: ");
                double l = Convert.ToDouble(Console.ReadLine());
                double Area = getSquareArea(l);
                Console.WriteLine("Thank you, the Area of the square is: " + Convert.ToString(Area));
                Console.ReadLine();
            }
            else if (input == "R")
            {
                Console.Write("Thank you, please enter the length: ");
                double l = Convert.ToDouble(Console.ReadLine());
                Console.Write("Thank you, please enter the width: ");
                double w = Convert.ToDouble(Console.ReadLine());
                double Area = getRectangleArea(l, w);
                Console.WriteLine("Thank you, the Area of the rectangle is: " + Convert.ToString(Area));
                Console.ReadLine();
            }
          
        }
        static Double getTriangleArea(double b, double h)
        {
            return (b * h) / 2;
        }
        static Double getCircleArea(double r)
        {
            return Math.PI * (r*r);
        }

        static Double getSquareArea(double l)
        {
            return l*l;
        }
        static Double getRectangleArea(double l, double w)
        {
            return w * l;
        }
    }
}
