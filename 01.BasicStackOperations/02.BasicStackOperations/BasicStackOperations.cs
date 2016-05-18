using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BasicStackOperations
{
    public static void Main(string[] args)
    {
        int[] data = Console.ReadLine().Split(' ').Skip(1).Select(int.Parse).ToArray();
        Stack<int> numbers = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

        for (int i = 0; i < data[0]; i++)
            if (numbers.Count == 0)
                break;
            else
                numbers.Pop();

        if (numbers.Count == 0)
            Console.WriteLine(0);
        else if (numbers.Contains(data[1]))
            Console.WriteLine("true");
        else
            Console.WriteLine(numbers.OrderBy(x => x).First());
    }
}