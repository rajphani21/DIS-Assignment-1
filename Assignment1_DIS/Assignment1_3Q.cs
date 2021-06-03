using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_Summer2021
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Q6: Enter the sentence to convert:");
			string sentence = Console.ReadLine();
			string goatLatin = ToGoatLatin(sentence);
			Console.WriteLine("Goat Latin for the Given Sentence is {0}", goatLatin);
			Console.WriteLine();
		}
		public static string ToGoatLatin(string sentence)
		{
			String[] words = sentence.Split(' ');
			string modified_sentence = "";
			//Console.WriteLine(words.Length)
			int iteration_number = 0;
			foreach (string word in words)
			{
				//Console.WriteLine(word.Length);
				if (word[0].ToString().Equals("a", StringComparison.OrdinalIgnoreCase) || word[0].ToString().Equals("e", StringComparison.OrdinalIgnoreCase) || word[0].ToString().Equals("i", StringComparison.OrdinalIgnoreCase) || word[0].ToString().Equals("o", StringComparison.OrdinalIgnoreCase) || word[0].ToString().Equals("u", StringComparison.OrdinalIgnoreCase))
				//if(word[0].ToString() == "a" || word[0].ToString() == "e" || word[0].ToString() == "i" || word[0].ToString() == "o" || word[0].ToString() == "u")
				{
					modified_sentence = modified_sentence + " " + word + "ma";
				}
				else
				{
					modified_sentence = modified_sentence + " " + word.Substring(1) + word[0] + "ma";
				}
				iteration_number++;
				for (int i = 0; i < iteration_number; i++)
				{
					modified_sentence = modified_sentence + "a";
				}
			}
			Console.WriteLine(iteration_number);
			return modified_sentence.Substring(1);
		}
	}
}
