using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_Summer2021
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Q3 : ");
            int[] arr = { 1, 2, 3, 1, 1, 3 };
            int gp = NumIdenticalPairs(arr);
            Console.WriteLine("The number of IdenticalPairs in the array are {0}:", gp);
        }
        public static int NumIdenticalPairs(int[] nums)
        {
            try
            {
                int count = 0;
                Console.WriteLine(nums.Length);
                for (int i = 0; i < nums.Length; i++)//used to for loops to compare one element with all other remaining elements
                {
                    for (int j = 1; j < nums.Length; j++)
                    {
                        if (i < j)
                        {
                            if (nums[i] == nums[j])//if this condition satisfies they make a pair and hence count is incremented
                            {
                                Console.WriteLine("i : " + i + " j : " + j);
                                count++;
                            }
                        }
                    }
                }
                return count;
            }

            catch (Exception e)
            {
                throw;
            }
        }
    }
}
