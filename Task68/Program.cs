// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;
Clear();

Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());
WriteLine();
WriteLine(GetAkkerman(m, n));
WriteLine();

int GetAkkerman(int a, int b)
{
    return a == 0 ? b + 1 
    : b == 0 && a > 0 ? GetAkkerman(a - 1 , 1) 
    : GetAkkerman(a - 1 , GetAkkerman(a, b - 1));
}

