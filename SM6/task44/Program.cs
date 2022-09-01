﻿// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
PrintFibToN(N);

void PrintFibToN(int n)
{
    Console.Write("0 1 "); // последовательность начинается с 0 и 1 
    int neighbour1= 0;
    int neighbour2= 1;
    for(int i = 0; i < n - 2; i++)
    {
        int res = neighbour1 + neighbour2;
        Console.Write(res + " ");
        neighbour1 = neighbour2;
        neighbour2 = res;
    }
}



