// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] arr = FillArrayWithRandomNumbers(10, -10, 10);
Console.WriteLine(string.Join(", ", arr)); // выводим исходный массив
SwapSignOfArrayElements(arr); // поменяли все знаки 
Console.WriteLine(string.Join(", ", arr)); // выводим рузультирующий массив

// метод возвращает массив на size элементов
int[] FillArrayWithRandomNumbers(int size, int leftSize, int rightSize)
//                                 10         -10             10
{
    int[] array = new int[size];

    Random random = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftSize, rightSize + 1);
    }
    return array;
}

void SwapSignOfArrayElements(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
        // array[i] = array[i] * -1:
    }

}


