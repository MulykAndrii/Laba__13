using System;
using System.Text.RegularExpressions;
using System.Collections.Concurrent;

class Program
{
	static void Main()
	{
		string collections = @"ds3bhj y1ter wfsdg 1nh_jgf ds2c_vbg 4htref absolutly @fd @fdfgsgs";
		var separator = new char[] { '.', ',', ' ', '/', '|' };
		var arrays = collections.Split(separator);

        Regex regex = new Regex(@"^[a-z][a-zA-Z0-9_]{3,25}");

		List<string> current = new List<string>();

        for (int i = 0; i < arrays.Length; i++)
		{
			if (regex.IsMatch(arrays[i]))
			{
				current.Add(arrays[i]);
				Console.WriteLine($"This is the correct login: {arrays[i]} and it has lenght {arrays[i].Length}");
			}
		}

		var result = current.Distinct().ToArray().OrderByDescending(x => x.Length).Select(x => x).Take(2);

		foreach (var item in result)
		{
			Console.WriteLine($"The most longest words: {item}");
		}



        Console.ReadLine();
	}
}
