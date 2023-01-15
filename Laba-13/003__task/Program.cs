using System;
using System.Text.RegularExpressions;

class Program
{
	static void Main()
	{
		string content = "aaaaabbbbbcdddeeeedssaa";
		Regex regex = new Regex("(.)\\1+");

		Console.WriteLine(regex.Replace(content, "$1"));
		Console.ReadLine();
	}
}
	