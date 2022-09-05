﻿// Задача 48: Задайте двумерный массив размера m на n, каждый элемент
// в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine()); /// колличество строк

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine()); /// количество столбцов

int[,]ourMatrix = GetMatrix(m, n, -10, 10);
PrinMatrix(ourMatrix);

int[,] GetMatrix(int rowsCount, int columsCount,int lefatRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columsCount];

    Random rand = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix; 
}
void PrinMatrix(int[,] matrix)
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