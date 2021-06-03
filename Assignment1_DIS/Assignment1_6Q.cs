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
			try
			{
				String[] words = sentence.Split(' ');       //spliting the sentence into individual words array
				string modified_sentence = "";
				//Console.WriteLine(words.Length)
				int iteration_number = 0;
				foreach (string word in words)              //applying for each loop to apply required logic to individual words
				{
					//Console.WriteLine(word.Length);
					if (word[0].ToString().Equals("a", StringComparison.OrdinalIgnoreCase) || word[0].ToString().Equals("e", StringComparison.OrdinalIgnoreCase) || word[0].ToString().Equals("i", StringComparison.OrdinalIgnoreCase) || word[0].ToString().Equals("o", StringComparison.OrdinalIgnoreCase) || word[0].ToString().Equals("u", StringComparison.OrdinalIgnoreCase))
					//if(word[0].ToString() == "a" || word[0].ToString() == "e" || word[0].ToString() == "i" || word[0].ToString() == "o" || word[0].ToString() == "u")
					{
						modified_sentence = modified_sentence + " " + word + "ma";          //checking the word starts with vowel or not and applying the required logic
					}
					else
					{
						modified_sentence = modified_sentence + " " + word.Substring(1) + word[0] + "ma";   //checking the word starts with consonent or not and applying the required logic
					}
					iteration_number++;
					for (int i = 0; i < iteration_number; i++)      //appending 'a' character as per the position of word in the sentence
					{
						modified_sentence = modified_sentence + "a";
					}
				}
				Console.WriteLine(iteration_number);
				return modified_sentence.Substring(1);
			}

			catch (Exception e)
			{
				throw;
			}
		}
	}
}
