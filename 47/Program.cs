﻿/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void FillArray2D(double[,] array2D)
{
    Random rand = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rand.NextDouble();
        }
    }
}

void PrintArray2D(double[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write($"{Math.Round(array2D[i, j],2)}" + " ");
        }
        System.Console.WriteLine();
    }
}
int rows = 3;
int colums = 4;
double[,] array2D = new double[rows, colums];
FillArray2D(array2D);
PrintArray2D(array2D);


