using System;
using System.Linq;


public class CustomMinFunction
{
    public static int minNum = int.MinValue;

    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Func<int[], int> getMinNumber = getMinNum;
        Console.WriteLine(getMinNumber(nums));
    }

    public static int getMinNum(int[] numbers)
    {
        return numbers.Min();
    }

}