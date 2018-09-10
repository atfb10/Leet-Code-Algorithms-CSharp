using System;

/// <summary>
/// Given an array of integers, return indeces of the two numbers
/// such that they add up to a specific target
/// 
/// You may assume that each input would have exactly one solution,
/// and you may not use the same element twice
/// 
/// Example: [ 2, 7, 15, 11 ] target = 9
///         Return [0, 1]
/// </summary>

namespace _1_TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            int[] test = { 2, 15, 7, 11 };
            int target = 17;

            // call method, assigning values returned to a new array
            int[] answer = TwoSum(test, target);

            // print results
            PrintArray(answer);
            

            // keep console open
            Console.Read();
        }


        // implement quicksort
        private static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int tmp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = tmp;

            return i + 1;
        }

        // actually sort
        private static void QSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int p = Partition(arr, start, end);

                QSort(arr, start, p - 1);
                QSort(arr, p + 1, end);
            }
        }

        /// <summary>
        /// create new array to hold values
        /// create start place
        /// create end place
        /// sort array using QuickSort
        /// Loop through array while start less than end
        /// If arr of start plus arr of end = target; add to array and return array
        /// If target higher, increment start
        /// If target lower, decrement end
        /// If never a match, return [-1, -1]
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        private static int[] TwoSum(int[] arr, int target)
        {
            int[] twoIndexes = new int[2];
            int start = 0;
            int end = arr.Length - 1;

            QSort(arr, start, end);


            while (start < end)
            {
                if (arr[start] + arr[end] == target)
                {
                    twoIndexes[0] = start;
                    twoIndexes[1] = end;
                    return twoIndexes;
                }
                else if (arr[start] + arr[end] < target)
                    start++;
                else
                    end--;
            }

            twoIndexes[0] = -1;
            twoIndexes[1] = -1;

            return twoIndexes;
        }

        // utility to neatly print two indeces
        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
