using System;
using System.Collections.Generic;

class UniqueUsernames
{
    static void Main(string[] args)
    {
        int entries = int.Parse(Console.ReadLine());
        HashSet<string> usernames = new HashSet<string>();

        for (int entry = 0; entry < entries; entry++)
            usernames.Add(Console.ReadLine());

        foreach (var username in usernames)
            Console.WriteLine(username);
    }
}