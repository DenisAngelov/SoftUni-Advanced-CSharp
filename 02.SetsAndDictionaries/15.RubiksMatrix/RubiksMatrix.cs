using System;
using System.Collections.Generic;
using System.Linq;

public class RubiksMatrix
{
    static int rows;
    static int cols;
    static int[,] rubik;
    public static void Main()
    {
        int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        rows = dimensions[0];
        cols = dimensions[1];
        int numberOfCommands = int.Parse(Console.ReadLine());
        rubik = new int[rows, cols];

        for (int index = 0; index < rows * cols; index++)
            rubik[index / cols, index % cols] = index + 1;

        for (int i = 0; i < numberOfCommands; i++)
        {
            string[] command = Console.ReadLine().Split(' ');
            int arrayIndex = int.Parse(command[0]);
            int moves = int.Parse(command[2]);

            if (moves == 0)
                continue;

            switch (command[1])
            {
                case "up":
                case "down": RotateCol(arrayIndex, command[1], moves); break;
                case "left":
                case "right": RotateRow(arrayIndex, command[1], moves); break;
            }

        }

        RearrangeRubik();

    }

    public static void RotateCol(int col, string direction, int moves)
    {
        moves %= rows;

        if (moves == 0)
            return;

        Queue<int> currCol = new Queue<int>();

        for (int row = 0; row < rows; row++)
            currCol.Enqueue(rubik[row, col]);

        if (direction == "down")
            currCol = new Queue<int>(currCol.Reverse());

        for (int move = 0; move < moves; move++)
        {
            int temp = currCol.Dequeue();
            currCol.Enqueue(temp);
        }

        if (direction == "down")
            currCol = new Queue<int>(currCol.Reverse());

        for (int row = 0; row < rows; row++)
            rubik[row, col] = currCol.Dequeue();

    }

    public static void RotateRow(int row, string direction, int moves)
    {
        moves %= cols;

        if (moves == 0)
            return;

        Queue<int> currRow = new Queue<int>();

        for (int col = 0; col < cols; col++)
            currRow.Enqueue(rubik[row, col]);

        if (direction == "right")
            currRow = new Queue<int>(currRow.Reverse());

        for (int move = 0; move < moves; move++)
        {
            int temp = currRow.Dequeue();
            currRow.Enqueue(temp);
        }

        if (direction == "right")
            currRow = new Queue<int>(currRow.Reverse());

        for (int col = 0; col < cols; col++)
            rubik[row, col] = currRow.Dequeue();

    }

    public static void RearrangeRubik()
    {
        int checker = 1;

        for (int row1 = 0; row1 < rows; row1++)
        {
            for (int col1 = 0; col1 < cols; col1++)
            {
                int currItem = rubik[row1, col1];

                if (checker == currItem)
                    Console.WriteLine("No swap required");
                else
                {
                    bool foundElem = false;

                    for (int row2 = 0; row2 < rows; row2++)
                    {
                        for (int col2 = 0; col2 < cols; col2++)
                        {
                            if (checker != rubik[row2, col2])
                                continue;

                            foundElem = true;
                            Console.WriteLine("Swap ({0}, {1}) with ({2}, {3})", row1, col1, row2, col2);
                            rubik[row1, col1] = rubik[row2, col2];
                            rubik[row2, col2] = currItem;
                        }
                        if (foundElem)
                            break;
                    }
                }
                checker++;
            }
        }
    }

}