// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

const int ARRAY_SIZE = 6;
const int LEFT_RANGE = -10;
const int RIGHT_RANGE = 12;


int[] array = FillArrayWithRandomNumbers(ARRAY_SIZE, LEFT_RANGE, RIGHT_RANGE);
Console.WriteLine($" Исходный массив: {String.Join(", ", array)}");
ReverseArray(array);
Console.WriteLine($" Перевернутый массив: {String.Join(", ", array)}");

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

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
{
    int temp = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = temp;
}
}
