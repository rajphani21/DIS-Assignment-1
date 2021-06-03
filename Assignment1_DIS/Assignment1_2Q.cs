using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_Summer2021
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(" Q2 : Enter the string to check for pangram:");
			string s = Console.ReadLine();
			s = s.ToLower();//Converting all the letters to lowercase
			bool flag = CheckIfPangram(s);
			if (flag)
			{
				Console.WriteLine("Yes, the given string is a pangram");
			}
			else
			{
				Console.WriteLine("No, the given string is not a pangram");
			}
			//Console.WriteLine();
		}
		public static bool CheckIfPangram(String s)
		{
			try
			{
				int count = 0;
				String all_eng_alp = "abcdefghijklmnopqrstuvwxyz";//Intialized all the alphabets
				String s_modified = new String(s.Distinct().ToArray());//modified the input string by removing all the repititive letters
				/*for (int i = 0; i < all_eng_alp.Length; i++)
				{
					bool check = s.Contains(all_eng_alp[i]);
					if (check)
					{
						count++;
					}
				}*/
				for (int i = 0; i < all_eng_alp.Length; i++)
				{
					for (int j = 0; j < s_modified.Length; j++)
					{
						if (all_eng_alp[i] == s_modified[j])  //compared the distinct input string with all the alphabets.
						{
							count++;
						}
					}
				}
				Console.WriteLine(count);
				if (count == 26) //if count = 26 ,it means input string consists of all the alphabets.
				{
					return true;
				}
				return false;
			}

			catch (Exception e)
			{
				throw;
			}
		}
	}
}