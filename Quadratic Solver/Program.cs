using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Solver
{
    class Program
    { //  1) Write a quadratic equation solver. Make sure to enable the program to be able to execute again by prompting the user "Perform another calculation?" 
        //square root function is math.sqrt 
        static void Main(string[] args)
        {
            Console.WriteLine("A quadratic Equation is Ax^2 + Bx + C = 0.  Please enter your numbers in this format: Put A then hit enter."
            + "Then enter B, then hit enter, then C and enter.");

            double A = Convert.ToInt32(Console.ReadLine());
            double B = Convert.ToInt32(Console.ReadLine());
            double C = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Your answer is either " + Convert.ToString(Quadratic1(A, B, C)));
           Console.WriteLine(" or " + Convert.ToString(Quadratic2(A, B, C)));
            Console.ReadLine();
        }
        static double Quadratic1(double A, double B, double C)
        {
            double system = ((B * B) - (4*A*C));
            double result = ((-B) +  Math.Sqrt(system))/(2 *A);
             return result;
        }
        static double Quadratic2(double A, double B, double C)
        {
            double system = ((B * B) - (4 * A * C));
            double result = ((-B) - Math.Sqrt(system))/(2 * A);
            return result;
        }
     }
            
 }
    

