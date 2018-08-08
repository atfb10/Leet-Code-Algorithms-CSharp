using System;
using System.Text;

/// <summary>
/// Write a function that takes a string as input and returns the string reversed.
///
/// Example:
///     Given s = "hello", return "olleh".
/// </summary>

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            string test = "Hello";

            // call method, pass in arg
            Console.WriteLine(Reverse(test));

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Take in argument
        /// Convert string to char array
        /// loop through half of array (otherwise "unreverses")
        /// Reverse string through index manipulation
        /// Create stringbuilder to append characters to new string
        /// Return new string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string Reverse(string s)
        {
            char[] a = s.ToCharArray();
            for (int i = 0; i < a.Length / 2; i++)
            {
                char tmp = a[i];
                a[i] = a[a.Length - i - 1];
                a[a.Length - i - 1] = tmp;
            }
            StringBuilder str = new StringBuilder();
            foreach (char c in a)
            {
                str.Append(c);
            }
            return str.ToString();
        }
    }
}
