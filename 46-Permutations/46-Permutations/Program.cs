using System;
using System.Text;

/// <summary>
/// Given a collection of distinct integers, return all possible permutations.
/// 
/// Example:
/// Input: [1, 2, 3]
/// Output: 
///   [1,2,3],
///   [1,3,2],
///   [2,1,3],
///   [2,3,1],
///   [3,1,2],
///   [3,2,1]
/// </summary>

namespace _46_Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            // input 
            int[] test = { 1, 2, 3 };
            int start = 0;
            int end = test.Length - 1;

            // call method, pass in args
            Permute(test, start, end);

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Pass in arguments
        /// convert int array to string
        /// If indexes = each other create strinbuilder class
        /// Append each int to each other
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        private static void Permute(int[] arr, int index1, int index2)
        {
            if (index1 == index2)
            {
                StringBuilder str = new StringBuilder();
                foreach (int i in arr)
                {
                    str.Append(i);
                }
                Console.WriteLine(str.ToString());
            }
            else
            {
                for (int i = index1; i <= index2; i++)
                {
                    arr = Swap(arr, index1, i);
                    Permute(arr, index1 + 1, index2);
                    arr = Swap(arr, index1, i);
                }
            }
        }

        /// <summary>
        /// Pass in array, and position ints
        /// Create temp variable to hold value of first index's postion
        /// Set first index's position to that position
        /// Set this to second index pos
        /// And set second to temp
        /// Return the new array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="position1"></param>
        /// <param name="position2"></param>
        /// <returns></returns>
        private static int[] Swap(int[] arr, int position1, int position2)
        {
            int temp;
            temp = arr[position1];
            arr[position1] = arr[position2];
            arr[position2] = temp;

            return arr;
        }
    }
}
