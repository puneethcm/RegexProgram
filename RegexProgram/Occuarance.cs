using System;
using System.Text.RegularExpressions;

namespace RegexProgram
{
	public class Occuarance
	{
		public static void FindOccuarance()
		{
			string pattren = "fox(es)?";
            string s = @"foxes are omnivorous mammals belonging to several genera of the family Canidae fox.";
            Regex regex = new Regex(pattren);
            MatchCollection matchs = regex.Matches(s);

			Console.WriteLine("fox(es) occured " + matchs.Count+" times ");
        }
	}
}

