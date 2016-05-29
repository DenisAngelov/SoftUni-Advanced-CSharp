using System;
using System.Collections.Generic;
using System.Linq;

public class TargetPractice
{
    static char[,] staircase;
    static int rows;
    static int cols;
    public static void Main()
    {

        int[] dimenstions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        rows = dimenstions[0];
        cols = dimenstions[1];
        staircase = new char[rows, cols];

        string snake = Console.ReadLine();
        int[] shotInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int shotRow = shotInfo[0];
        int shotCol = shotInfo[1];
        double radius = shotInfo[2];

        while (snake.Length < rows * cols)
            snake += snake;

        FillStaircase(snake);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                double currCell = Math.Sqrt(Math.Pow((col - shotCol), 2) + Math.Pow((row - shotRow), 2));

                if (currCell <= radius)
                    staircase[row, col] = ' ';
            }
        }

        RearrangeStaircase();
        PrintMatrix();
    }

    static void RearrangeStaircase()
    {
        for (int row = rows - 1; row > 0; row--)
        {
            for (int col = 0; col < cols; col++)
            {
                int nextRow = row - 1;
                if (staircase[row, col] != ' ')
                    continue;
                while (staircase[nextRow, col] == ' ')
                {
                    nextRow--;
                    if (nextRow < 0)
                        break;
                }
                if (nextRow < 0)
                    continue;
                staircase[row, col] = staircase[nextRow, col];
                staircase[nextRow, col] = ' ';
            }
        }
    }

    static void FillStaircase(string snake)
    {
        int snakeChar = 0;
        bool parity = true;

        for (int row = rows - 1; row >= 0; row--)
        {
            if (parity)
            {
                for (int col = cols - 1; col >= 0; col--)
                {
                    staircase[row, col] = snake[snakeChar];
                    snakeChar++;
                    parity = false;
                }
            }
            else
            {
                for (int col = 0; col < cols; col++)
                {
                    staircase[row, col] = snake[snakeChar];
                    snakeChar++;
                    parity = true;
                }
            }

        }
    }

    static void PrintMatrix()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(staircase[row, col]);
            }
            Console.WriteLine();
        }
    }

}