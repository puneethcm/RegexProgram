using System;
using System.Text.RegularExpressions;

namespace RegexProgram
{
	public class URLFormate
	{
        public static void CheckURLFormate()
        {
            string pattren = @"^?(http://|https://)(www)*.[a-zA-Z]*.(com|in|org|co)";
            string[] input = { "http://www.example.com", "https://example.in", "example.com", "www.example.com", "https://www.example.in" };
            Regex regex = new Regex(pattren);
            for (int i = 0; i < input.Length; i++)
            {
                bool result = regex.IsMatch(input[i]);
                if (result == true)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Not Valid");
                }
            }
        }
	}
}

