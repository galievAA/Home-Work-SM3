// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

const int ARRAY_SIZE = 6;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 12;


int[] array = FillArrayWithRandomNumbers(ARRAY_SIZE, LEFT_RANGE, RIGHT_RANGE);
int[] copyArray = CopyArray(array);

array[0] = 100;

Console.WriteLine($" Исходный массив: {string.Join(", ", array)}");
Console.WriteLine($" Скопированный массив: {string.Join(", ", copyArray)}");

// метод возвращает массив на size  элементов
int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
//                                 10         -10             10
{
    int[] array = new int[size];

    Random random = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange + 1);
    }
    return array;
}

int[] CopyArray(int[] sourceArray)
{
    int[] destinationArray = new int [sourceArray.Length];
    for(int i = 0; i < sourceArray.Length; i++)
    {
        destinationArray[i] = sourceArray[i];
    }
    return destinationArray;
}

