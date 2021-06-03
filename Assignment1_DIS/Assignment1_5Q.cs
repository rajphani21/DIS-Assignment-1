using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_Summer2021
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(" Q5 : ");
			Console.WriteLine("Enter the First Word:");
			String word1 = Console.ReadLine();
			Console.WriteLine("Enter the Second Word:");
			String word2 = Console.ReadLine();
			String merged = MergeAlternately(word1, word2);
			Console.WriteLine("The Merged Sentence formed by both words is {0}", merged);
		}
		public static String MergeAlternately(string word1, string word2)
		{
			try
			{
				String merge = "";
				for (int i = 0, j = 0; i < word1.Length || j < word2.Length; i++, j++) //intialized two variable i and j for two user input words
				{
					//Console.WriteLine(i);
					//if(int.Parse(word1[i].ToString())== 0)
					if (i < word1.Length)
					{
						//Console.WriteLine("inside");
						merge = merge + word1[i].ToString();        //merges a letter from first word
					}
					if (j < word2.Length)
					{
						merge = merge + word2[j].ToString();        //merges a letter from second word and the process continues till all the letters are merged
					}
					//Console.WriteLine("each Merged sentence : "+ merge);
				}
				Console.WriteLine("Merged sentence : " + merge);
				return merge;
			}

			catch (Exception e)
			{
				throw;
			}
		}
	}
}
