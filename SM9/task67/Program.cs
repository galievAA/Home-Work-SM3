//   Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//   453 -> 12
//  45 -> 9 */

int SumDigits(int x)
            {

                int sum = 0;
                while (x > 0)
                {
                    sum = sum + x % 10;
                    x = x / 10;
                }
                return sum;
            }

            int SDRek(int x)
            {
                if (x == 0) return 0;
                else return x % 10 + SDRek(x / 10);
            }



            Console.WriteLine(SumDigits(385));
            Console.WriteLine(SDRek(385));