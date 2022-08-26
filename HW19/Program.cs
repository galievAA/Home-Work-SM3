// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();

void N (string number)
{
  if (number[0] == number[4] || number[1] == number[3]) 
  {
    Console.WriteLine($"Число: {number} - палиндром.");
  }
  else Console.WriteLine($"Число: {number} - не палиндром.");
}

if (number!.Length == 5)
{
  N(number);
}
else  
{
    Console.WriteLine("Ошибка в написании количестве символов");
}




