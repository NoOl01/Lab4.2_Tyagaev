﻿int[,] mas = new int[4, 4];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (j % 2 == 0) mas[i, j] = 0;
        else if (i % 2 == 0) mas[i, j] = 1;
        if (j % 2 == 0 && i % 2 == 1) mas[i, j] = 1;
        Console.Write(mas[i, j] + " ");
    }
    Console.WriteLine();
}