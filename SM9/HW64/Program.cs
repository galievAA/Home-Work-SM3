// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int m = inputInt("Введите положительное число");
int n = 1;
if (m < 1)
{
    Console.WriteLine("Ввели отрицательное число");
}
Console.WriteLine(naturalNumber(m, n));

int naturalNumber(int n, int m)
{
    if (m == n)
        return m;
    else
        Console.Write($"{naturalNumber(m, n + 1)}, ");
    return n;
}

int inputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}