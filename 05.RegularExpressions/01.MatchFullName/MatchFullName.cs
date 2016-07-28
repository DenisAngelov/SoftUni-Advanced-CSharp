using System;
using System.Text.RegularExpressions;

public class MatchFullName
{
    public static void Main()
    {
        string input;
        Regex rgx = new Regex(@"([A-Z][a-z]+)\s([A-Z][a-z]+)");

        while ((input = Console.ReadLine()) != "end")
        {
            Match match = rgx.Match(input);
            if (match.Success)
                Console.WriteLine(input);
        }
    }
}