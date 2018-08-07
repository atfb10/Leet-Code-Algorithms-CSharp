using System;

/// <summary>
/// You're given strings J representing the types of stones that are jewels, and S representing the stones you have.
/// Each character in S is a type of stone you have.  You want to know how many of the stones you have are also jewels.
/// The letters in J are guaranteed distinct, and all characters in J and S are letters.
/// Letters are case sensitive, so "a" is considered a different type of stone from "A".
/// 
/// Example 1:
///     Input: J = "aA", S = "aAAbbbb"
///     Output: 3
///     
/// Example 2:
///     Input: J = "z", S = "ZZ"
///     Output: 0
/// </summary>

namespace JewelsAndStones
{
    class Program
    {
        static void Main(string[] args)
        {
            // test input
            string jewels = "a!bEm";
            string stones = "AzREo$i!m";

            // call method and pass in args
            Console.WriteLine("You have {0} jewels in your pile of stones!", JewelCount(jewels, stones));

            // keep console open
            Console.Read();
        }

        /// <summary>
        /// Method to tell how many jewels are in pile of stones
        /// Counter for number of jewels
        /// Boolean array to hold which stones are jewels. 128 is the max array size because that is the amount of ASCII characters
        /// Loop through jewels string and assign those characters as true
        /// Loop through stones, and if a stone = a jewel in the boolean array, increase counter
        /// Return the total count from the jewel counter
        /// </summary>
        /// <param name="jewels"></param>
        /// <param name="stones"></param>
        /// <returns></returns>
        private static int JewelCount(string jewels, string stones)
        {
            int counter = 0;
            bool[] isJewel = new bool[128];

            foreach (char j in jewels)
            {
                isJewel[j] = true;
            }

            foreach (char s in stones)
            {
                if (isJewel[s] == true)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
