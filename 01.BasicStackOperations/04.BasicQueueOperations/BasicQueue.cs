using System;
using System.Collections.Generic;
using System.Linq;

public class BasicQueue
{
    public static void Main(string[] args)
    {
        int[] data = Console.ReadLine().Split(' ').Skip(1).Select(int.Parse).ToArray();
        Queue<int> numbers = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));

        for (int remove = 0; remove < data[0]; remove++)
            numbers.Dequeue();

        if (numbers.Count == 0)
            Console.WriteLine(0);
        else if (!numbers.Contains(data[1]))
            Console.WriteLine(numbers.Min());
        else
            Console.WriteLine("true");
    }
}