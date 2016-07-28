using System;
using System.Linq;
using System.Text.RegularExpressions;

public class SeriesOfNumbers
{
    public static void Main()
    {
        string data = Console.ReadLine();

        Regex rgx = new Regex(@"(\w)\1*");
        MatchCollection matches = rgx.Matches(data.Trim());

        int group = 1;

        foreach (Match match in matches)
        {
            Console.Write(match.Value[0]);
            group++;
        }
        
        Console.WriteLine();
    }
}