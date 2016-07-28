using System;
using System.Text.RegularExpressions;

public class MatchPhoneNumber
{
    public static void Main()
    {
        string input;
        Regex rgx = new Regex(@"^(\+359\s2\s[0-9]{3}\s[0-9]{4})|(\+359\-2\-[0-9]{3}\-[0-9]{4})$");

        while ((input = Console.ReadLine()) != "end")
        {
            Match match = rgx.Match(input.Trim());
            if (match.Success)
                Console.WriteLine(input);
        }
    }
}