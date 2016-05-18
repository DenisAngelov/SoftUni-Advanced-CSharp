using System;
using System.Collections.Generic;
using System.Linq;

public class CalcSequenceQueue
{
    public static void Main(string[] args)
    {
        const int iter = 50;
        double number = double.Parse(Console.ReadLine());
        Queue<double> numbers = new Queue<double>();
        string result = number.ToString();
        numbers.Enqueue(number);
        int calc = 1;

        while (calc != iter)
        {
            double x = numbers.Dequeue();
            numbers.Enqueue(x + 1);
            result += " " + (x + 1);

            calc++;
            if (calc == iter)
                break;

            numbers.Enqueue((2 * x) + 1);
            result += " " + ((2 * x) + 1);

            calc++;
            if (calc == iter)
                break;

            numbers.Enqueue(x + 2);
            result += " " + (x + 2);

            calc++;
            if (calc == iter)
                break;

        }
        Console.WriteLine(result.Trim());
    }
}