using System;
using System.Collections.Generic;
using System.Linq;

public class PredicateForNames
{
    public static void Main()
    {
        int max_length = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine().Split(' ');
        Predicate<string> nameLength = name => name.Length <= max_length;

        foreach (string name in names)
        {
            if (nameLength(name))
                Console.WriteLine(name);
        }
    }
}