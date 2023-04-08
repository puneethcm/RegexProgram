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
					Console.WriteLine(array[i] + " : is Valid");
				}
				else
				{
                    Console.WriteLine(array[i] + " : is Not Valid");
                }
			}
		}

		public static void LowerCase()
		{
			const string pattern = "^[a-z]+_[a-z]+$";
			Regex regex = new Regex(pattern);
			string[] strArray = { "abc_abc", "aaa_bbb", "ABc_Dca" };
			for(int i = 0; i < strArray.Length; i++)
			{
				bool result = regex.IsMatch(strArray[i]);
                if (result == true)
                {
                    Console.WriteLine(strArray[i]+" : is Valid");
                }
                else
                {
                    Console.WriteLine(strArray[i] + " : is Not Valid");
                }
            }

        }
	}
}

