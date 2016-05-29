using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class LegoBlocks
{
    static int[][] firstBlock;
    static int[][] secondBlock;
    static int rows;
    public static void Main()
    {
        rows = int.Parse(Console.ReadLine());

        firstBlock = new int[rows][];
        secondBlock = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            
            int[] currRow = Console.ReadLine().Trim().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            firstBlock[row] = new int[currRow.Length];
            for (int num = 0; num < currRow.Length; num++)
                firstBlock[row][num] = currRow[num];
        }

        for (int row = 0; row < rows; row++)
        {
            int[] currRow = Console.ReadLine().Trim().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            secondBlock[row] = new int[currRow.Length];
            for (int num = 0; num < currRow.Length; num++)
                secondBlock[row][num] = currRow[num];
        }

        int cols = firstBlock[0].Length + secondBlock[0].Length;
        bool imperfect = false;

        for (int row = 0; row < rows; row++)
        {
            if (firstBlock[row].Length + secondBlock[row].Length != cols)
            {
                imperfect = true;
                break;
            }
        }

        if (imperfect)
        {
            int numberOfCells = 0;
            for (int row = 0; row < rows; row++)
                numberOfCells += firstBlock[row].Length + secondBlock[row].Length;
            Console.WriteLine("The total number of cells is: " + numberOfCells);
        }
        else
        {
            for (int row = 0; row < rows; row++)
            {
                Console.Write("[");
                Console.Write(string.Join(", ", firstBlock[row]));
                Console.Write(", ");
                Array.Reverse(secondBlock[row]);
                Console.Write(string.Join(", ", secondBlock[row]));
                Console.WriteLine("]");
            }
        }

    }
}