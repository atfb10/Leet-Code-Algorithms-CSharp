using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Given a SORTED array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
/// You may assume no duplicates in the array.
/// 
/// Example 1:
/// Input: [1, 3, 5, 6], value = 6
/// Output: 3
/// 
/// Example 2:
/// Input: [1, 3, 5, 6], value = 2
/// Output 1
/// </summary>

namespace _35_SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            int[] testArr = { 1, 3, 5, 6 };
            int x = 2;

            // call method, pass in arg
            Console.WriteLine(SearchInsert(testArr, x));

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Pass in array and number desired to get index of 
        /// Sort array
        /// Create index to hold current index of number
        /// Loop through array
        /// If index value = argument value, set index to that and return it
        /// Else, convert array to list and add num to list
        /// Once added, convert back to array and sort the new array
        /// Loop through new array and return submitted value's index
        /// If index is not found, an error occurred and -1 is returned
        /// </summary>
        private static int SearchInsert(int[] input, int num)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals(num))
                {
                    return i;
                }
            }

            List<int> addNum = input.ToList();
            addNum.Add(num);
            input = addNum.ToArray();
            Array.Sort(input);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals(num))
                {
                    return i;
                }
            }

            return -1;
        }        
    }
}
