using System;
using System.Text.RegularExpressions;

public class ExtractEmail
{
    public static void Main()
    {
        string data = Console.ReadLine();
        Regex rgx = new Regex(@"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)\b");
        MatchCollection matches = rgx.Matches(data);

        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}