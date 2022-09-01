// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите с клавиатуры M чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] MassNumbers = new int[M];

void ImputNumbers(int M)
{
    for (int i = 0; i < M; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    MassNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Comparison (int[] MassNumbers)
{
  int count = 0;
  for (int i = 0; i < MassNumbers.Length; i++)
  {
    if(MassNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

ImputNumbers(M);

Console.WriteLine($"Всего чисел больше 0: {Comparison(MassNumbers)} ");