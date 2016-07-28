using System;
using System.Collections.Generic;
using System.Linq;

public class ListOfPredicates
{
    public static void Main()
    {
        int range_max = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        int[] divByNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string result = string.Empty;

        for (int number = 1; number <= range_max; number++)
            numbers.Add(number);

        foreach (int divisor in divByNums)
            Predicates.AddPredicate(x => x % divisor == 0);

        numbers = Predicates.ApplyPredicates(numbers);
        Console.WriteLine(string.Join(" ", numbers));

    }

    public class Predicates
    {
        public static List<Func<int, bool>> predicates = new List<Func<int, bool>>();

        public static void AddPredicate(Func<int, bool> predicate)
        {
            predicates.Add(predicate);
        }

        public static List<int> ApplyPredicates(List<int> numbers)
        {
            List<int> result = new List<int>();
            bool isDiv = true;
            for (int i = 0; i < numbers.Count; i++)
            {
                int currNum = numbers[i];
                foreach (var predicate in predicates)
                {
                    if (!predicate(currNum))
                    {
                        isDiv = false;
                        break;
                    }
                }

                if (isDiv)
                    result.Add(currNum);
                isDiv = true;
            }
            return result;
        }

    }

}