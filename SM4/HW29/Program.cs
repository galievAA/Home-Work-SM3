// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// способ 1


int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,9);
    Console.WriteLine(array[i] + " ");
}
for (int i = 0; i < array.Length; i++) 
{
    if (array[i] % 2 != 0)
{
    array[i] = 0;
    Console.WriteLine(array[i] + " ");
}
}

// Способ 2
// Console.WriteLine("Задайте массив из 8 элементов ");

// int[] arr = new int [8];

// for(i = 0;i < arr.Length;i++)
// {
//     arr[i] = new Random().Next(0,9);
// }

// Console.WriteLine("Задайте массив из 8 элементов ");

// int[] arr = new int[8];
// int i = 0;
// void PrintArray(int[] array)
// {
//         int count = array.Length;

//         for(int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
// void SelectionSort(int[] array)
// {
//     for(int i = 0; i < array.Length - 1; i++);

//     int minPosition = i;

//     for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j;
//         }

//     int temporary = array[i];
//     array[i] = array[minPosition];
//     array[minPosition] = temporary;
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

