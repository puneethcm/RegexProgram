using RegexProgram;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Regex Program");
        Console.WriteLine("Choose any one option");
        Console.WriteLine("\n1:Simple demo\n2:Lower case with underscore\n3:Find HTML tags\n4:Find Occurance");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                SimpleDemo.SimpleRegexDemo();
                break;
            case 2:
                SimpleDemo.LowerCase();
                break;
            case 3:
                string input = "<p> The <code> Regex </code> is a compiled\nrepresentation of a regular expression. </p>";
                HTMLTag.FindHTMLTag(input);
                break;
            case 4:
                Occuarance.FindOccuarance();
                break;
        }
        Console.ReadLine();
    }
}