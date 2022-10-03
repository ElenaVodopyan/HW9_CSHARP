// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Accerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Accerman(m - 1, 1);
    return Accerman(m - 1, Accerman(m, n - 1));
}

Console.WriteLine("Задайте значения M и N (M < N):");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Accerman(m, n));