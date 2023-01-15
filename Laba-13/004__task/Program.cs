using System;
using System.Text.RegularExpressions;

class Program
{
	static void Main()
	{
		string content = "<ul> <li> <a href=\"http://softuni.bg\">SoftUni</a></li> </ul>";
		Console.WriteLine(ScriptTagsRegex(content));
		Console.WriteLine(ScriptTagsRegexComplited(content));
		Console.WriteLine(ScriptTagsToCharArray(content));


        Console.ReadLine();
	}
	public static string ScriptTagsRegex(string content) => Regex.Replace(content, "<.*?>", string.Empty);
	
	public static Regex _htmlRegex = new Regex("<.*?>", RegexOptions.Compiled);
	public static string ScriptTagsRegexComplited(string content) => _htmlRegex.Replace(content, string.Empty);
	public static string ScriptTagsToCharArray(string content)
	{
		char[] array = new char[content.Length];
		var index = 0;
		var inside = false;

		for (int i = 0; i < content.Length; i++)
		{
			var let = content[i];
			if (let == '<')
			{
				inside = true;
				continue;
			}

			if (let == '>')
			{
				inside = false;
				continue;
			}

			if (!inside)
			{
				array[index++] = let;
			}
		}

		return new string(array, 0, index);
	}
}
