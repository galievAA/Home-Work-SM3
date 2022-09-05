// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine()); /// колличество строк

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine()); /// количество столбцов

int[,]ourMatrix = GetMatrix(m, n, -10, 10);
PrinMatrix(ourMatrix);
SqrEvenIndexs(ourMatrix);
Console.WriteLine();
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
void SqrEvenIndexs(int[,] matrix)
{
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix [i, j] * matrix[i, j];
            }
        }
    }
    return;
}


