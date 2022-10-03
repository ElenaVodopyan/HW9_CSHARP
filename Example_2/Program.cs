//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SummMtoN(int m, int n)
{
    if (m == n) return n;
    return m + SummMtoN(m + 1, n);
}

Console.WriteLine("Задайте значения M и N (M < N):");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummMtoN(m, n));