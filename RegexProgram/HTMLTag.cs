using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    public class HTMLTag
    {
        public static void FindHTMLTag(string input)
        {
            const string pattern = "<[^>]+>";
            Regex regex = new Regex(pattern);
            MatchCollection matchs = regex.Matches(input);

            foreach (Match match in matchs)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}

