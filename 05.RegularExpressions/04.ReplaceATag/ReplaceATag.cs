using System;
using System.Text.RegularExpressions;

public class ReplaceATag
{
    public static void Main()
    {
        string input;
        Regex rgx = new Regex(@"(.*)<a(.*href=.*?(?=>))>(.*)(?=<)<\/a>(.*)");

        while ((input = Console.ReadLine()) != "end")
        {
            MatchCollection matches = rgx.Matches(input);
            foreach (Match match in matches)
                Console.WriteLine(match.Groups[1] + "[URL" + match.Groups[2].Value + "]" + match.Groups[3].Value + "[/URL]" + match.Groups[4]);
        }
    }
}