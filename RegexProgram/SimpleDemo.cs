using System;
using System.Text.RegularExpressions;

namespace RegexProgram
{
	public class SimpleDemo
	{
		public const string name = "^[a]?[b]{2,}$";
		public static void SimpleRegexDemo()
		{
			Regex regex = new Regex(name);
			string[] array = { "abb", "abbb", "ab","aaa"};
			for(int i=0;i< array.Length; i++)
			{
				bool result = regex.IsMatch(array[i]);
				if (result == true)
				{
					Console.WriteLine("Valid");
				}
				else
				{
                    Console.WriteLine("In Valid");
                }
			}
		}
	}
}

