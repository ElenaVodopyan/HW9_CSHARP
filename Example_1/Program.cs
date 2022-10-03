// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void RecursionN(int n)
{
    Console.Write($"{n} ");
    if (n == 1) return;
    RecursionN(n - 1);
}

Console.WriteLine("Задайте значение N:");
int n = Convert.ToInt32(Console.ReadLine());
RecursionN(n);