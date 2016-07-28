using System;
using System.Linq;

public class FindEvensOrOdds
{
    public static void Main()
    {
        int[] range = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string parity = Console.ReadLine();
        Predicate<int> isEven = x => x % 2 == 0;
        string result = string.Empty;

        for (int i = range[0]; i <= range[1]; i++)
        {
            if (isEven(i) && parity == "even")
                result += $" {i}";
            else if (!isEven(i) && parity == "odd")
                result += $" {i}";
        }
        Console.WriteLine(result.Trim());
    }
}