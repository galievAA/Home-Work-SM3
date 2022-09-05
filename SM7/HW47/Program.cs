﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine()); /// колличество строк

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine()); /// количество столбцов
double[,] array = new double[m, n];
double[,]ourMatrix = GetMatrix(m, n, -10, 10);
PrinMatrix(ourMatrix);

double[,] GetMatrix(int rowsCount, int columsCount,int lefatRange, int rightRange)
{
    double[,] matrix = new double[rowsCount, columsCount];

    Random rand = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            // matrix[i, j] = rand.Next(lefatRange, rightRange);
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return matrix; 
}
void PrinMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}


