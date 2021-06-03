using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_Summer2021
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(" Q4 : ");
			//int[] arr = { 3, 1, 4, 1, 5 };
			int[] arr = { 1, 7, 3, 6, 5, 6 };
			int pivot = PivotIndex(arr);
			if (pivot > 0)
			{
				Console.WriteLine("The Pivot index for the given array is {0}", pivot);
			}
			else
			{
				Console.WriteLine("The given array has no Pivot index");
			}
		}
		public static int PivotIndex(int[] arr)
		{
			try
			{
				int leftsum = 0;//Intialized left sum and right sum
				int rightsum = 0;
				for (int i = 0; i < arr.Length; i++)
				{
					if (i == 0)                                                 //as it's bit different when i=0,separate logic has been written
					{
						leftsum = 0;
						//rightsum = 0;
						Console.WriteLine("Leftsum = " + leftsum);
						//Console.WriteLine("Rightsum = " + rightsum);
						for (int j = 1; j < arr.Length; j++)                //for i=0 ,we added up all the elements leaving the 0th element
						{
							rightsum = rightsum + arr[j];
						}
						Console.WriteLine("Rightsum = " + rightsum);
					}
					if (i > 0)
					{
						for (int k = i - 1; k < i; k++)                 //calculation of left sum using arrays and for loop
						{
							leftsum = leftsum + arr[k];
							Console.WriteLine("Leftsum = " + leftsum);
						}
						rightsum = rightsum - arr[i];
						Console.WriteLine("Right = " + rightsum);   //right sum is calculated by subtracting the whole right sum with current array element
						if (leftsum == rightsum)        //comparing left sum,right sum and if it matches we stop and return that pivot index
						{
							return i;
						}
					}
				}
				return -1;
			}

			catch (Exception e)
			{
				throw;
			}
		}
	}
}