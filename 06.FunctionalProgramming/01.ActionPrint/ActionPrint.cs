using System;

public class ActionPrint
{
    public static void Main()
    {
        string[] data = Console.ReadLine().Split(' ');
        Action<string> names = s => Console.WriteLine(s);

        foreach (string name in data)
            names(name);
    }
}