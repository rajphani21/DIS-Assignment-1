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
		var myList = new List<KeyValuePair<string, int>>();
		myList.Add(new KeyValuePair<string, int>("L", -1));
		myList.Add(new KeyValuePair<string, int>("R", 1));
		myList.Add(new KeyValuePair<string, int>("U", 1));
		myList.Add(new KeyValuePair<string, int>("D", -1));
		int sum = 0;
		for (int i = 0; i < moves.Length; i++)
		{
			//Console.WriteLine(moves[i]);
			//if(myList.ContainsKey("H"))
			foreach (var m in myList)
			{
				//Console.WriteLine("move : "+moves[i]+" list element: "+char.Parse(m.Key));
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
		if (sum == 0)
		{
			return true;
		}
		return false;
	}

}