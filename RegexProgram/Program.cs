using RegexProgram;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Regex Program");
        Console.WriteLine("Choose any one option");
        Console.WriteLine("\n1:Simple demo\n2:Lower case with underscore");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                SimpleDemo.SimpleRegexDemo();
                break;
            case 2:
                SimpleDemo.LowerCase();
                break;
        }
        Console.ReadLine();
    }
}