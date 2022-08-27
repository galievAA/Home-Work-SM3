// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] arrNumbers = new double[10];
  for (int i = 0; i < arrNumbers.Length; i++ )
  {
    arrNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrNumbers[i] + " ");
  }

double maxNumber = arrNumbers[0];
double minNumber = arrNumbers[0];

  for (int i = 1; i < arrNumbers.Length; i++)
  {
    if (maxNumber < arrNumbers[i])
    {
      maxNumber = arrNumbers[i];
    }
        if (minNumber > arrNumbers[i])
    {
      minNumber = arrNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;
  
  Console.WriteLine("");
  Console.WriteLine($"Разница между максимальным элементом ({maxNumber}) и минимальным элементом ({minNumber}) = {decision}");

