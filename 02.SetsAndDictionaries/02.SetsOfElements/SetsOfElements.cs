using System;
using System.Collections.Generic;
using System.Linq;

class SetsOfElements
{
    static void Main(string[] args)
    {
        int[] setSizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        HashSet<int> firstSet = new HashSet<int>();
        HashSet<int> secondSet = new HashSet<int>();

        for (int entry = 0; entry < setSizes[0]; entry++)
            firstSet.Add(int.Parse(Console.ReadLine()));

        for (int entry = 0; entry < setSizes[1]; entry++)
            secondSet.Add(int.Parse(Console.ReadLine()));

        firstSet.IntersectWith(secondSet);

        Console.WriteLine(String.Join(" ", firstSet));

    }
}