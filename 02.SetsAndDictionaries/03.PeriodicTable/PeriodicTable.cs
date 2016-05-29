using System;
using System.Collections.Generic;
using System.Linq;

class PeriodicTable
{
    static void Main()
    {
        int entries = int.Parse(Console.ReadLine());
        SortedSet<string> chemicalCompounds = new SortedSet<string>();

        for (int entry = 0; entry < entries; entry++)
        {
            string[] input = Console.ReadLine().Split(' ');
            foreach (var chemical in input)
                chemicalCompounds.Add(chemical);
        }

        Console.WriteLine(String.Join(" ", chemicalCompounds));

    }
}