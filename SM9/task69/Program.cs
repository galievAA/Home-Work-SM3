// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//  A = 3; B = 5 -> 243 (3⁵)
//    A = 2; B = 3 -> 8 

        int Proizv(int a, int b)
            {
                int res = 1;
                for (int i = 1;i <= b;i++) res = res*a;
                return res;

            }

        int ProizvRek(int a, int b)
            {
                if (b == 0) return 1;
                else return a * ProizvRek(a, b - 1);

            }

        Console.WriteLine(Proizv(2, 8));
        Console.WriteLine(ProizvRek(2, 8));
