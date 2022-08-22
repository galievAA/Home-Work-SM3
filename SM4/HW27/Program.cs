// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());
int i = 1;
int SumNumber = 0;

while (A > 0)
{
    i = A % 10;
    A = A / 10;
    SumNumber = SumNumber + i;
}

Console.WriteLine("Cумма цифр в числе = " + SumNumber);

