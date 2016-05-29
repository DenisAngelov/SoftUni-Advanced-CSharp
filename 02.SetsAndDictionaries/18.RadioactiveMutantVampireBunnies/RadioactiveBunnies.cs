using System;
using System.Collections.Generic;
using System.Linq;

public class RadioactiveBunnies
{
    static int rows;
    static int cols;
    static char[,] racetrack;
    static int playerRow;
    static int playerCol;
    static bool first = true;
    static bool second = false;
    public static void Main()
    {
        int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        rows = dimensions[0];
        cols = dimensions[1];
        racetrack = new char[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            char[] data = Console.ReadLine().Replace("B", "b").ToCharArray();
            for (int col = 0; col < cols; col++)
            {
                racetrack[row, col] = data[col];
                if (racetrack[row, col] == 'P')
                {
                    playerRow = row;
                    playerCol = col;
                    racetrack[row, col] = '.';
                }
            }
        }

        char[] commands = Console.ReadLine().ToCharArray();
        bool playerWon = false;
        bool playerDead = false;

      
        foreach (char direction in commands)
        {
            playerWon = PlayerMove(direction);
            playerDead = SpreadBunnies();
            if (playerWon)
                break;
            if (playerDead)
                break;
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (racetrack[row, col] == 'a' || racetrack[row, col] == 'b')
                    racetrack[row, col] = 'B';
                Console.Write(racetrack[row, col]);
            }
            Console.WriteLine();
        }

        if (playerWon)
        {
            Console.WriteLine("won: {0} {1}", playerRow, playerCol);
        }
        else
            Console.WriteLine("dead: {0} {1}", playerRow, playerCol);

    }
    public static bool PlayerMove(char direction)
    {
        switch (direction)
        {
            case 'L': playerCol--; break;
            case 'R': playerCol++; break;
            case 'U': playerRow--; break;
            case 'D': playerRow++; break;
        }

        if (playerRow == rows)
        {
            playerRow--;
            return true;
        }
        else if (playerRow < 0)
        {
            playerRow++;
            return true;
        }
        else if (playerCol < 0)
        {
            playerCol++;
            return true;
        }
        else if (playerCol == cols)
        {
            playerCol--;
            return true;
        }
        else
            return false;
    }

    public static bool SpreadBunnies()
    {
        

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {

                if (first)
                {
                    if (racetrack[row, col] != 'b')
                        continue;

                    if (row + 1 < rows)
                        racetrack[row + 1, col] = 'a';
                    if (row - 1 >= 0)
                        racetrack[row - 1, col] = 'a';
                    if (col + 1 < cols)
                        racetrack[row, col + 1] = 'a';
                    if (col - 1 >= 0)
                        racetrack[row, col - 1] = 'a';
                }
                else
                {
                    if (racetrack[row, col] != 'a')
                        continue;

                    if (row + 1 < rows)
                        racetrack[row + 1, col] = 'b';
                    if (row - 1 >= 0)
                        racetrack[row - 1, col] = 'b';
                    if (col + 1 < cols)
                        racetrack[row, col + 1] = 'b';
                    if (col - 1 >= 0)
                        racetrack[row, col - 1] = 'b';

                }
            }
        }

        if (first)
        {
            first = false;
            second = true;
        }
        else
        {
            first = true;
            second = false;
        }

        if (racetrack[playerRow, playerCol] == 'a' || racetrack[playerRow, playerCol] == 'b')
            return true;
        else
            return false;
    }
}