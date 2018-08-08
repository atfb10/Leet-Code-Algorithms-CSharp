using System;
using System.Text;

/// <summary>
/// Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.
/// 
/// Example 1:
///     Input: "Let's take LeetCode contest"
///     Output: "s'teL ekat edoCteeL tsetnoc"
/// </summary>

namespace ReverseWordsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            string test = "My name is Adam";

            // call method, pass in arg
            Console.WriteLine(Reverse(test));

            // keep open console
            Console.Read();
        }

        /// <summary>
        /// Pass in string
        /// Turn into string array based on space split
        /// Loop through array
        /// For each index, call method to reverse its characters
        /// Return stringbuilder object with new string 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string Reverse(string s)
        {
            string[] a = s.Split(' ');
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = ReverseWord(a[i]);
            }
            StringBuilder str = new StringBuilder();
            foreach (string st in a)
            {
                str.Append(st + " ");
            }
            return str.ToString();
        }

        /// <summary>
        /// Pass in string
        /// Turn into character array
        /// Loop through array
        /// Reverse each character
        /// Return stringbuilder object as string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string ReverseWord(string s)
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
