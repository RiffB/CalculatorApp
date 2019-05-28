/*
 * Riff Ahmad Bazlee, P465225  
 * 28/05/2019
 * Basic Math Library
 * Version 2.0
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The namespace which will contain the Arithmetic class and its components
/// </summary>
namespace BasicMath
{
    public class Arithmetic : Exception
    {
        /// <summary>
        /// Add method will add two doubles together
        /// </summary>
        /// <param name="a">The Augend</param>
        /// <param name="b">The Addend</param>
        /// <returns>Returns the result</returns>

        public static double Add(double a, double b)
        {
            return (a + b);
        }

        /// <summary>
        /// Subtract method will subtract a double from another
        /// </summary>
        /// <param name="a">The Minuend</param>
        /// <param name="b">The Subtrahend</param>
        /// <returns>Returns the result</returns>
        public static double Subtract(double a, double b)
        {
            return (a - b);
        }

        /// <summary>
        /// Multiply method will multiple two doubles and return the result
        /// </summary>
        /// <param name="a">The Multiplier</param>
        /// <param name="b">The Multiplcand</param>
        /// <returns>Returns the result</returns>
        public static double Multiply(double a, double b)
        {
            return (a * b);
        }

        /// <summary>
        /// Divide method will divide a double with another and return the result
        /// </summary>
        /// <param name="a">The Dividend</param>
        /// <param name="b">The Divisor</param>
        /// <returns>Returns the result</returns>
        public static double Divide(double a, double b)
        {
            //Error catching divisor being zero
            if (b == 0.0) 
            {
                throw new Exception();
            }
            else
            {
                return (a / b);
            }
        }
    }
}
