using System;

/// <summary>
/// Calculate the sum of two integers a and b, but you are not allowed to use the operator + and -.
/// 
/// Example:
///    Given a = 1 and b = 2, return 3. 
/// </summary>

namespace SumOfTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            int a = 12, b = 22;

            // call method, pass in args
            Console.WriteLine("{0} + {1} = {2}", a, b, SumInts(a, b));

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Sum ints without + - operators
        /// Handle Edge Cases
        ///     If two ints = each other, multiple first by two
        ///     If b = 0, simply return a
        /// Otherwise: 
        ///     set carry equal to bits equal in both numbers, shifted left 1
        ///     set sumNums = xor a and b bits
        ///     return the method with these two args passed in; adding to correct sum
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int SumInts(int a, int b)
        {
            if (a.Equals(b)) return a * 2;

            if (b == 0) return a;

            int carry = (a & b) << 1;
            int sumNums = a ^ b;
            return SumInts(sumNums, carry);
        }
    }
}
