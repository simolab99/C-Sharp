﻿using System;

namespace Algorithms.Numeric
{
    /// <summary>
    /// A perfect square is an element of algebraic structure that is equal to the square of another element.
    /// </summary>
    public static class PerfectSquare
    {
        /// <summary>
        /// Checks if a number is a perfect square or not.
        /// </summary>
        /// <param name="number">Number too check.</param>
        /// <returns>True if is a perfect square; False otherwise.</returns>
        public static bool IsPerfectSquare(int number)
        {
            int sqrt = (int)Math.Sqrt(number);
            return sqrt * sqrt == number;
        }
    }
}
