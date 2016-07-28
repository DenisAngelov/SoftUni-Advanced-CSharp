using System;
using System.Text.RegularExpressions;

public class SentenceExtractor
{
    public static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();
        string[] data = Regex.Split(text, @"(?<=[.!?])");

        Regex rgx = new Regex(@".*?(\b" + pattern + "\b).*?[.!?]");

        foreach (string item in data)
        {
            if (rgx.IsMatch(item))
            {
                Console.WriteLine(item);
            }
        }

    }
}