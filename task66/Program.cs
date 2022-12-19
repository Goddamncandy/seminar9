// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N) Console.WriteLine("Невозможно посчитать сумму!");

int Sum(int M, int N)
{
        if (M == N) return N;
        return N + Sum(M, N - 1);
}
Console.WriteLine($"Сумма элементов от {M} до {N} равна {Sum(M, N)}");