/*
 * Riff Ahmad Bazlee, P465225  
 * 28/05/2019
 * Intermediate Math Library
 * Version 2.0
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The namespace which will contain the Algebraic class and its components
/// </summary>
namespace IntermediateMath
{
    public class Algebraic : Exception
    {
        /// <summary>
        /// The SquareRoot Method will find the Square root of a value
        /// <param name="a">The inputted value</param>
        /// <returns>Returns the result</returns>
        public static double SquareRoot(double a)
        {
            // If it is negative then, throw Exception
            if (a < 0.0) 
            {
                throw new Exception();
            }
            else
            {
                //return the value to the power of 1 / 2
                return Math.Pow(a, (double)1 / 2); 
            }
        }

        /// <summary>
        /// The CubeRoot Method will find the Cube root of a value
        /// </summary>
        /// <param name="a">The inputted value</param>
        /// <returns>Returns the result</returns>
        public static double CubeRoot(double a)
        {
            //return the value to the power of 1/3 times the value's sign 
            return Math.Pow(Math.Abs(a), (double)1 / 3) * (Math.Sign(a));
        }

        /// <summary>
        /// Inverse Method will find the Inverse of a value
        /// </summary>
        /// <param name="a">The inputted value</param>
        /// <returns>Returns the result</returns>
        public static double Inverse(double a)
        {
            // If zero, throw exception
            if (a == 0.0) 
            {
                throw new Exception();
            }
            else
            {
                //return 1 divided by value
                return 1 / a;
            }
        }

    }
}
