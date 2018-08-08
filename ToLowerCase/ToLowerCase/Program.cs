using System;
using System.Text;

/// <summary>
/// Implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.
/// Example 1:
///      Input: "Hello"
///      Output: "hello"
/// Example 2:
///      Input: "here"
///      Output: "here"
/// Example 3:
///      Input: "LOVELY"
///      Output: "lovely"
/// </summary>

namespace ToLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // test inputs
            string test1 = "Hello", test2 = "adAm", test3 = "STRING", test4 = "testing";

            // call method, pass in arg
            Console.WriteLine(LowerCase(test1));
            Console.WriteLine(LowerCase(test2));
            Console.WriteLine(LowerCase(test3));
            Console.WriteLine(LowerCase(test4));

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Take in string
        /// Convert string to char array
        /// Loop through array
        /// Check values of char
        /// If a capital, convert to lower case
        /// Done by adding 32 and casting 'char' (Because of ASCII character values)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string LowerCase(string s)
        {
            char[] a = s.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 'A' && a[i] <= 'Z')
                {
                    a[i] += (char)32;
                }
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
