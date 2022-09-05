// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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
            System.Console.WriteLine(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int GetSumMainDiagonal(int[,] matrix)
{
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == j)
            {
                sum = sum + matrix[i, j];
            }
        }
        Console.WriteLine(sum);
        return;
    }
}
