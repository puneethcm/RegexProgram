using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace RegexProgram
{
	public class HTMLTag
	{
        //const string htmlTag = "\"<(\\\"[^\\\"]*\\\"|'[^']*'|[^'\\\">])*>\"";
        public static void FindHTMLTag(string input)
		{
            const string htmlTag = "(^[<[a-z]>])?";
            Regex regex = new Regex(htmlTag);
			string[] value = input.Split();
			for(int i = 0; i < value.Length; i++)
			{
                Match r = regex.Match(value[i]);
				bool result = r.Success;
				if(result == true)
				{
					Console.WriteLine(value[i]);
				}
				
            }
		}
	}
}

