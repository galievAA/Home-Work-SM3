// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


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
            matrix[i, j] = rand.Next(lefatRange, rightRange);
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