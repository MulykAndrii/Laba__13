using System;
using System.Text.RegularExpressions;

class Program
{
	static void Main()
	{
		var pattern = @"^[A-Z]{1}[a-zA-Z]{1,}(?: [A-Z]{1}[a-zA-Z]*){0,2}$";
		string[] names =
		{
			"James Smith",
			"35Alex salivan",
			"Susan Black",
			"$$$Scrudg MackDuck",
			"Tomka Yuriy",
			"L Prist"
		};

		Console.WriteLine("The result with help Regular Expression: ");
		for (int i = 0; i < names.Length; i++) 
		{
			if (Regex.IsMatch(names[i], pattern))
			{
				Console.WriteLine("The valid name is " + names[i]);
			}
		}

		Console.ReadLine();
	}
}
