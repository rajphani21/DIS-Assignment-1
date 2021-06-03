using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Q1 : Enter the Moves of Robot:");
		string moves = Console.ReadLine();
		//Console.WriteLine(moves.Length);
		bool pos = JudgeCircle(moves);
		if (pos)
		{
			Console.WriteLine("The Robot return’s to initial Position (0,0)");
		}
		else
		{
			Console.WriteLine("The Robot doesn’t return to the Initial Postion (0,0)");
		}
		//Console.WriteLine();
	}

	public static bool JudgeCircle(String moves)
	{
		try
		{
			var myList = new List<KeyValuePair<string, int>>();//Declared a list with key value pairs,so as to easily access moves and values
			myList.Add(new KeyValuePair<string, int>("L", -1));//Assigned values to each moves
			myList.Add(new KeyValuePair<string, int>("R", 1));
			myList.Add(new KeyValuePair<string, int>("U", 1));
			myList.Add(new KeyValuePair<string, int>("D", -1));
			int sum = 0;
			for (int i = 0; i < moves.Length; i++)//breaking down all the steps entered and added the values as per the list created
			{

				foreach (var m in myList)
				{
					if (moves[i] == char.Parse(m.Key))
					{
						sum = sum + m.Value;

					}
					/*else
					{
						Console.WriteLine("you have entered wrong entry: "+moves[i]);	
					}*/

					//Console.WriteLine(m);
				};
			}
			Console.WriteLine("Sum = " + sum);
			if (sum == 0)//if sum =0 ,it conveys that user has came back to the starting point.
			{
				return true;
			}
			return false;
		}

		catch (Exception)
		{
			throw;
		}
	}

}