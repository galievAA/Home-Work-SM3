// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

Console.WriteLine("Задайте массив из 8 элементов ");
int i = 0;
int[] arr = new int [8];

for(i = 0;i < 8;i++)
{
    Console.Write(arr[i]);
}

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

