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
        /// Start and end points
        /// Loop until start = end
        /// Create mid to hold midpoint of the array
        /// If mid = value, return it
        /// Else, if mid is less than num, start is at former mid + 1, and recheck
        /// Same, but reverse for mid > num
        /// Not found, convert array to list and add num to list
        /// Once added, convert back to array and sort the new array
        /// Repeat binary search from before
        /// If index is not found at this point, an error occurred and -1 is returned
        /// </summary>
        private static int SearchInsert(int[] input, int num)
        {
            int start = 0, end = input.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (input[mid] == num)
                {
                    return mid;
                }

                if (input[mid] < num)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            List<int> addNum = input.ToList();
            addNum.Add(num);
            input = addNum.ToArray();
            Array.Sort(input);

            start = 0;
            end = input.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (input[mid] == num)
                {
                    return mid;
                }

                if (input[mid] < num)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return -1;
        }        
    }
}
