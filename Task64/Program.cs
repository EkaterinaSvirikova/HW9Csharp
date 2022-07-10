// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет произведение натуральных чисел в промежутке от M до N.
// M = 1; N = 5. ->120
// M = 4; N = 6. -> 120

using System;
using static System.Console;
Clear();

Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());
WriteLine();
WriteLine(GetProd(m, n));
WriteLine();

int GetProd(int a, int b)
{
    return a <= b ? a * GetProd(a + 1, b) : 1;
}

