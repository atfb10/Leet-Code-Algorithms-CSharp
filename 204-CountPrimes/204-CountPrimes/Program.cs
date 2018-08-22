using System;

/// <summary>
/// Count the number of prime numbers less than a non-negative number, n.
/// 
/// Example:
/// Input: 10
/// Output: 4
/// Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.
/// </summary>

namespace _204_CountPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int x = 12;

            // call method, pass in args
            Console.WriteLine(CountPrime(x));

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Pass in an integer
        /// If integer is negative, throw -1 indicating error
        /// Create counter to count number of primes
        /// Create bool array to indicate whether or not an integer is prime
        /// Loop from two until num arg is hit
        /// If index value is false, then add 1 to counter
        /// Loop until i * j hits num value
        /// Array of i * j = true
        /// Return the counter
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static int CountPrime(int num)
        {
            if (num < 0)
            {
                return -1;
            }

            int counter = 0;
            bool[] arr = new bool[num];

            for (int i = 2; i < num; i++)
            {
                if (arr[i] == false)
                {
                    counter++;
                }

                for (int j = 2; i * j < num; j++)
                {
                    arr[i * j] = true;
                }
            }

            return counter;
        }
    }
}
