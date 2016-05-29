using System;
using System.Collections.Generic;
using System.Linq;

public class FixEmails
{
    public static void Main(string[] args)
    {

        string input;
        Dictionary<string, string> emails = new Dictionary<string, string>();
        int counter = 1;
        string name = string.Empty;

        while ((input = Console.ReadLine()) != "stop")
        {
            if (counter % 2 != 0)
                name = input;
            else
            {
                if (!input.EndsWith("us") && !input.EndsWith("uk"))
                    emails.Add(name, input);
                else
                    continue;
            }
            counter++;
        }

        foreach (var pair in emails)
        {
            Console.WriteLine(pair.Key + " -> " + pair.Value);
        }

    }
}