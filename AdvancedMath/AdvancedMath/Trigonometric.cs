/*
 * Riff Ahmad Bazlee, P465225  
 * 28/05/2019
 * Advanced Math Library
 * Version 2.0
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The namespace which will contain the Trigonometric class and its components
/// </summary>
namespace AdvancedMath
{
    public class Trigonometric : Exception
    {
        /// <summary>
        /// Tan method will find the Tangent of a value in degrees
        /// </summary>
        /// <param name="a">The inputted value in degrees</param>
        /// <returns>Returns the result</returns>
        public static double Tan(double a)
        {
            //Error Catching for values 90, 270, -90 -270 etc
            if (((a / 90) + 1) % 2 == 0.0) 
            {
                throw new Exception();
            }
            else
            {
                // Return zero for every 180 degrees
                if (a % 180 == 0.0) 
                {
                    return 0.0;
                }
                else
                {
                    //Convert to radians first, then return Tangent of it
                    return Math.Tan(a * Math.PI / 180); 
                }
            }
        }

        /// <summary>
        /// Sin Method will find the Sine of a value in degrees
        /// </summary>
        /// <param name="a">The inputted value in degrees</param>
        /// <returns>Returns the result</returns>
        public static double Sin(double a)
        {
            // Return zero for every 180 degrees
            if (a % 180 == 0.0) 
            {
                return 0.0;
            }
            else
            {
                //Convert to radians first, then return Sine of it
                return Math.Sin(a * Math.PI / 180);
            }
        }

        /// <summary>
        /// Cos method will find the Cosine of a value in degrees
        /// </summary>
        /// <param name="a">The inputted value in degrees</param>
        /// <returns>Returns the result</returns>
        public static double Cos(double a)
        {
            // Return zero for values every 90, 270, -90 -270 etc
            if (((a / 90) + 1) % 2 == 0.0)
            {
                return 0.0;
            }
            else
            {
                //Convert to radians first, then return Cosine of it
                return Math.Cos(a * Math.PI / 180); 
            }
        }
    }
}
