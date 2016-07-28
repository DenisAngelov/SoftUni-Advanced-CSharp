using System;

public class KnightsOfHonor
{
    public static void Main()
    {
        string[] data = Console.ReadLine().Split(' ');
        Action<string> names = s => Console.WriteLine($"Sir {s}");

        foreach (string name in data)
            names(name);
    }
}